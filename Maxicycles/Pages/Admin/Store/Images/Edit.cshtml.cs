using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Images;

public class EditModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly IWebHostEnvironment _environment;

    public EditModel(MaxicyclesDbContext context, IWebHostEnvironment environment)
    {
        _context = context;
        _environment = environment;
    }

    [BindProperty] public Image Image { get; set; } = default!;

    [BindProperty] public IFormFile? ImageFile { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the image from the database that matches the parameter id.
        var image = await _context.Image.FirstOrDefaultAsync(m => m.Id == id);

        // Check if the image is not null.
        if (image == null) return NotFound("Image does not exist.");

        // Populate the Image model with the data from image in the database.
        Image = image;

        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        // Check that the form input passes the validation.
        if (!ModelState.IsValid) return Page();

        // If the user has selected a new image.
        if (ImageFile != null)
        {
            // Delete the previous image from wwwroot folder.
            if (Image.ImageName != null)
            {
                var imagePath = Path.Combine(_environment.WebRootPath, "images", Image.ImageName);

                if (System.IO.File.Exists(imagePath)) System.IO.File.Delete(imagePath);
            }

            // Get the filename and extension.
            var fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
            var extension = Path.GetExtension(ImageFile.FileName);

            // Create unique name for the image.
            Image.ImageName = fileName + "_" + Guid.NewGuid() + extension;

            var path = Path.Combine(_environment.WebRootPath + "/uploads/" + Image.ImageName);

            // Write the file to the image directory.
            await using var fileStream = new FileStream(path, FileMode.Create);
            await ImageFile.CopyToAsync(fileStream);
        }

        // Update the image upload time.
        Image.UploadedAt = DateTime.Now.ToUniversalTime();

        // Track changes.
        _context.Attach(Image).State = EntityState.Modified;

        // Save changes to the database.
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ImageExists(Image.Id)) return NotFound();

            throw;
        }

        return RedirectToPage("./Index");
    }

    // Function that checks if an image exists in the database.
    private bool ImageExists(int id)
    {
        return (_context.Image?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}