using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Maxicycles.Pages.Admin.Store.Products;

public class CreateModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public CreateModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public Product Product { get; set; } = default!;

    public IActionResult OnGet()
    {

        // Pass a new select list with subcategory data.
        ViewData["SubcategoryId"] = new SelectList(_context.SubCategories, "Id", "Title");

        // Pass a new select list with image data.
        ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Title");
        return Page();
    }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if input form passes the validation.
        if (!ModelState.IsValid)
        {
            // Pass a new select list with subcategory data.
            ViewData["SubcategoryId"] = new SelectList(_context.SubCategories, "Id", "Title");

            // Pass a new select list with image data.
            ViewData["ImageId"] = new SelectList(_context.Images, "Id", "Title");
            
            return Page();
        }
        
        // Add the product to the database.
        _context.Products.Add(Product);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}