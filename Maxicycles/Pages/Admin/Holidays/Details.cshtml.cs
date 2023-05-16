using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Holidays;

public class DetailsModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DetailsModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public Holiday Holiday { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the holiday matching the id from the database.
        var holiday = await _context.Holiday.FirstOrDefaultAsync(m => m.Id == id);

        // Check if holiday is not null.
        if (holiday == null) return NotFound();

        // Populate the holiday model.
        Holiday = holiday;

        // Convert the times from UTC to Local time.
        Holiday.Start = Holiday.Start.ToLocalTime();
        Holiday.End = Holiday.Start.ToLocalTime();

        return Page();
    }
}