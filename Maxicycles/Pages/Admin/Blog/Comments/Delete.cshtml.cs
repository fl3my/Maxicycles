using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Blog.Comments;

public class DeleteModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DeleteModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public Comment Comment { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the comment that matches the id.
        var comment = await _context.Comment.Include(c => c.MaxicyclesUser).FirstOrDefaultAsync(m => m.Id == id);

        if (comment == null) return NotFound();

        // Populate comment model.
        Comment = comment;

        // Convert the UTC time to Local time.
        Comment.UploadedAt = Comment.UploadedAt.ToLocalTime();

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the comment that matches the id.
        var comment = await _context.Comment.FindAsync(id);

        // If the comment is null redirect to index.
        if (comment == null) return RedirectToPage("./Index");

        Comment = comment;

        // Remove the comment from the database.
        _context.Comment.Remove(Comment);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}