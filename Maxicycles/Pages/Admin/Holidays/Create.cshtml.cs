using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Holidays;

public class CreateModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public CreateModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public Holiday Holiday { get; set; } = default!;

    public IActionResult OnGet()
    {
        return Page();
    }


    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if the holiday start date is before the holiday end date.
        if (Holiday.Start > Holiday.End)
            ModelState.AddModelError("Holiday.Start", "Start cannot be greater than end date");

        // Check if thee model passes the validation.
        if (!ModelState.IsValid) return Page();

        // Convert from Local time to UTC for storage in the database.
        Holiday.Start = Holiday.Start.ToUniversalTime();
        Holiday.End = Holiday.End.ToUniversalTime();

        // Add the holiday to the database.
        _context.Holiday.Add(Holiday);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}