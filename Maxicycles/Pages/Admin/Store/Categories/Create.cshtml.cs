using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Maxicycles.Data;
using Maxicycles.Models;

namespace Maxicycles.Pages.Admin.Store.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public CreateModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
          {
              return Page();
          }

          _context.Category.Add(Category);
          await _context.SaveChangesAsync();

          return RedirectToPage("./Index");
        }
    }
}
