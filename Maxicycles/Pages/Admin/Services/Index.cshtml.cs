using System.ComponentModel.DataAnnotations;
using Maxicycles.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Admin.Services;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;

    public IndexModel(MaxicyclesDbContext context)
    {
        _context = context;
    }

    public IList<ServiceIndexModel> Service { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // Get all the orderServices from the database.
        var orderServices = await _context.OrderServices
            .Include(o => o.Order)
            .ThenInclude(u => u!.MaxicyclesUser)
            .ToListAsync();

        // Create a new list object to hold data about the services.
        Service = new List<ServiceIndexModel>();

        // Iterate over all individual services in the list.
        foreach (var orderService in orderServices)
            // Add a service to the model.
            Service.Add(new ServiceIndexModel
            {
                Id = orderService.Id,
                Title = orderService.Title,
                ServiceDate = orderService.ServiceDate.ToLocalTime(),
                Email = orderService.Order?.MaxicyclesUser.Email,
                PhoneNumber = orderService.Order?.MaxicyclesUser.PhoneNumber
            });

        // Order the services in ascending order.
        Service = Service.OrderBy(s => s.ServiceDate).ToList();
    }

    public class ServiceIndexModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)] public DateTime ServiceDate { get; set; }

        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}