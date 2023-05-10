using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Maxicycles.Data;
using Maxicycles.Enums;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Checkout
{
    public class CardPaymentModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;
        private readonly UserManager<MaxicyclesUser> _userManager;

        public CardPaymentModel(Maxicycles.Data.MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet(int orderId)
        {
            var userId = _userManager.GetUserId(User);

            if (userId == null)
            {
                return Unauthorized();
            }
            
            // Get the users order.
            var order = _context.Orders.Where(o => o.MaxicyclesUserId == userId).FirstOrDefault(o => o.Id == orderId);

            if (order == null)
            {
                return NotFound();
            }
            
            // Get the total price.
            TotalPrice = order.TotalPrice;
            
            return Page();
        }

        [BindProperty]
        public decimal TotalPrice { get; set; }

        [BindProperty]
        public CardInputModel CardInput { get; set; } = default!;

        public class CardInputModel
        {
            public string? Name { get; set; }
            public string? LongNumber { get; set; }
            public DateTime ExpiryDate { get; set; }
            public string? AddressLine1 { get; set; }
            public string? AddressLine2 { get; set; }
            public string? City { get; set; }
            public string? Postcode { get; set; }
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(int orderId)
        {
            var userId = _userManager.GetUserId(User);

            if (userId == null)
            {
                return Unauthorized();
            }
            
            // Get the users order.
            var order = _context.Orders.Where(o => o.MaxicyclesUserId == userId).FirstOrDefault(o => o.Id == orderId);

            if (order == null)
            {
                return NotFound();
            }
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            CardInput.ExpiryDate = CardInput.ExpiryDate.ToUniversalTime();
            
            var card = new Card
            {
                Name = CardInput.Name,
                LongNumber = CardInput.LongNumber,
                ExpiryDate = CardInput.ExpiryDate,
                AddressLine1 = CardInput.AddressLine1,
                AddressLine2 = CardInput.AddressLine2,
                City = CardInput.City,
                Postcode = CardInput.Postcode,
                Order = order,
                IsPaid = true
            };

            // Change the status to awaiting shipment as payment has been made.
            order.OrderStatus = OrderStatus.AwaitingShipment;
            
            _context.Attach(order).State = EntityState.Modified;

            
            _context.Cards.Add(card);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Confirmation");
        }
    }
}
