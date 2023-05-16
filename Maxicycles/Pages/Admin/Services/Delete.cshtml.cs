using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Services;

public class DeleteModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DeleteModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public OrderItem OrderItem { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // If there is an ID passed.
        if (id == null) return NotFound();

        // Get the order item with the matching ID.
        var orderItem = await _context.OrderItems.FirstOrDefaultAsync(m => m.Id == id);

        // If no order Item is returned, It does not exist.
        if (orderItem == null) return NotFound();

        // Populate the model with order item from the database.
        OrderItem = orderItem;

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // If the ID is not null.
        if (id == null) return NotFound();

        // Get the order item from the database.
        var orderItem = await _context.OrderItems.FindAsync(id);

        // Redirect if the id does not match a valid product.
        if (orderItem == null) return RedirectToPage("./Index");

        OrderItem = orderItem;

        // Remove the order Item.
        _context.OrderItems.Remove(OrderItem);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}