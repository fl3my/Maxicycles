using System.ComponentModel.DataAnnotations;
using Maxicycles.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Blog.Posts;

public class EditModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public EditModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public EditPostModel EditPost { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if id is not null.
        if (id == null) return NotFound();

        // Get the post that matches the id.
        var post = await _context.Post.FindAsync(id);

        // Return not found is post does not exist.
        if (post == null) return NotFound("Post does not exist.");

        // Populate the image list with image names.
        ViewData["ImageId"] = new SelectList(_context.Image, "Id", "Title");
        
        // Populate the edit post model with details from the post.
        EditPost = new EditPostModel
        {
            Id = post.Id,
            Content = post.Content,
            Excerpt = post.Excerpt,
            Title = post.Title,
            ImageId = post.ImageId
        };

        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        // Check if the edit form matches validation.
        if (!ModelState.IsValid) return Page();

        // get he post from the database.
        var post = await _context.Post.FindAsync(EditPost.Id);

        // If post does not exist return not found.
        if (post == null) return NotFound("Post does not exist.");

        // Update the properties of the post.
        post.Content = EditPost.Content;
        post.Title = EditPost.Title;
        post.Excerpt = EditPost.Excerpt;
        post.ImageId = EditPost.ImageId;
        
        post.UploadedAt = DateTime.UtcNow;

        // Track changes.
        _context.Attach(post).State = EntityState.Modified;

        // Try and save the changes to the database.
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PostExists(EditPost.Id)) return NotFound();

            throw;
        }

        return RedirectToPage("./Index");
    }

    // Function that checks if a post exists in the database.
    private bool PostExists(int id)
    {
        return (_context.Post?.Any(e => e.Id == id)).GetValueOrDefault();
    }

    public class EditPostModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string? Title { get; set; }
        
        [Required]
        [MinLength(20)]
        [MaxLength(200)]
        public string? Excerpt { get; set; }
        
        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(10)]
        [MaxLength(2000)]
        public string? Content { get; set; }
        
        public int? ImageId { get; set; }
    }
}