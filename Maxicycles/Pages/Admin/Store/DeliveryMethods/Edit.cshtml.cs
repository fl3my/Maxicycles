using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.DeliveryMethods;

public class EditModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public EditModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public DeliveryMethod DeliveryMethod { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the delivery that matches the id from the parameter.
        var delivery = await _context.DeliveryMethods.FirstOrDefaultAsync(m => m.Id == id);

        // if the delivery does not exist return.
        if (delivery == null) return NotFound("Delivery does not exist.");

        // Populate the deliveryMethod model with data from the database.
        DeliveryMethod = delivery;

        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if the form validation passes.
        if (!ModelState.IsValid) return Page();

        // Track changes.
        _context.Attach(DeliveryMethod).State = EntityState.Modified;

        // Save changes to the database.
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DeliveryExists(DeliveryMethod.Id))
                return NotFound();
            throw;
        }

        return RedirectToPage("./Index");
    }

    // Function that checks if the delivery exists in the database.
    private bool DeliveryExists(int id)
    {
        return (_context.DeliveryMethods?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}