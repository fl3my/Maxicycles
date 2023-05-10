using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maxicycles.Data;
using Maxicycles.Models;

namespace Maxicycles.Pages.Admin.Services
{
    public class IndexModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;

        public IndexModel(Maxicycles.Data.MaxicyclesDbContext context)
        {
            _context = context;
        }

        public IList<ServiceModel> Service { get; set; } = default!;

        public class ServiceModel
        {
            public int Id { get; set; }
            public string? Title { get; set; }
            
            [DataType(DataType.Date)]
            public DateTime ServiceDate { get; set; }
            public string? Email { get; set; }
            public string? PhoneNumber { get; set; }
        }

        public async Task OnGetAsync()
        {
            var orderServices = await _context.OrderServices
                .Include(o => o.Order)
                .ThenInclude(u => u!.MaxicyclesUser)
                .ToListAsync();

           Service = new List<ServiceModel>();
            
            foreach (var orderService in orderServices)
            {
                Service.Add(new ServiceModel
                {
                    Id = orderService.Id,
                    Title = orderService.Title,
                    ServiceDate = orderService.ServiceDate.ToLocalTime(),
                    Email = orderService.Order?.MaxicyclesUser.Email,
                    PhoneNumber = orderService.Order?.MaxicyclesUser.PhoneNumber
                });
            }

            Service = Service.OrderBy(s => s.ServiceDate).ToList();
        }
    }
}
