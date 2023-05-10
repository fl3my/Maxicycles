using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Enums;
using Maxicycles.Models;

namespace Maxicycles.Pages.MyOrders
{
    public class CancelModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public CancelModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Order Order { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FirstOrDefaultAsync(m => m.Id == id);

            if (order == null)
            {
                return NotFound();
            }
            else 
            {
                Order = order;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = await _context.Orders.FindAsync(id);

            if (order == null) return RedirectToPage("./Index");
            
            Order = order;

            Order.OrderStatus = OrderStatus.CancellationRequested;
            
            _context.Attach(Order).State = EntityState.Modified;
            
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
