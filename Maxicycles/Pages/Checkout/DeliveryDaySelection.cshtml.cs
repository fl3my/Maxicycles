using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Maxicycles.Data;
using Maxicycles.Models;
using Maxicycles.Validators;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Checkout
{
    public class DeliveryDaySelectionModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;
        private readonly UserManager<MaxicyclesUser> _userManager;

        public DeliveryDaySelectionModel(Maxicycles.Data.MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGet(int orderId)
        {
            // Get the confirmed order.
            var order = await _context.Orders
                .Include(o => o.DeliveryMethod)
                .FirstOrDefaultAsync(o => o.Id == orderId);

            if (order == null) return NotFound();

            // Get the current logged in user.
            var user = await _userManager.GetUserAsync(User);

            if (user == null) return NotFound();

            // Check if the current order belongs to the user.
            if (order.MaxicyclesUser.Id != user.Id) return Unauthorized();
            
            // Check if the delivery method is null.
            if (order.DeliveryMethod == null)
            {
                return Unauthorized();
            }
            
            // Check if the delivery method chosen is any day.
            if (!order.DeliveryMethod.IsDaySelectable)
            {
                return Unauthorized();
            }

            RequiredDate = order.RequiredDate;
            DeliveryMethodTitle = order.DeliveryMethod.Title;
            
            return Page();
        }

        [BindProperty]
        [DataType(DataType.Date)]
        [WithinFourteenDays]
        [NotOnHoliday]
        public DateTime RequiredDate { get; set; }
        [BindProperty] public string? DeliveryMethodTitle { get; set; }
        
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(int? orderId)
        {
            // Check if order id is not null.
            if (orderId == null)
            {
                return NotFound();
            }
            
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Get the confirmed order.
            var order = await _context.Orders
                .Include(o => o.DeliveryMethod)
                .FirstOrDefaultAsync(o => o.Id == orderId);

            // Return not found if the object cannot be found.
            if (order == null)
            {
                return NotFound("Order does not exist");
            }

            // Change the required date to the date specified by the user.
            order.RequiredDate = RequiredDate.ToUniversalTime();
            
            // Update the data in the table.
            _context.Attach(order).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            // Otherwise, Go to the order confirmation page.
            return RedirectToPage("./OrderConfirmation", new { orderId = order.Id });
        }
    }
}
