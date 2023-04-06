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

namespace Maxicycles.Pages.Admin.Images
{
    public class CreateModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;
        private readonly IWebHostEnvironment _environment;
        
        public CreateModel(Maxicycles.Data.MaxicyclesDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Image Image { get; set; } = default!;

        [BindProperty]
        public IFormFile? ImageFile { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
          {
              return Page();
          }

          if (ImageFile != null)
          {
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
          
          _context.Image.Add(Image);
          await _context.SaveChangesAsync();

          return RedirectToPage("./Index");
        }
    }
}
