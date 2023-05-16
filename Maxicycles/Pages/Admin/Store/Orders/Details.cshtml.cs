using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Orders;

public class DetailsModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DetailsModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public Order Order { get; set; } = default!;
    public Card Card { get; set; } = default!;
    public IList<OrderItemDetailsModel> OrderItemDetails { get; set; } = default!;
    public MaxicyclesUser MaxicyclesUser { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the is not null.
        if (id == null) return NotFound();

        // Get the order from the database that matches the parameter id.
        var order = await _context.Orders
            .Include(o => o.OrderItems)
            .Include(o => o.Payment)
            .Include(o => o.MaxicyclesUser)
            .Include(o => o.DeliveryMethod)
            .FirstOrDefaultAsync(m => m.Id == id);

        // If the order does not exist, return not found.
        if (order == null) return NotFound("Order does not exist");

        // Populate the Order model with data from the database.
        Order = order;

        // Convert all of the utc times from the database to local time.
        Order.OrderDate = Order.OrderDate.ToLocalTime();
        Order.RequiredDate = Order.RequiredDate.ToLocalTime();
        Order.ShippedDate = Order.ShippedDate?.ToLocalTime();

        MaxicyclesUser = order.MaxicyclesUser;

        // Check if the payment is card.
        if (Order.Payment is Card card)
        {
            // Add card details from the database to the model.
            Card = card;
            Card.ExpiryDate = Card.ExpiryDate.ToLocalTime();
        }

        // Populate the list model with a list of item details.
        OrderItemDetails = new List<OrderItemDetailsModel>();

        // Iterate over all ordersItems associated with the current order.
        foreach (var item in order.OrderItems)
            OrderItemDetails.Add(new OrderItemDetailsModel
            {
                Title = item.Title,
                ItemPrice = item.ItemPrice,
                Quantity = item.Quantity,
                LinePrice = item.ItemPrice * item.Quantity
            });
        return Page();
    }

    public class OrderItemDetailsModel
    {
        public string? Title { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal LinePrice { get; set; }
    }
}