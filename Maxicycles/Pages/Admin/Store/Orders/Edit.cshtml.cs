using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Enums;
using Maxicycles.Models;

namespace Maxicycles.Pages.Admin.Store.Orders
{
    public class EditModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public EditModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrderEditModel OrderEdit { get; set; } = default!;

        public class OrderEditModel
        {
            [Required]
            public int Id { get; set; }
            [Required]
            [DataType(DataType.Date)]
            public DateTime RequiredDate { get; set; }
            public DateTime? ShippedDate { get; set; }
            [Required]
            public OrderStatus OrderStatus { get; set; }
        }
        
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order =  await _context.Orders.FirstOrDefaultAsync(m => m.Id == id);
            
            if (order == null)
            {
                return NotFound();
            }
            OrderEdit = new OrderEditModel()
            {
                Id = order.Id,
                RequiredDate = order.RequiredDate.ToLocalTime(),
                ShippedDate = order.ShippedDate?.ToLocalTime(),
                OrderStatus = order.OrderStatus,
            };
       
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var order = await _context.Orders.FindAsync(OrderEdit.Id);

            if (order == null)
            {
                return NotFound();
            }
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            order.OrderStatus = OrderEdit.OrderStatus;
            order.RequiredDate = OrderEdit.RequiredDate.ToUniversalTime();
            order.ShippedDate = OrderEdit.ShippedDate?.ToUniversalTime();
            
            _context.Attach(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(order.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OrderExists(int id)
        {
          return (_context.Orders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
