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
using Microsoft.AspNetCore.Identity;

namespace Maxicycles.Pages.Basket
{
    public class IndexModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;
        private readonly UserManager<MaxicyclesUser> _userManager;

        public IndexModel(Maxicycles.Data.MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<BasketItemModel> BasketItemModels { get;set; } = default!;
        
        public class BasketItemModel
        {
            public int Id { get; set; }
            public string? Title { get; set; }
            public int Quantity { get; set; }
            [DataType(DataType.Date)]
            public DateTime? ServiceDate { get; set; }
            public decimal ItemPrice { get; set; }
            public decimal TotalPrice { get; set; }
        }
        
        public async Task OnGetAsync()
        {
            // Get the current userId.
            var userId = _userManager.GetUserId(User);
            
            // Get the basket items for the current user.
            var basketItems = await _context.BasketItem
                .Where(b => b.MaxicyclesUserId == userId)
                .Include(b => b.Item)
                .Include(b => b.MaxicyclesUser)
                .ToListAsync();
            
            // Create a list of view models.
            BasketItemModels = new List<BasketItemModel>();
            
            // Populate the model.
            foreach (var item in basketItems)
            {
                var basketItemModel = new BasketItemModel()
                {
                    Id = item.Id,
                    Title = item.Item?.Title,
                    Quantity = item.Quantity,
                    ItemPrice = item.Item.Price,
                    TotalPrice = item.Quantity * item.Item.Price,
                };
                
                // If the model is a service add the serviceDate.
                if (item is BasketService service)
                {
                    basketItemModel.ServiceDate = service.ServiceDate;
                }
                
                BasketItemModels.Add(basketItemModel);
            }
        }
    }
}
