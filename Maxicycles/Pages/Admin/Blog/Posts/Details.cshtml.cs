using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Blog.Posts;

public class DetailsModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DetailsModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public Post Post { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // if the Id does not exist.
        if (id == null) return NotFound();

        // Get the post with matching Id.
        var post = await _context.Posts.Include(p => p.MaxicyclesUser).FirstOrDefaultAsync(m => m.Id == id);

        // Check if post is not null.
        if (post == null) return NotFound();

        Post = post;

        // Convert the time from UTC to local time.
        Post.UploadedAt = Post.UploadedAt.ToLocalTime();

        return Page();
    }
}