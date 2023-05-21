using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Images;

public class DeleteModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private IWebHostEnvironment _environment;

    public DeleteModel(MaxicyclesDbContext context, IWebHostEnvironment environment)
    {
        _context = context;
        _environment = environment;
    }

    [BindProperty] public Image Image { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the image that matches the id from the database.
        var image = await _context.Images.FirstOrDefaultAsync(m => m.Id == id);

        // Return not found if the image does not exist.
        if (image == null) return NotFound("Image does not exist.");

        // Populate the image model with data from the database.
        Image = image;

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Return not found if id is null.
        if (id == null) return NotFound();

        // Get the image that matches the id from the database.
        var image = await _context.Images.FindAsync(id);

        // If image does not exist redirect to index.
        if (image == null) return RedirectToPage("./Index");

        Image = image;

        // If the image path Name is not null.
        if (Image.ImageName != null)
        {
            // Delete the image from wwwroot folder.
            var imagePath = Path.Combine(_environment.WebRootPath, "images", Image.ImageName);

            // Use the system to delete file from wwwroot.
            if (System.IO.File.Exists(imagePath)) System.IO.File.Delete(imagePath);
        }

        // Remove image from the database.
        _context.Images.Remove(Image);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}