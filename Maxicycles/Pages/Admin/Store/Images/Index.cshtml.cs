using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.Images;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public IndexModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public IList<Image> Image { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // Populate the image List with images from the database.
        Image = await _context.Image.ToListAsync();
    }
}