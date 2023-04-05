using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;

namespace Maxicycles.Pages.Admin.Store.SubCategories
{
    public class IndexModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public IndexModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        public IList<SubCategory> SubCategory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            SubCategory = await _context.SubCategory
                .Include(s => s.Category).ToListAsync();
        }
    }
}
