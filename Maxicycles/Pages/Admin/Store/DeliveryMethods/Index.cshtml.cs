using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.DeliveryMethods
{
    public class IndexModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public IndexModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        public IList<DeliveryMethod> Delivery { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Delivery = await _context.DeliveryMethods.ToListAsync();
        }
    }
}
