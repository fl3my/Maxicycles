using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;

namespace Maxicycles.Pages.Admin.Blog.Posts
{
    public class CreateModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;
        private readonly UserManager<MaxicyclesUser> _userManager;

        public CreateModel(Maxicycles.Data.MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PostCreateModel Post { get; set; } = default!;

        public class PostCreateModel
        {
            [Required]
            public string? Title { get; set; }
            [Required]
            public string? Content { get; set; }
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

            var post = new Post
            {
                Title = Post.Title,
                Content = Post.Content,
                UploadedAt = DateTime.UtcNow,
                MaxicyclesUserId = userId
                
            };
            _context.Post.Add(post);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
