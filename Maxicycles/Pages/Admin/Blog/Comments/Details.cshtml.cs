using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Blog.Comments;

public class DetailsModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DetailsModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public Comment Comment { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the comment that matches the id.
        var comment = await _context.Comments.Include(c => c.MaxicyclesUser).FirstOrDefaultAsync(m => m.Id == id);

        // Return not found if the comment is not found.
        if (comment == null) return NotFound("Comment does not exist.");

        Comment = comment;

        // Convert the UTC to local date time.
        Comment.UploadedAt = Comment.UploadedAt.ToLocalTime();

        return Page();
    }
}