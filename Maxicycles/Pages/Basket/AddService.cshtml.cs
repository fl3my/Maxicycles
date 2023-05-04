using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Basket
{
    public class AddServiceModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;
        private readonly UserManager<MaxicyclesUser> _userManager;

        public AddServiceModel(Maxicycles.Data.MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet(int id)
        {
            var service = _context.Service.FirstOrDefault(i => i.Id == id);

            if (service == null)
            {
                return NotFound();
            }

            BasketService = new BasketService()
            {
                Item = service
            };
            
            return Page();
        }

        [BindProperty]
        public BasketService BasketService { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(int id)
        { 
            // Get the service from the id.
            var service = _context.Service.FirstOrDefault(i => i.Id == id);
          
          if (service == null)
          {
              return NotFound();
          }
          
          // Get the current userId.
          var userId = _userManager.GetUserId(User);
            
          if (userId == null)
          {
              return Unauthorized();
          }

          // Add a quantity of 1 as a service can only have a single quantity.
          BasketService.Quantity = 1;

          BasketService.Item = service;
          BasketService.MaxicyclesUserId = userId;

          // If validation fails.
          if (!ModelState.IsValid)
          {
              BasketService.Item = service;
              return Page();
          }

          // Convert the local datetime to UTC for postgres database.
          BasketService.ServiceDate = BasketService.ServiceDate?.ToUniversalTime();

          // Add the basketService to the basketItem table.
          _context.BasketService.Add(BasketService);
          await _context.SaveChangesAsync();

          return RedirectToPage("./Index");
        }
    }
}
