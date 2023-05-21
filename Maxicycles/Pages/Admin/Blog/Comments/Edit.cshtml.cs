using Maxicycles.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Blog.Comments;

public class EditModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public EditModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    [BindProperty] public EditCommentModel EditComment { get; set; } = default!;

    [BindProperty] public string? UserEmail { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the comment that matches the id.
        var comment = await _context.Comments.Include(c => c.MaxicyclesUser).FirstOrDefaultAsync(m => m.Id == id);

        // Return not found if the comment does not exist.
        if (comment == null) return NotFound("Comment does not exist.");

        //Populate the editCommentModel with details from the database.
        EditComment = new EditCommentModel
        {
            Id = comment.Id,
            Content = comment.Content
        };

        // Get the users email.
        UserEmail = comment.MaxicyclesUser?.Email;

        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        // Get the comment by id.
        var comment = await _context.Comments.FindAsync(EditComment.Id);

        if (comment == null) return NotFound();

        // Check if the model passes the validation.
        if (!ModelState.IsValid) return Page();

        // Populate the content field with the new content.
        comment.Content = EditComment.Content;

        // Track changes.
        _context.Attach(comment).State = EntityState.Modified;

        // Save changes to the database.
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!CommentExists(EditComment.Id)) return NotFound();
            throw;
        }

        return RedirectToPage("./Index");
    }

    // Check if the comment exists in the database.
    private bool CommentExists(int id)
    {
        return (_context.Comments?.Any(e => e.Id == id)).GetValueOrDefault();
    }

    public class EditCommentModel
    {
        public int Id { get; set; }
        public string? Content { get; set; }
    }
}