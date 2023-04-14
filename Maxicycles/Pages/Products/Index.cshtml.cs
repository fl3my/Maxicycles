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

        public IList<Item> Items { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Category { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string? SubCategory { get; set; }
        
        public async Task OnGetAsync()
        {
            // Select all products.
            var products = from p in _context.Item select p;
            
            // If there is a valid search string, search.
            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.Title!.Contains(SearchString));
            }
            
            // If there is a category
            if (!string.IsNullOrEmpty(Category))
            {   
                // Get all items in that category
                products = products.Where(s => s.SubCategory!.Category!.Slug == Category);
                
                // If there is 
                if (!string.IsNullOrEmpty(SubCategory))
                {
                    products = products.Where(s => s.SubCategory!.Slug == SubCategory);
                }
            }
            
            Items = await products
                .Include(p => p.Image)
                .Include(p => p.SubCategory).ToListAsync();
        }
    }
}
