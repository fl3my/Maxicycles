using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.SubCategories;

public class EditModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public EditModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public SubCategory SubCategory { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the subcategory that matches the id parameter.
        var subcategory = await _context.SubCategory.FindAsync(id);

        // Return not found if the subcategory does not exist.
        if (subcategory == null) return NotFound("Subcategory does not exist.");

        // Populate the subcategory model with details from the database.
        SubCategory = subcategory;

        // Add the category details toa new select list input.
        ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Title");

        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if form input passes the validation.
        if (!ModelState.IsValid) return Page();

        // Track changes.
        _context.Attach(SubCategory).State = EntityState.Modified;

        // Save changes to the database.
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!SubCategoryExists(SubCategory.Id)) return NotFound();

            throw;
        }

        return RedirectToPage("./Index");
    }

    // Function that checks if the subcategory exists in the database.
    private bool SubCategoryExists(int id)
    {
        return (_context.SubCategory?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}