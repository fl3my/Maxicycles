using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Basket;

public class DeleteModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DeleteModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public BasketItem BasketItem { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the basket item from the ID parameter.
        var basketItem = await _context.BasketItem.Include(b => b.Item).FirstOrDefaultAsync(m => m.Id == id);

        // Check if the basket item exists.
        if (basketItem == null) return NotFound("BasketItem does not exist.");

        // Populate the BasketItem model with basket item data from the database.
        BasketItem = basketItem;

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the basket item from the id parameter.
        var basketItem = await _context.BasketItem.FindAsync(id);

        // If the basket item does not exist redirect to index.
        if (basketItem == null) return RedirectToPage("./Index");

        BasketItem = basketItem;

        // Remove the basket item from the database.
        _context.BasketItem.Remove(BasketItem);

        // Save changes to the database.
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}