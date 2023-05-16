using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Store.Orders;

public class DeleteModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DeleteModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public Order Order { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check that the id is not null.
        if (id == null) return NotFound();

        // Get the order from the database that matches the parameter id.
        var order = await _context.Orders.FindAsync(id);

        // Return not found if the order does not exist.
        if (order == null) return NotFound();

        // Populate the order model with data from the database.
        Order = order;

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Check that the id is not null.
        if (id == null) return NotFound();

        // Get the order from the database that matches the parameter id.
        var order = await _context.Orders.FindAsync(id);

        // If the order is null return to index.
        if (order == null) return RedirectToPage("./Index");

        Order = order;

        // Remove the order from the database.
        _context.Orders.Remove(Order);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}