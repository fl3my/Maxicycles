using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Services;

public class EditModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public EditModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public OrderService OrderService { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // If the id is not null.
        if (id == null) return NotFound();

        // Get the order Service from the database matching the id.
        var orderService = await _context.OrderServices.FirstOrDefaultAsync(m => m.Id == id);

        // If it does not exist in the database.
        if (orderService == null) return NotFound("Order does not exist.");

        // Change the service date from UTC to Local time.
        orderService.ServiceDate = orderService.ServiceDate.ToLocalTime();

        // Populate the model with order service details.
        OrderService = orderService;

        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        // Get the order Service that matches the ID.
        var orderService = await _context.OrderServices.FirstOrDefaultAsync(m => m.Id == OrderService.Id);

        // If the orderService does not exist.
        if (orderService == null) return NotFound();

        // Change the Local time from the date picker into UTC for storage in the database.
        var newServiceDate = OrderService.ServiceDate.ToUniversalTime();

        // Update details of the order service.
        OrderService = orderService;
        OrderService.ServiceDate = newServiceDate;

        // If validation is not valid return with error messages.
        if (!ModelState.IsValid) return Page();

        // Track changes.
        _context.Attach(OrderService).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!OrderItemExists(OrderService.Id)) return NotFound();
            throw;
        }

        return RedirectToPage("./Index");
    }

    // Function that checks if the order exists in the database.
    private bool OrderItemExists(int id)
    {
        return (_context.OrderItems?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}