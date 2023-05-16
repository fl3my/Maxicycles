using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Maxicycles.Pages.Admin.Services;

public class CreateModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public CreateModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public OrderItem OrderItem { get; set; } = default!;

    public IActionResult OnGet()
    {
        // Fill a select list with a list of all available orders.
        ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Id");
        return Page();
    }


    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if form input meets the validation criteria.
        if (!ModelState.IsValid) return Page();

        // Add the order item to the database.
        _context.OrderItems.Add(OrderItem);

        await _context.SaveChangesAsync();

        // Redirect to main view.
        return RedirectToPage("./Index");
    }
}