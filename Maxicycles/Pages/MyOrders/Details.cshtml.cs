using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.MyOrders;

public class DetailsModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public DetailsModel(MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public Order Order { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check that the id is not null.
        if (id == null) return NotFound();

        // Get the current logged in user id.
        var userId = _userManager.GetUserId(User);

        // Return unauthorized if a user is not logged in.
        if (userId == null) return Unauthorized();

        // Get the current order that matches the id parameter.
        var order = await _context.Orders.FirstOrDefaultAsync(m => m.Id == id);

        // Check if the order exists.
        if (order == null) return NotFound("Order does not exist.");

        // Return unauthorized if the current logged in user is not the creator of the order being viewed.
        if (order.MaxicyclesUserId != userId) return Unauthorized();

        // Populate the Order model with details from the order in the database.
        Order = order;

        // Convert the UTC from the database to Local time for display.
        Order.OrderDate = Order.OrderDate.ToLocalTime();
        Order.ShippedDate = Order.ShippedDate?.ToLocalTime();
        Order.TargetDeliveryDate = Order.TargetDeliveryDate.ToLocalTime();

        return Page();
    }
}