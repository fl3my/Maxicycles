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
using Maxicycles.Validators;
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
            
            // Combine Price and Title to select list.
            var deliveryMethods = _context.DeliveryMethods.Select(x => new
            {
                id = x.Id,
                name = x.Title + " " + x.Price.ToString("(+£0.00)")
            });
            
            // Add delivery methods to the form.
            ViewData["DeliveryMethodId"] = new SelectList(deliveryMethods, "id", "name");
            
            return Page();
        }

        [BindProperty]
        public OrderInputModel OrderInput { get; set; } = default!;

        public class OrderInputModel
        {
            [Required]
            [NotOnHoliday]
            [WithinFourteenDays]
            [Display(Name="Required Date")]
            [DataType(DataType.Date)]
            public DateTime RequiredDate { get; set; }
            [Required]
            [Display(Name="Delivery Method")]
            public int DeliveryMethodId { get; set; }
            [Required]
            [Display(Name="Payment Method")]
            public PaymentMethod PaymentMethod { get; set; }
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            // Get the current userId.
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return Unauthorized();
            }
            
            // Check if date is a valid time in the future.
            var minDaysToDeliver = ((await _context.DeliveryMethods.FindAsync(OrderInput.DeliveryMethodId))!).MinDaysToDeliver;

            // Validate minimum days after delivery.
            if (DateTime.Today.AddDays(minDaysToDeliver) > OrderInput.RequiredDate)
            {
                ModelState.AddModelError("OrderInput.RequiredDate", "The selected delivery method requires minimum " + minDaysToDeliver + " days to deliver");
            }

            // Get the basket items for the current user.
            var basketItems = await _context.BasketItem
                .Where(b => b.MaxicyclesUserId == user.Id)
                .Include(b => b.Item)
                .Include(b => b.MaxicyclesUser)
                .ToListAsync();

            // Calculate the total value of the order including deliveryCost.
            var basketPrice = basketItems.Sum(b => b.Quantity * b.Item.Price);
            var deliveryCost = (await _context.DeliveryMethods.FindAsync(OrderInput.DeliveryMethodId))!.Price;
            var totalPrice = basketPrice + deliveryCost;

            OrderInput.RequiredDate = OrderInput.RequiredDate.ToUniversalTime();

            // Create a new order object.
            var order = new Order
            {
                DeliveryMethodId = OrderInput.DeliveryMethodId,
                RequiredDate = OrderInput.RequiredDate,
                OrderDate = DateTime.Now.ToUniversalTime(),
                MaxicyclesUserId = user.Id,
                OrderStatus = OrderStatus.AwaitingPayment,
                TotalPrice = totalPrice,
                AddressLine1 = user.AddressLine1,
                AddressLine2 = user.AddressLine2,
                City = user.City,
                Postcode = user.Postcode
            };
            
            var orderItems = new List<OrderItem>();

            // Iterate through all items in the basket
            foreach (var item in basketItems)
            {
                // Cast the item into a there respective basket types.
                if (item is BasketProduct basketProduct)
                {
                    // Copy the contents of the  basket iten into a new order item.
                    if (basketProduct.Item != null)
                    {
                        orderItems.Add(new OrderProduct
                        {
                            Quantity = basketProduct.Quantity,
                            ItemPrice = basketProduct.Item.Price,
                            Title = basketProduct.Item.Title,
                        });

                        // Remove the basket quantity from the overall stock quantity.
                        if (basketProduct.Item is Product product)
                        {
                            // Check if there is enough quantity in stock
                            if (product.Quantity > basketProduct.Quantity)
                            {
                                product.Quantity -= basketProduct.Quantity;
                            }
                            else
                            {
                                ModelState.AddModelError("",
                                    "Sorry, only " + product.Quantity + " " + product.Title + " in stock");
                            }
                        }
                    }
                } else if (item is BasketService basketService)
                {
                    if (basketService.Item != null)
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
            }
            
            if (!ModelState.IsValid)
            {
                // Combine Price and Title to select list.
                var deliveryMethods = _context.DeliveryMethods.Select(x => new
                {
                    id = x.Id,
                    name = x.Title + " " + x.Price.ToString("(+£0.00)")
                });
            
                // Add delivery methods to the form.
                ViewData["DeliveryMethodId"] = new SelectList(deliveryMethods, "id", "name");
                
                // Populate the basketModel.
                BasketModel = await PopulateBasketModel(user.Id);
                
                return Page();
            } 
            
            // Add the orderItems to the order object.
            order.OrderItems = orderItems;
            
            // Add the order to the database.
            _context.Orders.Add(order);
            
            // Remove all the items in the users basket.
            _context.BasketItem.RemoveRange(basketItems);
            
            await _context.SaveChangesAsync();

            // Redirect the user to the required payment page.
            return OrderInput.PaymentMethod switch
            {
                PaymentMethod.Card => RedirectToPage("./CardPayment", new {orderId = order.Id}),
                PaymentMethod.External => RedirectToPage("./External", new {orderId = order.Id}),
                _ => NotFound()
            };
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
                    basketItemModel.ServiceDate = service.ServiceDate.ToLocalTime();
                }
                
                // Add the BasketItem Total to the overall total price.
                basketModel.TotalPrice += basketItemModel.TotalPrice;
                
                basketModel.BasketItemModels.Add(basketItemModel);
            }

            return basketModel;
        }
    }
}
