using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Services;

public class DetailsModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DetailsModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public Service Service { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check that the id is not null.
        if (id == null) return NotFound();

        // Get the service that matches the parameter id from the database.
        var service = await _context
            .Service
            .Include(p => p.SubCategory)
            .Include(p => p.Image)
            .FirstOrDefaultAsync(m => m.Id == id);

        // Check if the service exists.
        if (service == null) return NotFound("Service does not exist.");

        // Populate the service model with service data from the database.
        Service = service;

        return Page();
    }
}