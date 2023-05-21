using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Holidays;

public class DeleteModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DeleteModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public Holiday Holiday { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the holiday that matches the id.
        var holiday = await _context.Holidays.FirstOrDefaultAsync(m => m.Id == id);

        if (holiday == null) return NotFound();

        // Populate the model with details from the database.
        Holiday = holiday;

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound("Holiday does not exist");

        // Find the holiday in the database.
        var holiday = await _context.Holidays.FindAsync(id);

        // Return to index if the holiday does not exist.
        if (holiday == null) return RedirectToPage("./Index");

        Holiday = holiday;

        // Remove the holiday from the database.
        _context.Holidays.Remove(Holiday);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}