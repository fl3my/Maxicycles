using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Basket;

public class AddServiceModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public AddServiceModel(MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [BindProperty] public BasketService BasketService { get; set; } = default!;

    public IActionResult OnGet(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the service from the id parameter.
        var service = _context.Service.FirstOrDefault(i => i.Id == id);

        // If the service does not exist.
        if (service == null) return NotFound("Service does not exist.");

        // Create a basket service model with a default service date of today and details of the current service.
        BasketService = new BasketService
        {
            Item = service,
            ServiceDate = DateTime.Today
        };

        return Page();
    }


    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Check that the id is not null.
        if (id == null) return NotFound();

        // Get the service from the id parameter.
        var service = _context.Service.FirstOrDefault(i => i.Id == id);

        // Return not found if the service does not exist.
        if (service == null) return NotFound("Service does not exist.");

        // Get the current userId for the logged in user.
        var userId = _userManager.GetUserId(User);

        // Return unauthorized if the user is not logged in.
        if (userId == null) return Unauthorized();

        // Check if the user already has the current product in their basket.
        var alreadyInBasket = _context.BasketItem
            .Where(b => b.MaxicyclesUserId == userId)
            .Any(b => b.ItemId == service.Id);

        // Add a model error to the model if alreadyInBasket is true.
        if (alreadyInBasket) ModelState.AddModelError("", "Already in basket");

        // Count the amount of services booked on the selected day.
        var totalBooked =
            _context.OrderServices.Count(o => o.ServiceDate.Date == BasketService.ServiceDate.ToUniversalTime().Date);

        // Check if total booked is over the daily limit.
        if (totalBooked >= service.DailyMaxServices)
            ModelState.AddModelError("BasketService.ServiceDate", "Sorry, We are fully booked on this date");

        // Add a quantity of 1 as a service can only have a single quantity.
        BasketService.Quantity = 1;
        BasketService.Item = service;
        BasketService.MaxicyclesUserId = userId;

        // If validation fails.
        if (!ModelState.IsValid) return Page();

        // Convert the local datetime to UTC for postgres database.
        BasketService.ServiceDate = BasketService.ServiceDate.ToUniversalTime();

        // Add the basketService to the basketItem table.
        _context.BasketService.Add(BasketService);

        // Save changes to the database.
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}