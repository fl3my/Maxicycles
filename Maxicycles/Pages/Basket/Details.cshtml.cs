using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;

namespace Maxicycles.Pages.Basket
{
    public class DetailsModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public DetailsModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

      public BasketItem BasketItem { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BasketItem == null)
            {
                return NotFound();
            }

            var basketitem = await _context.BasketItem.FirstOrDefaultAsync(m => m.Id == id);
            if (basketitem == null)
            {
                return NotFound();
            }
            else 
            {
                BasketItem = basketitem;
            }
            return Page();
        }
    }
}
