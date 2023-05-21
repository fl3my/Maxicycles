using Maxicycles.Data;
using Maxicycles.Models;
using Maxicycles.Validators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Images;

public class CreateModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly IWebHostEnvironment _environment;

    public CreateModel(MaxicyclesDbContext context, IWebHostEnvironment environment)
    {
        _context = context;
        _environment = environment;
    }

    [BindProperty] public Image Image { get; set; } = default!;

    [BindProperty]
    [AllowedExtensions(new[] {"jpeg", "png", "jpg"})]
    [MaxFileSize(2 * 1024 * 1024)]
    public IFormFile? ImageFile { get; set; }

    public IActionResult OnGet()
    {
        return Page();
    }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if the input passes the model validation.
        if (!ModelState.IsValid) return Page();

        // if the user has uploaded an Image.
        if (ImageFile != null)
        {
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

        // Add the image upload time.
        Image.UploadedAt = DateTime.UtcNow;

        // Add the image to the database.
        _context.Images.Add(Image);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}