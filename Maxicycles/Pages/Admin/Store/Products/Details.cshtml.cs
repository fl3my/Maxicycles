using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Products;

public class DetailsModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DetailsModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public Product Product { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check that the id is not null.
        if (id == null) return NotFound();

        // Get the product that matches the parameter id from the database.
        var product = await _context
            .Product
            .Include(p => p.SubCategory)
            .Include(p => p.Image)
            .FirstOrDefaultAsync(m => m.Id == id);

        // Check if the product exists.
        if (product == null) return NotFound("Product does not exist.");

        // Populate the product model with product data from the database.
        Product = product;

        return Page();
    }
}