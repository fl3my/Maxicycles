using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.SubCategories;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public IndexModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public IList<SubCategory> SubCategory { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // Populate the subcategory list model with subcategories from the database.
        SubCategory = await _context.SubCategory
            .Include(s => s.Category).ToListAsync();
    }
}