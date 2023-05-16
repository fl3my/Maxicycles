using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Store.SubCategories;

public class DetailsModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DetailsModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public SubCategory SubCategory { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the subcategory that matches the id.
        var subcategory = await _context.SubCategory.FindAsync(id);

        // If the subcategory does not exist return not found.
        if (subcategory == null) return NotFound("Subcategory does not exist.");

        // Populate the subcategory model with subcategory details from the database.
        SubCategory = subcategory;

        return Page();
    }
}