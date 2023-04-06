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

namespace Maxicycles.Pages.Admin.Images
{
    public class EditModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;
        private readonly IWebHostEnvironment _environment;
        
        public EditModel(Maxicycles.Data.MaxicyclesDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [BindProperty]
        public Image Image { get; set; } = default!;

        [BindProperty]
        public IFormFile? ImageFile { get; set; }
        
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image =  await _context.Image.FirstOrDefaultAsync(m => m.Id == id);
            
            if (image == null)
            {
                return NotFound();
            }
            
            Image = image;
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
            
            // If the user has selected a new image
            if (ImageFile != null)
            {
                // Delete the previous image from wwwroot folder.
                if (Image.ImageName != null)
                {
                    var imagePath = Path.Combine(_environment.WebRootPath, "images", Image.ImageName);

                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete((imagePath));
                    }
                }

                // Get the filename and extension.
                var fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                var extension = Path.GetExtension(ImageFile.FileName);

                // Create unique name for the image.
                Image.ImageName = fileName + "_" + Guid.NewGuid() + extension;

                var path = Path.Combine(_environment.WebRootPath + "/images/" + Image.ImageName);
            
                // Write the file to the image directory.
                await using var fileStream = new FileStream(path, FileMode.Create);
                await ImageFile.CopyToAsync(fileStream);
            }
            
            Image.UploadedAt = DateTime.Now.ToUniversalTime();
            
            _context.Attach(Image).State = EntityState.Modified;
            
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageExists(Image.Id))
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

        private bool ImageExists(int id)
        {
          return (_context.Image?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
