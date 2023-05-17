using System.Text;
using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Checkout;

public class ConfirmationModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly IEmailSender _sender;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public ConfirmationModel(UserManager<MaxicyclesUser> userManager, IEmailSender sender, MaxicyclesDbContext context)
    {
        _userManager = userManager;
        _sender = sender;
        _context = context;
    }

    public string? Email { get; set; }

    public async Task<IActionResult> OnGet(int orderId)
    {
        // Get the confirmed order.
        var order = await _context.Orders
            .Include(o => o.Payment)
            .Include(o => o.MaxicyclesUser)
            .Include(o => o.OrderItems)
            .Include(o => o.DeliveryMethod)
            .FirstOrDefaultAsync(o => o.Id == orderId);

        if (order == null) return NotFound();

        // Get the current logged in user.
        var user = await _userManager.GetUserAsync(User);

        if (user == null) return NotFound();

        // Check if the current order belongs to the user.
        if (order.MaxicyclesUser.Id != user.Id) return Unauthorized();

        // Check if the receipt has been sent already.s
        if (order.ReceiptSent) return NotFound("Sorry a receipt has already been sent");

        if (order.Payment == null) return NotFound();

        if (!order.Payment.IsPaid) return NotFound();

        Email = user.Email;

        if (Email == null) return Unauthorized();

        // Send an email.
        await _sender.SendEmailAsync(Email, "Order Confirmation", GenerateEmailReceipt(order));

        // Change the status to awaiting shipment as payment has been made.
        order.ReceiptSent = true;
        _context.Attach(order).State = EntityState.Modified;

        await _context.SaveChangesAsync();

        return Page();
    }

    public string GenerateEmailReceipt(Order order)
    {
        var sb = new StringBuilder();
        sb.AppendLine("<!DOCTYPE html>");
        sb.AppendLine("<html>");
        sb.AppendLine("<head>");
        sb.AppendLine("<meta charset=\"UTF-8\">");
        sb.AppendLine("<title>Email Receipt</title>");
        sb.AppendLine("</head>");
        sb.AppendLine("<body>");
        sb.AppendLine("<h2>Order Receipt</h2>");
        sb.AppendLine("<hr>");
        sb.AppendLine($"<p>Order Number: {order.Id}</p>");
        sb.AppendLine($"<p>Order Date: {order.OrderDate.ToLocalTime()}</p>");
        sb.AppendLine($"<p>Customer Name: {order.MaxicyclesUser.FirstName + ' ' + order.MaxicyclesUser.LastName}</p>");
        sb.AppendLine($"<p>Customer Email: {order.MaxicyclesUser.Email}</p>");
        sb.AppendLine("<h3>Shipping Information</h3>");
        sb.AppendLine($"<p>Address Line 1: {order.AddressLine1}</p>");
        sb.AppendLine($"<p>Address Line 2: {order.AddressLine2}</p>");
        sb.AppendLine($"<p>City: {order.City}</p>");
        sb.AppendLine($"<p>Postal Code: {order.Postcode}</p>");
        sb.AppendLine("<table>");
        sb.AppendLine("<tr>");
        sb.AppendLine("<th>Product</th>");
        sb.AppendLine("<th>Quantity</th>");
        sb.AppendLine("<th>Price</th>");
        sb.AppendLine("<th></th>");
        sb.AppendLine("</tr>");
        foreach (var item in order.OrderItems)
        {
            sb.AppendLine("<tr>");
            sb.AppendLine($"<td>{item.Title}</td>");
            sb.AppendLine($"<td>{item.Quantity}</td>");
            sb.AppendLine($"<td>{item.ItemPrice * item.Quantity}</td>");
            if (item is OrderService service) sb.AppendLine($"<td>{service.ServiceDate.ToLocalTime()}</td>");
            sb.AppendLine("</tr>");
        }

        sb.AppendLine("<tr>");
        sb.AppendLine($"<td>{order.DeliveryMethod.Title}</td>");
        sb.AppendLine("<td></td>");
        sb.AppendLine($"<td>{order.DeliveryMethod.Price}</td>");
        sb.AppendLine("</tr>");
        sb.AppendLine("</table>");
        sb.AppendLine($"<p>Total Amount: {order.TotalPrice}</p>");
        sb.AppendLine("</body>");
        sb.AppendLine("</html>");

        return sb.ToString();
    }
}