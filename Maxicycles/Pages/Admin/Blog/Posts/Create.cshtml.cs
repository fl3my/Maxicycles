using System.ComponentModel.DataAnnotations;
using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Maxicycles.Pages.Admin.Blog.Posts;

public class CreateModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public CreateModel(MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [BindProperty] public PostCreateModel Post { get; set; } = default!;

    public IActionResult OnGet()
    {
        // Populate the image list with image names.
        ViewData["ImageId"] = new SelectList(_context.Image, "Id", "Title");
        return Page();
    }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        // Get the current logged in user.
        var userId = _userManager.GetUserId(User);

        // If the user does not exist, return unauthorized.
        if (userId == null) return Unauthorized();

        // Return with validation errors if does not meet criteria.
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Populate a new post object.
        var post = new Post
        {
            Title = Post.Title,
            Content = Post.Content,
            Excerpt = Post.Excerpt,
            ImageId = Post.ImageId,
            UploadedAt = DateTime.UtcNow,
            MaxicyclesUserId = userId
        };

        _context.Post.Add(post);

        // Add the post to the database.
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }

    public class PostCreateModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string? Title { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(2000)]
        [DataType(DataType.MultilineText)]
        public string? Content { get; set; }
        
        [Required]
        [MinLength(20)]
        [MaxLength(200)]
        public string? Excerpt { get; set; }

        public int? ImageId { get; set; }
    }
}