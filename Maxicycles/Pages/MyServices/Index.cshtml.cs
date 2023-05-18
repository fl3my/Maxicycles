using System.ComponentModel.DataAnnotations;
using Maxicycles.Data;
using Maxicycles.Enums;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.NET.StringTools;

namespace Maxicycles.Pages.MyServices;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public IndexModel(MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public IList<ServiceIndexModel> Service { get; set; } = default!;

    [BindProperty(SupportsGet = true)]
    public BookingStatus BookingStatus { get; set; }
    
    public async Task OnGetAsync()
    {
        // Find the id for the current logged in user.
        var userId = _userManager.GetUserId(User);
        
        // Get all the orderServices from the database.
        var orderServices = await _context.OrderServices
            .Include(o => o.Order)
            .ThenInclude(o => o!.MaxicyclesUser)
            .Where(o => o.Order!.MaxicyclesUserId == userId)
            .ToListAsync();
        
        if (BookingStatus == Enums.BookingStatus.Upcoming)
        {
            orderServices = orderServices.Where(o => o.ServiceDate > DateTime.UtcNow).ToList();
        }
        else if(BookingStatus == Enums.BookingStatus.Completed)
        {
            orderServices = orderServices.Where(o => o.ServiceDate < DateTime.UtcNow).ToList();
        }

        
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
            });
        
        // Order the services in ascending order.
        Service = Service.OrderBy(s => s.ServiceDate).ToList();
    }

    public class ServiceIndexModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)] public DateTime ServiceDate { get; set; }

    }
}