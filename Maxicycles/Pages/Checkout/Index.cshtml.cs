using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Maxicycles.Data;
using Maxicycles.Enums;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Checkout
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
        
        public BasketIndexModel BasketModel { get; set; } = default!;
        
        public class BasketIndexModel
        {
            public IList<BasketItemModel> BasketItemModels { get; set; } = default!;
            public decimal TotalPrice { get; set; }
        }
        
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
        
        public async Task<IActionResult> OnGet()
        {
            // Get the current userId.
            var userId = _userManager.GetUserId(User);
            
            // Populate The Model.
            BasketModel = await PopulateBasketModel(userId);
            
            // Add delivery methods to the form.
            ViewData["DeliveryMethodId"] = new SelectList(_context.DeliveryMethods, "Id", "Id");
            
            return Page();
        }

        [BindProperty]
        public OrderInputModel OrderInput { get; set; } = default!;

        public class OrderInputModel
        {
            [Required]
            public DateTime RequiredDate { get; set; }
            [Required]
            public int DeliveryMethodId { get; set; }
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            // Get the current userId.
            var userId = _userManager.GetUserId(User);

            // Add delivery methods to the form.
            ViewData["DeliveryMethodId"] = new SelectList(_context.DeliveryMethods, "Id", "Id");
            
            // TODO - Add Validation
            
            if (!ModelState.IsValid)
            {
                // Populate the basketModel.
                BasketModel = await PopulateBasketModel(userId);
                
                return Page();
            }

            // Get the basket items for the current user.
            var basketItems = await _context.BasketItem
                .Where(b => b.MaxicyclesUserId == userId)
                .Include(b => b.Item)
                .Include(b => b.MaxicyclesUser)
                .ToListAsync();
            
            OrderInput.RequiredDate = OrderInput.RequiredDate.ToUniversalTime();
            
            // Create a new order object.
            var order = new Order
            {
                DeliveryMethodId = OrderInput.DeliveryMethodId,
                RequiredDate = OrderInput.RequiredDate,
                OrderDate = DateTime.Now.ToUniversalTime(),
                MaxicyclesUserId = userId,
                OrderStatus = OrderStatus.AwaitingPayment,
            };
            
            var orderItems = new List<OrderItem>();

            // Iterate through all items in the basket
            foreach (var item in basketItems)
            {
                // Cast the item into a there respective basket types.
                if (item is BasketProduct basketProduct)
                {
                    // Copy the contents of the  basket iten into a new order item.
                    orderItems.Add(new OrderProduct
                    {
                        Quantity = basketProduct.Quantity,
                        ItemPrice = basketProduct.Item.Price,
                        Title = basketProduct.Item.Title,
                    });

                    // Remove the basket quantity from the overall stock quantity.
                    if (basketProduct.Item is Product product)
                    {
                        product.Quantity -= basketProduct.Quantity;
                    }
                    
                } else if (item is BasketService basketService)
                {
                    orderItems.Add(new OrderService
                    {
                        Quantity = basketService.Quantity,
                        ItemPrice = basketService.Item.Price,
                        Title = basketService.Item.Title,
                        ServiceDate = basketService.ServiceDate,
                    });
                }
            }

            // Add the orderItems to the order object.
            order.OrderItems = orderItems;
            
            // Add the order to the database.
            _context.Orders.Add(order);
            
            // Remove all the items in the users basket.
            _context.BasketItem.RemoveRange(basketItems);
            
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public async Task<BasketIndexModel> PopulateBasketModel(string? userId)
        {
            // Get the basket items for the current user.
            var basketItems = await _context.BasketItem
                .Where(b => b.MaxicyclesUserId == userId)
                .Include(b => b.Item)
                .Include(b => b.MaxicyclesUser)
                .ToListAsync();

            var basketModel = new BasketIndexModel
            {
                // Create a list of view models.
                BasketItemModels = new List<BasketItemModel>()
            };

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
                
                // Add the BasketItem Total to the overall total price.
                basketModel.TotalPrice += basketItemModel.TotalPrice;
                
                basketModel.BasketItemModels.Add(basketItemModel);
            }

            return basketModel;
        }
    }
}
