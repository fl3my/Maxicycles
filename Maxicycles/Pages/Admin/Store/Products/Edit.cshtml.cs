using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Products;

public class EditModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public EditModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public Product Product { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check that the id is not null.
        if (id == null) return NotFound();

        // Get the product from the database that matches the parameter id.
        var product = await _context.Product.FindAsync(id);

        // If the product does not exist.
        if (product == null) return NotFound("Product does not exist.");

        // Populate the product model with product data from the database.
        Product = product;

        // Pass a new select list with subcategory data.
        ViewData["SubcategoryId"] = new SelectList(_context.SubCategory, "Id", "Title");

        // Pass a new select list with image data.
        ViewData["ImageId"] = new SelectList(_context.Image, "Id", "Title");

        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if the input form passes validation.
        if (!ModelState.IsValid)
        {
            // Pass a new select list with subcategory data.
            ViewData["SubcategoryId"] = new SelectList(_context.SubCategory, "Id", "Title");

            // Pass a new select list with image data.
            ViewData["ImageId"] = new SelectList(_context.Image, "Id", "Title");
            
            return Page();
        }

        // Track changes.
        _context.Attach(Product).State = EntityState.Modified;

        // Save changes to the database.
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ProductExists(Product.Id)) return NotFound();
            throw;
        }

        return RedirectToPage("./Index");
    }

    // Function to check if the product exists in the database.
    private bool ProductExists(int id)
    {
        return (_context.Product?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}