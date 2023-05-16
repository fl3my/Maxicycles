using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Store.SubCategories;

public class DeleteModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DeleteModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public SubCategory SubCategory { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the subcategory that matches the parameter id.
        var subcategory = await _context.SubCategory.FindAsync(id);

        // If the subcategory does not exist.
        if (subcategory == null) return NotFound("Subcategory does not exist.");

        // Populate model with subcategory details from the database.
        SubCategory = subcategory;

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the subcategory from the database that matches the parameter id.
        var subcategory = await _context.SubCategory.FindAsync(id);

        // Redirect to index if subcategory is null.
        if (subcategory == null) return RedirectToPage("./Index");

        SubCategory = subcategory;

        // Remove the subcategory from the database.
        _context.SubCategory.Remove(SubCategory);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}