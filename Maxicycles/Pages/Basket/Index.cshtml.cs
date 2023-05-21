using System.ComponentModel.DataAnnotations;
using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Basket;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public IndexModel(MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public IList<BasketItemModel> BasketItemModels { get; set; } = default!;
    public decimal OverallTotal { get; set; }
    
    public async Task OnGetAsync()
    {
        // Get the current userId.
        var userId = _userManager.GetUserId(User);

        // Get the basket items for the current user.
        var basketItems = await _context.BasketItems
            .Where(b => b.MaxicyclesUserId == userId)
            .Include(b => b.MaxicyclesUser)
            .Include(b => b.Item)
            .ToListAsync();

        // Create a list of view models.
        BasketItemModels = new List<BasketItemModel>();

        // Populate the model.
        foreach (var item in basketItems)
        {
            var basketItemModel = new BasketItemModel
            {
                Id = item.Id,
                Title = item.Item?.Title,
                Quantity = item.Quantity,
                ItemPrice = item.Item!.Price,
                Item = item,
                TotalPrice = item.Quantity * item.Item.Price
            };
            
            OverallTotal += basketItemModel.TotalPrice;
            
            // If the model is a service add the serviceDate.
            if (item is BasketService service) basketItemModel.ServiceDate = service.ServiceDate.ToLocalTime();

            // Add the model to the list model.
            BasketItemModels.Add(basketItemModel);
        }
    }

    public class BasketItemModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Quantity { get; set; }

        [DataType(DataType.Date)] [Display(Name = "Date of Service")] public DateTime? ServiceDate { get; set; }

        [Display(Name = "Each")]
        public decimal ItemPrice { get; set; }
        
        [Display(Name = "Total")]
        public decimal TotalPrice { get; set; }
        public BasketItem? Item { get; set; }
    }
}