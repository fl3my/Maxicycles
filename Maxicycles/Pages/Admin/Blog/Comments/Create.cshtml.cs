using System.ComponentModel.DataAnnotations;
using Maxicycles.Data;
using Maxicycles.Models;
using Maxicycles.Validators;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Maxicycles.Pages.Admin.Blog.Comments;

public class CreateModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public CreateModel(MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [BindProperty] public CommentCreateModel CommentCreate { get; set; } = default!;

    public IActionResult OnGet()
    {
        // Populate a list of all post ids.
        ViewData["PostId"] = new SelectList(_context.Posts, "Id", "Id");
        return Page();
    }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        // Get the current logged in user.
        var userId = _userManager.GetUserId(User);

        // If no user return unauthorized.
        if (userId == null) return Unauthorized();

        // Check if form input passes validation.
        if (!ModelState.IsValid) return Page();

        // Populate a new comment object.
        var comment = new Comment
        {
            Content = CommentCreate.Content,
            PostId = CommentCreate.PostId,
            UploadedAt = DateTime.UtcNow,
            MaxicyclesUserId = userId
        };

        // Save the comment to the database.
        _context.Comments.Add(comment);

        await _context.SaveChangesAsync();

        // Return to the index page.s
        return RedirectToPage("./Index");
    }

    public class CommentCreateModel
    {
        [DataType(DataType.MultilineText)]
        [Required]
        public string? Content { get; set; }

        [Required] public int PostId { get; set; }
    }
}