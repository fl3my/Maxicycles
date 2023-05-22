using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Blog;

public class DeleteModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public DeleteModel(MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [BindProperty] public Comment Comment { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the comment that matches the id.
        var comment = await _context.Comments.Include(c => c.MaxicyclesUser).FirstOrDefaultAsync(m => m.Id == id);

        if (comment == null) return NotFound();

        var userId = _userManager.GetUserId(User);

        // If user is not the owner of the comment return unauthorized.
        if (userId != comment.MaxicyclesUserId)
        {
            return Unauthorized();
        }
        
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
        var comment = await _context.Comments.FindAsync(id);

        // If the comment is null redirect to index.
        if (comment == null) return RedirectToPage("./Index");

        Comment = comment;

        // Remove the comment from the database.
        _context.Comments.Remove(Comment);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}