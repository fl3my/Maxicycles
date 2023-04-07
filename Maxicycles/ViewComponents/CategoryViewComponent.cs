using Maxicycles.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.ViewComponents;

[ViewComponent(Name = "Category")]
public class CategoryViewComponent : ViewComponent
{
    private readonly MaxicyclesDbContext _context;

    public CategoryViewComponent(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var categories = await _context.Category.Include(c => c.SubCategories).ToListAsync();
        return View(categories);
    }
}