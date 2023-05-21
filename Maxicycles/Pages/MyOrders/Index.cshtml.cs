using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.MyOrders;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public IndexModel(MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public IList<Order> Order { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // Find the id for the current logged in user.
        var userId = _userManager.GetUserId(User);

        // Populate a list of order models with order details from the database that the user has made.
        Order = await _context.Orders
            .Where(b => b.MaxicyclesUserId == userId)
            .Include(o => o.DeliveryMethod)
            .Include(o => o.MaxicyclesUser).ToListAsync();

        // Convert UTC to local time.
        foreach (var order in Order)
        {
            order.OrderDate = order.OrderDate.ToLocalTime();
            order.TargetDeliveryDate = order.TargetDeliveryDate.ToLocalTime();
            order.ShippedDate = order.ShippedDate?.ToLocalTime();
        }
    }
}