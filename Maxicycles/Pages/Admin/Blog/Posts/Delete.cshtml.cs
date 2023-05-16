using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Blog.Posts;

public class DeleteModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public DeleteModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public Post Post { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the post that matches the Id from the parameter.
        var post = await _context.Post.Include(p => p.MaxicyclesUser).FirstOrDefaultAsync(m => m.Id == id);

        // If the post does not exist return not found.
        if (post == null) return NotFound("Post does not exist.");

        // Populate post model.
        Post = post;

        // Convert the UTC time to local time.
        Post.UploadedAt = Post.UploadedAt.ToLocalTime();

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the post with matching id from the database.
        var post = await _context.Post.FindAsync(id);

        // Return Not found if post does not exist.
        if (post == null) return NotFound("Post does not exist.");

        Post = post;

        // Remove the post from the database.
        _context.Post.Remove(Post);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}