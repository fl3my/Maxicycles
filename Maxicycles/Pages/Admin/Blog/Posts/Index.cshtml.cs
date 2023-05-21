using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Blog.Posts;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public IndexModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public IList<Post> Post { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // Get a list of all posts from the database.
        Post = await _context.Posts
            .Include(p => p.MaxicyclesUser).ToListAsync();

        // For each post convert the uploaded at time to local time for display.
        foreach (var post in Post) post.UploadedAt = post.UploadedAt.ToLocalTime();
    }
}