using System.ComponentModel.DataAnnotations;
using Maxicycles.Data;
using Maxicycles.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Orders;

public class EditModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public EditModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public OrderEditModel OrderEdit { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check that the id is not null.
        if (id == null) return NotFound();

        // Get the order that matches the parameter id.
        var order = await _context.Orders.FindAsync(id);

        // Check if the order exists.
        if (order == null) return NotFound("Order does not exist.");

        // Populate the OrderEdit model with data from the order from the database.
        OrderEdit = new OrderEditModel
        {
            Id = order.Id,
            RequiredDate = order.TargetDeliveryDate.ToLocalTime(),
            ShippedDate = order.ShippedDate?.ToLocalTime(),
            OrderStatus = order.OrderStatus
        };

        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        // Get the order from the database that matches the id.
        var order = await _context.Orders.FindAsync(OrderEdit.Id);

        // Check if the order exists.
        if (order == null) return NotFound("Order does not exist");

        // Check that the input form passes the validation.
        if (!ModelState.IsValid) return Page();

        // Convert the local time from the input to UTC time for storage in the database.
        order.OrderStatus = OrderEdit.OrderStatus;
        order.TargetDeliveryDate = OrderEdit.RequiredDate.ToUniversalTime();
        order.ShippedDate = OrderEdit.ShippedDate?.ToUniversalTime();

        // Track changes.
        _context.Attach(order).State = EntityState.Modified;

        // Save changes to database.
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!OrderExists(order.Id)) return NotFound();
            throw;
        }

        return RedirectToPage("./Index");
    }

    // Function that checks if an order exists in a database.
    private bool OrderExists(int id)
    {
        return (_context.Orders?.Any(e => e.Id == id)).GetValueOrDefault();
    }

    public class OrderEditModel
    {
        [Required] public int Id { get; set; }

        [Required] [DataType(DataType.Date)] public DateTime RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        [Required] public OrderStatus OrderStatus { get; set; }
    }
}