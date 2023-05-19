using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripe.FinancialConnections;

namespace Maxicycles.Pages.Checkout
{
    public class CancelOrderModel : PageModel
    {
        private readonly MaxicyclesDbContext _context;
        private readonly UserManager<MaxicyclesUser> _userManager;

        public CancelOrderModel(MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGet(int? orderId)
        {
            // Return not found if the orderId does not exist.
            if (orderId == null)
            {
                return NotFound();
            }
            
            // Get the current order.
            var order = await _context.Orders.FindAsync(orderId);
            
            // Return not found if the order dos not exist.
            if (order == null)
            {
                return NotFound("Order does not exist");
            }
            
            // Get the current logged in user.
            var userId = _userManager.GetUserId(User);

            // Check that the userId is not null.
            if (userId == null)
            {
                return Unauthorized();
            }
            
            // Check that the order belongs to the user.
            if (order.MaxicyclesUserId != userId)
            {
                return Unauthorized();
            }

            // Check that the order was made in the last 5 minutes. 
            if ((DateTime.UtcNow - order.OrderDate).TotalMinutes > 5)
            {
                return NotFound();
            }
            
            // Remove the basket item from the database.
            _context.Orders.Remove(order);

            // Save changes to the database.
            await _context.SaveChangesAsync();

            return Page();
        }
    }
}
