using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Items;

public class DetailsModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DetailsModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public Item Item { get; set; } = default!;

    public int Quantity { get; set; } = default!;


    public async Task<IActionResult> OnGetAsync(string slug)
    {
        // Check if the slug string is null or empty.
        if (string.IsNullOrEmpty(slug)) return NotFound();

        // Find the first item in the database that matches the slug parameter.
        var item = await _context
            .Item
            .Include(m => m.Image)
            .Include(c => c.SubCategory)
            .FirstOrDefaultAsync(m => m.Slug == slug);

        // If the item does not exist.
        if (item == null) return NotFound("Item does not exist.");

        // Populate the Item model with item details from the database.
        Item = item;

        return Page();
    }
}