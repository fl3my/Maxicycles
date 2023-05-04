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

namespace Maxicycles.Pages.Basket
{
    public class EditModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public EditModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BasketItem BasketItem { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basketitem =  await _context.BasketItem.FirstOrDefaultAsync(m => m.Id == id);
            
            if (basketitem == null)
            {
                return NotFound();
            }
            
            BasketItem = basketitem;
           ViewData["ItemId"] = new SelectList(_context.Item, "Id", "Description");
           ViewData["MaxicyclesUserId"] = new SelectList(_context.MaxicyclesUsers, "Id", "Id");
           
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BasketItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BasketItemExists(BasketItem.Id))
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

        private bool BasketItemExists(int id)
        {
          return (_context.BasketItem?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
