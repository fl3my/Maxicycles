using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.DeliveryMethods;

public class DetailsModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DetailsModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public DeliveryMethod DeliveryMethod { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the delivery method from the database by id.
        var delivery = await _context.DeliveryMethods.FirstOrDefaultAsync(m => m.Id == id);

        // IF the delivery does not exist return.
        if (delivery == null) return NotFound("Delivery does not exist.");

        // Populate the delivery method object with the model from the database.
        DeliveryMethod = delivery;

        return Page();
    }
}