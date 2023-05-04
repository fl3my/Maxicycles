using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.DeliveryMethods
{
    public class DetailsModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public DetailsModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

      public DeliveryMethod DeliveryMethod { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delivery = await _context.DeliveryMethods.FirstOrDefaultAsync(m => m.Id == id);
            if (delivery == null)
            {
                return NotFound();
            }
            else 
            {
                DeliveryMethod = delivery;
            }
            return Page();
        }
    }
}
