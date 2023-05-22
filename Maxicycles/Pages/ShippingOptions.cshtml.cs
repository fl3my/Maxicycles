using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;

namespace Maxicycles.Pages
{
    public class ShippingOptionsModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public ShippingOptionsModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        public IList<DeliveryMethod> DeliveryMethod { get;set; } = default!;

        public async Task OnGetAsync()
        {
            DeliveryMethod = await _context.DeliveryMethods.ToListAsync();
        }
    }
}
