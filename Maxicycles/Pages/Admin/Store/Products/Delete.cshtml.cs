using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Products;

public class DeleteModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DeleteModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public Product Product { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the product detail that matches the id from the database.
        var product = await _context
            .Product
            .Include(p => p.SubCategory)
            .Include(p => p.Image)
            .FirstOrDefaultAsync(m => m.Id == id);

        // Check if the product does not exist.
        if (product == null) return NotFound();

        // Populate the Product model with product details from the database.
        Product = product;

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Check that the id is not null.
        if (id == null) return NotFound();

        // Get the product from the database that matches the parameter id.
        var product = await _context.Product.FindAsync(id);

        // If the product does not exist, go to the index.
        if (product == null) return RedirectToPage("./Index");

        Product = product;

        // Remove the product from the database.
        _context.Product.Remove(Product);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}