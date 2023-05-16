using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Images;

public class DetailsModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DetailsModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public Image Image { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if id is not null.
        if (id == null) return NotFound();

        // get the image that matches the id from the database.
        var image = await _context.Image.FirstOrDefaultAsync(m => m.Id == id);

        // Return not found if the image does not exist.
        if (image == null) return NotFound("Image does not exist.");

        // Populate the image from the database.
        Image = image;

        return Page();
    }
}