using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Maxicycles.Pages.Admin.Store.SubCategories;

public class CreateModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public CreateModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public SubCategory SubCategory { get; set; } = default!;

    public IActionResult OnGet()
    {
        // Populate the category dropdown with master categories.
        ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title");
        
        return Page();
    }


    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if form passes the validation.
        if (!ModelState.IsValid)
        {
            // Populate the category dropdown with master categories.
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Title");

            return Page();
        }

        // Add the subcategory to the database.
        _context.SubCategories.Add(SubCategory);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}