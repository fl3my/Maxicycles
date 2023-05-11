using System.ComponentModel.DataAnnotations;
using Maxicycles.Data;
using Maxicycles.Models;
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

    [BindProperty] public CommentCreateModel Comment { get; set; } = default!;

    public IActionResult OnGet()
    {
        ViewData["PostId"] = new SelectList(_context.Post, "Id", "Id");
        return Page();
    }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        var userId = _userManager.GetUserId(User);

        if (userId == null) return Unauthorized();

        if (!ModelState.IsValid) return Page();

        var comment = new Comment
        {
            Content = Comment.Content,
            PostId = Comment.PostId,
            UploadedAt = DateTime.UtcNow,
            MaxicyclesUserId = userId
        };

        _context.Comment.Add(comment);

        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }

    public class CommentCreateModel
    {
        [Required] public string? Content { get; set; }

        [Required] public int PostId { get; set; }
    }
}