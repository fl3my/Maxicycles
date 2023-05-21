using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Holidays;

public class EditModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public EditModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public Holiday Holiday { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the holiday from the database that matches the id.
        var holiday = await _context.Holidays.FirstOrDefaultAsync(m => m.Id == id);

        // Return not found if the holiday does not exist.
        if (holiday == null) return NotFound("Holiday does not exist.");

        // populate the holiday model.
        Holiday = holiday;

        // Convert the holiday times to local time from UTC.
        Holiday.Start = Holiday.Start.ToLocalTime();
        Holiday.End = Holiday.End.ToLocalTime();

        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if the holiday start date is before the holiday end date.
        if (Holiday.Start > Holiday.End)
            ModelState.AddModelError("Holiday.Start", "Start cannot be greater than end date");

        // Check that Validation is met.
        if (!ModelState.IsValid) return Page();

        // Convert from local time to UTC time for storage in the database.
        Holiday.Start = Holiday.Start.ToUniversalTime();
        Holiday.End = Holiday.End.ToUniversalTime();

        // Track changes.
        _context.Attach(Holiday).State = EntityState.Modified;

        // Save changes to the database.
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!HolidayExists(Holiday.Id)) return NotFound();

            throw;
        }

        return RedirectToPage("./Index");
    }

    // Function to check if holiday exists in teh database.
    private bool HolidayExists(int id)
    {
        return (_context.Holidays?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}