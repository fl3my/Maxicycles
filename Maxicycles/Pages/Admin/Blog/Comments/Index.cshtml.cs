using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Blog.Comments;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public IndexModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public IList<Comment> Comment { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // Populate the comment list with all comments from the database.
        Comment = await _context.Comment
            .Include(c => c.MaxicyclesUser)
            .Include(c => c.Post).ToListAsync();

        // Foreach comment in the list change the UTC date to local time.
        foreach (var comment in Comment) comment.UploadedAt = comment.UploadedAt.ToLocalTime();
    }
}