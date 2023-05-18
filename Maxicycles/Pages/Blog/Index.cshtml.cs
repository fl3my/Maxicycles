using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;

namespace Maxicycles.Pages.Blog
{
    public class IndexModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public IndexModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        public IList<IndexPostModel> Post { get;set; } = default!;
        
        public class IndexPostModel
        {
            public int Id { get; set; }
            public string? Title { get; set; }
            public string? Excerpt { get; set; }
            public string? AuthorFulLName { get; set; }
            public string? UploadedAt { get; set; }
            public string? AltText { get; set; }
            public string? ImageName { get; set; }
        }
        public async Task OnGetAsync()
        {
            var posts = await _context.Post
                .Include(p => p.Image)
                .Include(p => p.MaxicyclesUser)
                .ToListAsync();

            Post = new List<IndexPostModel>();
            
            foreach (var post in posts)
            {
                Post.Add( new IndexPostModel()
                {
                    Id = post.Id,
                    Title = post.Title,
                    Excerpt = post.Excerpt,
                    AuthorFulLName = post.MaxicyclesUser?.FirstName + " " + post.MaxicyclesUser?.LastName,
                    UploadedAt = post.UploadedAt.ToLocalTime().ToShortDateString(),
                    AltText = post.Image?.AltText,
                    ImageName = post.Image?.ImageName,
                });
            }
        }
    }
}
