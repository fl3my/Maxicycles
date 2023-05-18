using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.MyServices;

public class DetailsModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DetailsModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public OrderItem OrderItem { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // if the ID is not null.
        if (id == null) return NotFound();

        // Get the order item that matches the ID from the parameter.
        var orderItem = await _context.OrderItems.FirstOrDefaultAsync(m => m.Id == id);

        // If the product is not found in the database.
        if (orderItem == null) return NotFound();

        // Populate the model with order information from the database.
        OrderItem = orderItem;

        return Page();
    }
}