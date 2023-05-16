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
    public class DeleteModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public DeleteModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Category Category { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            // Check if the id is not null.
            if (id == null)
            {
                return NotFound();
            }

            // Get the category from the database.
            var category = await _context.Category.FirstOrDefaultAsync(m => m.Id == id);

            // If the category is not null.
            if (category == null)
            {
                return NotFound("Category does not exist.");
            }

            // Populate the category model with details from the database.
            Category = category;
            
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            // Check if the id is not null.
            if (id == null)
            {
                return NotFound();
            }
            
            // Get the category that matches the id from the parameter.
            var category = await _context.Category.FindAsync(id);

            // Redirect to index if the category is null.
            if (category == null) return RedirectToPage("./Index");
            
            Category = category;
            
            // Remove the Category from the database.
            _context.Category.Remove(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
