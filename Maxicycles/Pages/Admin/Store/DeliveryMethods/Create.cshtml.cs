using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Store.DeliveryMethods;

public class CreateModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public CreateModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public DeliveryMethod DeliveryMethod { get; set; } = default!;

    public IActionResult OnGet()
    {
        return Page();
    }


    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if the form input passes the input validation.
        if (!ModelState.IsValid) return Page();

        // Add the delivery method to the database.
        _context.DeliveryMethods.Add(DeliveryMethod);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}