using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.DeliveryMethods;

public class DeleteModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DeleteModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public DeliveryMethod DeliveryMethod { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the delivery method that matches the parameter id.
        var delivery = await _context.DeliveryMethods.FirstOrDefaultAsync(m => m.Id == id);

        // If the delivery does not exist in the database.
        if (delivery == null) return NotFound("Delivery does not exist");

        // Populate the DeliveryMethod model with data from the database.
        DeliveryMethod = delivery;

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the delivery details form the database that matches the id.
        var delivery = await _context.DeliveryMethods.FindAsync(id);

        // Return to index if the delivery does not exist.
        if (delivery == null) return RedirectToPage("./Index");

        DeliveryMethod = delivery;

        // Remove the deliveryMethod from the database.
        _context.DeliveryMethods.Remove(DeliveryMethod);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}