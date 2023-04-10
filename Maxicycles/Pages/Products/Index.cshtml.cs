using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;

namespace Maxicycles.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public IndexModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public async Task OnGetAsync()
        {
            // Get all sub categories.
            var subCategories = from c in _context.SubCategory select c;
            
            // Select all products.
            var products = from p in _context.Product select p;
            
            // If there is a valid search string, search.
            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.Title!.Contains(SearchString));
            }

            Product = await products
                .Include(p => p.Image)
                .Include(p => p.SubCategory).ToListAsync();
        }
    }
}
