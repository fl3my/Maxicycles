using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Npgsql.PostgresTypes;

namespace Maxicycles.Pages.Blog
{
    public class DetailsModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;
        private readonly UserManager<MaxicyclesUser> _userManager;

        public DetailsModel(Maxicycles.Data.MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty] public PostDetailsModel Post { get; set; } = default!;

        [BindProperty] public CommentCreateModel CommentCreate { get; set; } = default!;

        public class CommentCreateModel
        {
            public string? Content { get; set; }
        }

        public class PostDetailsModel
        {
            public int Id { get; set; }
            public string? Title { get; set; }
            public string? Content { get; set; }
            public string? UploadedAt { get; set; }
            public string? AuthorFullName { get; set; }
            public IList<CommentModel>? Comments { get; set; }
        }

        public class CommentModel
        {
            public int Id { get; set; }
            public string? Content { get; set; }
            public string? AuthorFullName { get; set; }
            public string? UploadedAt { get; set; }
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Post
                .Include(p => p.MaxicyclesUser)
                .Include(c => c.Comments)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (post == null)
            {
                return NotFound();
            }
            else
            {
                // Fill the post model.
                Post = new PostDetailsModel
                {
                    Id = post.Id,
                    Title = post.Title,
                    Content = post.Content,
                    AuthorFullName = post.MaxicyclesUser?.FirstName + " " + post.MaxicyclesUser?.LastName,
                    UploadedAt = post.UploadedAt.ToLocalTime().ToLongDateString(),
                    Comments = new List<CommentModel>()
                };

                // Fill the comment model.
                foreach (var comment in post.Comments)
                {
                    Post.Comments.Add(new CommentModel
                    {
                        Id = comment.Id,
                        Content = comment.Content,
                        AuthorFullName = comment.MaxicyclesUser?.FirstName + " " + comment.MaxicyclesUser?.LastName,
                        UploadedAt = post.UploadedAt.ToLocalTime().ToShortDateString()
                    });
                }

            }

            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var userId = _userManager.GetUserId(User);

            if (userId == null)
            {
                return Unauthorized();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var comment = new Comment
            {
                Content = CommentCreate.Content,
                PostId = Post.Id,
                UploadedAt = DateTime.UtcNow,
                MaxicyclesUserId = userId
            };

            _context.Comment.Add(comment);

            await _context.SaveChangesAsync();

            // Redirect to the same page to refresh the comments.
            return RedirectToPage("./Details", new { id = Post.Id });
        }
    }
}

