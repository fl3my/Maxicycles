using System.ComponentModel.DataAnnotations;
using Maxicycles.Data;
using Maxicycles.Enums;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Checkout;

public class CardPaymentModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public CardPaymentModel(MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [BindProperty] public decimal TotalPrice { get; set; }

    [BindProperty] public CardInputModel CardInput { get; set; } = default!;

    public IActionResult OnGet(int orderId)
    {
        var userId = _userManager.GetUserId(User);

        if (userId == null) return Unauthorized();

        // Get the users order.
        var order = _context.Orders.Where(o => o.MaxicyclesUserId == userId).FirstOrDefault(o => o.Id == orderId);

        if (order == null) return NotFound();

        // Get the total price.
        TotalPrice = order.TotalPrice;

        return Page();
    }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync(int orderId)
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null) return Unauthorized();

        // Get the users order.
        var order = _context.Orders.Where(o => o.MaxicyclesUserId == user.Id).FirstOrDefault(o => o.Id == orderId);

        if (order == null) return NotFound();

        if (!ModelState.IsValid) return Page();

        CardInput.ExpiryDate = CardInput.ExpiryDate.ToUniversalTime();

        var card = new Card
        {
            Name = CardInput.Name,
            LongNumber = CardInput.LongNumber,
            ExpiryDate = CardInput.ExpiryDate,
            AddressLine1 = CardInput.AddressLine1,
            AddressLine2 = CardInput.AddressLine2,
            City = CardInput.City,
            Postcode = CardInput.Postcode,
            Order = order,
            IsPaid = true
        };

        // Change the status to awaiting shipment as payment has been made.
        order.OrderStatus = OrderStatus.AwaitingShipment;

        _context.Attach(order).State = EntityState.Modified;

        _context.Cards.Add(card);

        await _context.SaveChangesAsync();

        return RedirectToPage("./PaymentConfirmation", new { orderId = order.Id });
    }

    public class CardInputModel
    {
        [Required] public string? Name { get; set; }

        [DataType(DataType.CreditCard)] public string? LongNumber { get; set; }

        [Required] [DataType(DataType.Date)] public DateTime ExpiryDate { get; set; }

        [Required] public string? AddressLine1 { get; set; }

        public string? AddressLine2 { get; set; }

        [Required] public string? City { get; set; }

        [Required] public string? Postcode { get; set; }
    }
}