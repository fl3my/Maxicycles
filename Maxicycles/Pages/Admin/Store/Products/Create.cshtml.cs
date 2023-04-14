using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.Build.Framework;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Maxicycles.Pages.Admin.Store.Products
{
    public class CreateModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;
        private IWebHostEnvironment _environment;
        
        public CreateModel(Maxicycles.Data.MaxicyclesDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            ViewData["SubcategoryId"] = new SelectList(_context.SubCategory, "Id", "Title");
            ViewData["ImageId"] = new SelectList(_context.Image, "Id", "Title");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
          {
              return Page();
          }

          _context.Product.Add(Product);
          await _context.SaveChangesAsync();

          return RedirectToPage("./Index");
        }
    }
}
