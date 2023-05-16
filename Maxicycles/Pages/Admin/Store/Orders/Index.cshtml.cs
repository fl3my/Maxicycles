using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Orders;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public IndexModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public IList<Order> Order { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // Get all orders from the database and populate a List of order models.
        Order = await _context.Orders
            .Include(o => o.DeliveryMethod)
            .Include(o => o.MaxicyclesUser)
            .OrderBy(o => o.OrderDate)
            .ToListAsync();

        // Convert all UTC time zone to system local time zone.
        foreach (var order in Order)
        {
            order.OrderDate = order.OrderDate.ToLocalTime();
            order.ShippedDate = order.ShippedDate?.ToLocalTime();
            order.RequiredDate = order.RequiredDate.ToLocalTime();
        }
    }
}