using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.DeliveryMethods;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public IndexModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public IList<DeliveryMethod> Delivery { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // Populate the list model with the delivery methods from the database.
        Delivery = await _context.DeliveryMethods.ToListAsync();
    }
}