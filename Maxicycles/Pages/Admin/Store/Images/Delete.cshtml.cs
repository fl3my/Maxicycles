using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Images
{
    public class DeleteModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;
        private IWebHostEnvironment _environment;
        
        public DeleteModel(Maxicycles.Data.MaxicyclesDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [BindProperty]
      public Image Image { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Image.FirstOrDefaultAsync(m => m.Id == id);

            if (image == null)
            {
                return NotFound();
            }
            else 
            {
                Image = image;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var image = await _context.Image.FindAsync(id);
            
            if (image != null)
            {
                Image = image;

                if (Image.ImageName != null)
                {
                    // Delete the image from wwwroot folder.
                    var imagePath = Path.Combine(_environment.WebRootPath, "images", Image.ImageName);

                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete((imagePath));
                    }
                }
                
                _context.Image.Remove(Image);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
