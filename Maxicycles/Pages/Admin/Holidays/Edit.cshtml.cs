using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Data.Migrations;
using Maxicycles.Models;

namespace Maxicycles.Pages.Admin.Holidays
{
    public class EditModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public EditModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Holiday Holiday { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var holiday =  await _context.Holiday.FirstOrDefaultAsync(m => m.Id == id);
            
            if (holiday == null)
            {
                return NotFound();
            }
            Holiday = holiday;
            
            Holiday.Start = Holiday.Start.ToLocalTime();
            Holiday.End = Holiday.End.ToLocalTime();
            
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            Holiday.Start = Holiday.Start.ToUniversalTime();
            Holiday.End = Holiday.End.ToUniversalTime();
            
            _context.Attach(Holiday).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HolidayExists(Holiday.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HolidayExists(int id)
        {
          return (_context.Holiday?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
