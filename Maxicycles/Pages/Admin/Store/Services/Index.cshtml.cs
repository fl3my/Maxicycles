using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Services;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public IndexModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public IList<Service> Service { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // Put all services into the list from the database.
        Service = await _context.Services
            .Include(p => p.SubCategory)
            .Include(p => p.Image)
            .ToListAsync();
    }
}