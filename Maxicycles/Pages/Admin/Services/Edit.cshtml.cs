using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;

namespace Maxicycles.Pages.Admin.Services
{
    public class EditModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public EditModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrderService OrderService { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderService =  await _context.OrderServices.FirstOrDefaultAsync(m => m.Id == id);
            
            if (orderService == null)
            {
                return NotFound();
            }

            orderService.ServiceDate = orderService.ServiceDate.ToLocalTime();
            
            OrderService = orderService;

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var orderService =  await _context.OrderServices.FirstOrDefaultAsync(m => m.Id == OrderService.Id);
            
            if (orderService == null)
            {
                return NotFound();
            }
            
            var newServiceDate = OrderService.ServiceDate.ToUniversalTime();
            
            OrderService = orderService;
            OrderService.ServiceDate = newServiceDate;
            
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _context.Attach(OrderService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderItemExists(OrderService.Id))
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

        private bool OrderItemExists(int id)
        {
          return (_context.OrderItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
