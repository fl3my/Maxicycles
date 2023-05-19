using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maxicycles.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Checkout
{
    public class CancelOrderModel : PageModel
    {
        private readonly MaxicyclesDbContext _context;

        public CancelOrderModel(MaxicyclesDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGet(int? orderId)
        {
            if (orderId == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(orderId);

            if (order == null)
            {
                return NotFound("Order does not exist");
            }
            
            // Remove the basket item from the database.
            _context.Orders.Remove(order);

            // Save changes to the database.
            await _context.SaveChangesAsync();

            return Page();
        }
    }
}
