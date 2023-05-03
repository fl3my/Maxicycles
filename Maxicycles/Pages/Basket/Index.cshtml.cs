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
    public class IndexModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public IndexModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        public IList<BasketItem> BasketItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.BasketItem != null)
            {
                BasketItem = await _context.BasketItem
                .Include(b => b.Item)
                .Include(b => b.MaxicyclesUser).ToListAsync();
            }
        }
    }
}
