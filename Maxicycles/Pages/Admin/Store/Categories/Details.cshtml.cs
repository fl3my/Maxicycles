using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;

namespace Maxicycles.Pages.Admin.Store.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public DetailsModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

      public Category Category { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            // Check if the id is not null.
            if (id == null)
            {
                return NotFound();
            }

            // Get the category from the database that matches the id from the parameter.
            var category = await _context.Categories.FirstOrDefaultAsync(m => m.Id == id);
            
            // If the category does not exist.
            if (category == null)
            {
                return NotFound("Category does not exist.");
            }

            Category = category;
            
            return Page();
        }
    }
}
