using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    [BindProperty(SupportsGet = true)]
    public int? ParentCategoryId { get; set; }
    
    public async Task OnGetAsync()
    {
        ViewData["ParentCategoryId"] = new SelectList(_context.Category, "Id", "Title");
        
        // Populate the subcategory list model with subcategories from the database.
        SubCategory = await _context.SubCategory
            .Include(s => s.Category).ToListAsync();

        if (ParentCategoryId != null)
        {
            SubCategory = SubCategory.Where(c => c.CategoryId == ParentCategoryId).ToList();
        }
    }
}