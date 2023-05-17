using Maxicycles.Data;
using Maxicycles.Enums;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.MyOrders;

public class CancelModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly UserManager<MaxicyclesDbContext> _userManager;

    public CancelModel(MaxicyclesDbContext context, UserManager<MaxicyclesDbContext> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [BindProperty] public Order Order { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check that the id is not null.
        if (id == null) return NotFound();

        // Get the order that matches the parameter id.
        var order = await _context.Orders.FirstOrDefaultAsync(m => m.Id == id);

        // Check if the order exists.
        if (order == null) return NotFound("Order does not exist.");

        // Populate the Order model with details from the order.
        Order = order;

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Check that the is not null.
        if (id == null) return NotFound();

        // Get the current logged in user id.
        var userId = _userManager.GetUserId(User);

        // Return unauthorized if a user is not logged in.
        if (userId == null) return Unauthorized();

        // Get the order that matches the parameter id.
        var order = await _context.Orders.FindAsync(id);

        // Redirect to index if the order does not exist.
        if (order == null) return RedirectToPage("./Index");

        // Return unauthorized if the current logged in user is not the creator of the order being viewed.
        if (order.MaxicyclesUserId != userId) return Unauthorized();

        // Populate the order model with order data from the database.
        Order = order;

        // Change the order status to represent cancellation.
        Order.OrderStatus = OrderStatus.CancellationRequested;

        // Track changes.
        _context.Attach(Order).State = EntityState.Modified;

        // Update order in the database.
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}