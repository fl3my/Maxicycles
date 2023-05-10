using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;

namespace Maxicycles.Pages.MyOrders
{
    public class IndexModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;
        private readonly UserManager<MaxicyclesUser> _userManager;

        public IndexModel(Maxicycles.Data.MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            var userId = _userManager.GetUserId(User);

            Order = await _context.Orders
                .Where(b => b.MaxicyclesUserId == userId)
                .Include(o => o.DeliveryMethod)
                .Include(o => o.MaxicyclesUser).ToListAsync();
        }
    }
}
