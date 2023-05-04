using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Store.DeliveryMethods
{
    public class DeleteModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public DeleteModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.DeliveryMethods == null)
            {
                return NotFound();
            }
            var delivery = await _context.DeliveryMethods.FindAsync(id);

            if (delivery != null)
            {
                DeliveryMethod = delivery;
                _context.DeliveryMethods.Remove(DeliveryMethod);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
