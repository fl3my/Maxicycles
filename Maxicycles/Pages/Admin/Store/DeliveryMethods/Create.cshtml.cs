using Maxicycles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Admin.Store.DeliveryMethods
{
    public class CreateModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public CreateModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DeliveryMethod DeliveryMethod { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
          {
              return Page();
          }

          _context.DeliveryMethods.Add(DeliveryMethod);
          await _context.SaveChangesAsync();

          return RedirectToPage("./Index");
        }
    }
}
