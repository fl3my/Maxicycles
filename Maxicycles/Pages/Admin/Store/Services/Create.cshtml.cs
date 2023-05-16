using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Maxicycles.Pages.Admin.Store.Services;

public class CreateModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private IWebHostEnvironment _environment;

    public CreateModel(MaxicyclesDbContext context, IWebHostEnvironment environment)
    {
        _context = context;
        _environment = environment;
    }

    [BindProperty] public Service Service { get; set; } = default!;

    public IActionResult OnGet()
    {
        // Pass a new select list with subcategory data.
        ViewData["SubcategoryId"] = new SelectList(_context.SubCategory, "Id", "Title");

        // Pass a new select list with image data.
        ViewData["ImageId"] = new SelectList(_context.Image, "Id", "Title");

        return Page();
    }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if input form passes the validation.
        if (!ModelState.IsValid) return Page();

        // Add the product to the database.
        _context.Service.Add(Service);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}