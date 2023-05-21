using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Services;

public class DeleteModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DeleteModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public Service Service { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the service detail that matches the id from the database.
        var service = await _context
            .Services
            .Include(p => p.SubCategory)
            .Include(p => p.Image)
            .FirstOrDefaultAsync(m => m.Id == id);

        // Check if the service does not exist.
        if (service == null) return NotFound();

        // Populate the Service model with product details from the database.
        Service = service;

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Check that the id is not null.
        if (id == null) return NotFound();

        // Get the service from the database that matches the parameter id.
        var service = await _context.Services.FindAsync(id);

        // If the service does not exist, go to the index.
        if (service == null) return RedirectToPage("./Index");

        Service = service;

        // Remove the service from the database.
        _context.Services.Remove(Service);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}