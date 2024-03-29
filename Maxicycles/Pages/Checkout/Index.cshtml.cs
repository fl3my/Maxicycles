using System.ComponentModel.DataAnnotations;
using Maxicycles.Data;
using Maxicycles.Enums;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Stripe.Checkout;

namespace Maxicycles.Pages.Checkout;

public class IndexModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public IndexModel(MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public BasketIndexModel BasketModel { get; set; } = default!;

    [BindProperty] public OrderInputModel OrderInput { get; set; } = default!;

    public async Task<IActionResult> OnGet()
    {
        // Get the current userId for the logged in user.
        var userId = _userManager.GetUserId(User);

        // Get all the basket items that belong to the user.
        var basketItems = _context.BasketItems.Where(b => b.MaxicyclesUserId == userId);

        // if there is not basketItems, Return unauthorized.
        if (!basketItems.Any()) return Unauthorized();

        // Populate The Model.
        BasketModel = await PopulateBasketModel(userId);
        
        // Check if any of the basket items are a product.
        if (basketItems.Any(b => b is BasketProduct))
        {
            // Add formatted delivery methods to the form.
            ViewData["DeliveryMethodId"] = GetFormattedDeliveryMethods();
        }
        else
        {
            // Only show the free delivery options
            var freeDeliveryMethods = _context.DeliveryMethods.Where(d => d.Price == 0M).Select(x => new
            {
                id = x.Id,
                name = x.Title + " " + x.Price.ToString("(+£0.00)")
            });
                
            ViewData["DeliveryMethodId"] = new SelectList(freeDeliveryMethods, "id", "name");
        }

        return Page();
    }

    public async Task<IActionResult> OnPostCheckoutStripeAsync()
    {
        // Remove Model State from card fields.
        ModelState.Remove("OrderInput.Card.Cvv");
        ModelState.Remove("OrderInput.Card.LongNumber");
        ModelState.Remove("OrderInput.Card.Name");
        ModelState.Remove("OrderInput.Card.ExpiryMonth");
        ModelState.Remove("OrderInput.Card.ExpiryYear");

        // Get the current userId for the logged in user.
        var user = await _userManager.GetUserAsync(User);

        // If the user is null then return unauthorized.
        if (user == null) return Unauthorized();

        // Get the basket items for the current user.
        var basketItems = await _context.BasketItems
            .Where(b => b.MaxicyclesUserId == user.Id)
            .Include(b => b.MaxicyclesUser)
            .Include(b => b.Item)
            .ThenInclude(b => b.Image)
            .ToListAsync();

        // Get delivery method.
        var deliveryMethod = await _context.DeliveryMethods.FindAsync(OrderInput.DeliveryMethodId);

        if (deliveryMethod == null) return NotFound();

        // Check if form validation is true.
        if (!ModelState.IsValid)
        {
            // Check if any of the basket items are a product.
            if (basketItems.Any(b => b is BasketProduct))
            {
                // Add formatted delivery methods to the form.
                ViewData["DeliveryMethodId"] = GetFormattedDeliveryMethods();
            }
            else
            {
                // Only show the free delivery options
                var freeDeliveryMethods = _context.DeliveryMethods.Where(d => d.Price == 0M).Select(x => new
                {
                    id = x.Id,
                    name = x.Title + " " + x.Price.ToString("(+£0.00)")
                });
                
                ViewData["DeliveryMethodId"] = new SelectList(freeDeliveryMethods, "id", "name");
            }
            
            // Populate the basketModel.
            BasketModel = await PopulateBasketModel(user.Id);

            return Page();
        }

        // Create a stripe external payment record to be stored in the database.
        var stripeExternal = new ExternalPayment{ Title = "Stripe" };
        
        // Use custom function to populate an order.
        var order = PopulateOrder(basketItems, stripeExternal, deliveryMethod, user.Id);

        // Add the order to the database.
        _context.Orders.Add(order);

        // Remove all the items in the users basket.
        _context.BasketItems.RemoveRange(basketItems);

        // Save changes to the database.
        await _context.SaveChangesAsync();
        
        const string domain = "http://localhost:5888";

        // Get the delivery day selection page if user has selected any day delivery, otherwise get confirmation.
        var successUrl = deliveryMethod.IsDaySelectable ? "/checkout/DeliveryDaySelection?orderId=" : "/checkout/OrderConfirmation?orderId=";
        
        // Add the order.Id onto the end of the success urls.
        successUrl += order.Id;
        
        // Create a list of stripe line items.
        var stripeBasketList = new List<SessionLineItemOptions>();

        // Iterate over the customers current basket.
        foreach (var basketItem in basketItems)
            // If the basket.Item is not null
            if (basketItem.Item != null)
                // Add a new item to the list.
                stripeBasketList.Add(new SessionLineItemOptions
                {
                    // Create price data for the stripe api.
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        // Unit amount is in pence, so convert to pence.
                        UnitAmount = (int)(basketItem.Item.Price * 100),
                        Currency = "gbp",
                        // Add the product data.
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = basketItem.Item.Title,
                            Description = basketItem.Item.GetType().Name
                        }
                    },
                    Quantity = basketItem.Quantity
                });


        // Create the shipping option on the stripe payment.
        var options = new SessionCreateOptions
        {
            ShippingOptions = new List<SessionShippingOptionOptions>
            {
                new()
                {
                    // Add the new shipping option with data selected by the user.
                    ShippingRateData = new SessionShippingOptionShippingRateDataOptions
                    {
                        Type = "fixed_amount",
                        FixedAmount = new SessionShippingOptionShippingRateDataFixedAmountOptions
                        {
                            Amount = (int)(deliveryMethod.Price * 100),
                            Currency = "gbp"
                        },
                        DisplayName = deliveryMethod.Title,
                        DeliveryEstimate = new SessionShippingOptionShippingRateDataDeliveryEstimateOptions
                        {
                            Minimum = new SessionShippingOptionShippingRateDataDeliveryEstimateMinimumOptions
                            {
                                Unit = "day",
                                Value = deliveryMethod.MinDaysToDeliver
                            }
                        }
                    }
                }
            },
            // Add the basket items to the stripe api.
            LineItems = stripeBasketList,

            // One time payment mode.
            Mode = "payment",

            // The success and cancel urls.
            SuccessUrl = domain + successUrl,
            CancelUrl = domain + "/checkout/CancelOrder?orderId=" + order.Id,
        };

        // Create a stripe checkout session.
        // This controls what the customer sees on the payment page.
        var service = new SessionService();
        var session = await service.CreateAsync(options);

        // After creating the session, redirect the customer to the url for the checkout page.
        Response.Headers.Add("Location", session.Url);

        return new StatusCodeResult(303);
    }

    public async Task<IActionResult> OnPostCheckoutDebitAsync()
    {
        // Check that the input card is valid.
        if (OrderInput.Card is { ExpiryYear: > 0, ExpiryMonth: > 0 })
        {
            // Convert the month and year values into a datetime object.
            var cardExpiryDate = new DateTime(OrderInput.Card.ExpiryYear, OrderInput.Card.ExpiryMonth, 1);

            // Check if the card date is not in the past.
            if (DateTime.Now >= cardExpiryDate)
                ModelState.AddModelError("OrderInput.Card.ExpiryMonth", "Card is Expired");
        }
        else
        {
            ModelState.AddModelError("OrderInput.Card.ExpiryMonth", "Card input not valid");
        }

        // Create a new card object and populate it with values from the validation.
        var payment = new Card
        {
            Name = OrderInput.Card.Name,
            LongNumber = OrderInput.Card.LongNumber,
            ExpiryYear = OrderInput.Card.ExpiryYear,
            ExpiryMonth = OrderInput.Card.ExpiryMonth,
            Cvv = OrderInput.Card.Cvv
        };

        // Get the current userId for the logged in user.
        var user = await _userManager.GetUserAsync(User);

        // If the user is null then return unauthorized.
        if (user == null) return Unauthorized();

        // Get the basket items for the current user.
        var basketItems = await _context.BasketItems
            .Where(b => b.MaxicyclesUserId == user.Id)
            .Include(b => b.Item)
            .Include(b => b.MaxicyclesUser)
            .ToListAsync();

        // Get delivery method.
        var deliveryMethod = await _context.DeliveryMethods.FindAsync(OrderInput.DeliveryMethodId);
        if (deliveryMethod == null) return NotFound();

        // Check if form validation is true.
        if (!ModelState.IsValid)
        {
            // Check if any of the basket items are a product.
            if (basketItems.Any(b => b is BasketProduct))
            {
                // Add formatted delivery methods to the form.
                ViewData["DeliveryMethodId"] = GetFormattedDeliveryMethods();
            }
            else
            {
                // Only show the free delivery options
                var freeDeliveryMethods = _context.DeliveryMethods.Where(d => d.Price == 0M).Select(x => new
                {
                    id = x.Id,
                    name = x.Title + " " + x.Price.ToString("(+£0.00)")
                });
                
                ViewData["DeliveryMethodId"] = new SelectList(freeDeliveryMethods, "id", "name");
            }
            
            // Populate the basketModel.
            BasketModel = await PopulateBasketModel(user.Id);

            return Page();
        }

        // Use the populate order function to populate the order class.
        var order = PopulateOrder(basketItems, payment, deliveryMethod, user.Id);

        // Add the order to the database.
        _context.Orders.Add(order);

        // Remove all the items in the users basket.
        _context.BasketItems.RemoveRange(basketItems);

        // Save changes to the database.
        await _context.SaveChangesAsync();

        // If user has selected any day delivery go to the select day page.
        if (deliveryMethod.IsDaySelectable) return RedirectToPage("./DeliveryDaySelection", new { orderId = order.Id });

        // Otherwise, Go to the order confirmation page.
        return RedirectToPage("./OrderConfirmation", new { orderId = order.Id });
    }

    public Order PopulateOrder(List<BasketItem> basketItems, Payment payment, DeliveryMethod deliveryMethod,
        string userId)
    {
        var order = new Order
        {
            OrderDate = DateTime.UtcNow,
            MaxicyclesUserId = userId,
            OrderStatus = OrderStatus.AwaitingPayment,
            ReceiptSent = false,
            FirstName = OrderInput.FirstName,
            LastName = OrderInput.LastName,
            Email = OrderInput.Email,
            AddressLine1 = OrderInput.AddressLine1,
            AddressLine2 = OrderInput.AddressLine2,
            City = OrderInput.City,
            Country = OrderInput.Country,
            Postcode = OrderInput.Postcode,
            DeliveryMethodId = OrderInput.DeliveryMethodId,
            Payment = payment
        };

        // Create a list to store the new order items.
        var orderItems = new List<OrderItem>();

        // Iterate through all items in the basket.
        foreach (var item in basketItems)
            // Cast the item into their respective basket types.
            if (item is BasketProduct basketProduct)
            {
                // Copy the contents of the  basket iten into a new order item.
                if (basketProduct.Item != null)
                {
                    orderItems.Add(new OrderProduct
                    {
                        Quantity = basketProduct.Quantity,
                        ItemPrice = basketProduct.Item.Price,
                        Title = basketProduct.Item.Title
                    });

                    // Remove the basket quantity from the overall stock quantity.
                    if (basketProduct.Item is Product product)
                    {
                        // Check if there is enough quantity in stock
                        if (product.Quantity >= basketProduct.Quantity)
                            product.Quantity -= basketProduct.Quantity;
                        else
                            ModelState.AddModelError("",
                                "Sorry, only " + product.Quantity + " " + product.Title + " in stock");
                    }
                }
            }
            // Otherwise item is a service.
            else if (item is BasketService basketService)
            {
                // Create a order item with service date if it is a service.
                if (basketService.Item != null)
                    orderItems.Add(new OrderService
                    {
                        Quantity = basketService.Quantity,
                        ItemPrice = basketService.Item.Price,
                        Title = basketService.Item.Title,
                        ServiceDate = basketService.ServiceDate
                    });
            }

        // Prevent orders being made when the store is closed.
        foreach (var holiday in _context.Holidays)
            // Check if date is in the holiday window.
            if (DateTime.Now >= holiday.Start && DateTime.Now <= holiday.End)
                ModelState.AddModelError("",
                    "Sorry, We are currently closed for " + holiday.Title + ". We reopen for online orders on " +
                    holiday.End.ToShortDateString());

        // Add the orderItems to the order object.
        order.OrderItems = orderItems;

        // Calculate the estimated delivery day.
        var estimatedDeliveryDate = DateTime.Today.AddDays(deliveryMethod.MinDaysToDeliver);

        // If the estimated date is on a holiday move the date to the next available date.
        foreach (var holiday in _context.Holidays)
            // Check if date is in the holiday window.
            if (estimatedDeliveryDate >= holiday.Start && estimatedDeliveryDate <= holiday.End)
                estimatedDeliveryDate = holiday.End;

        order.TargetDeliveryDate = estimatedDeliveryDate.ToUniversalTime();

        // Calculate the total value of the order including deliveryCost.
        var totalPrice = basketItems.Sum(b => b.Quantity * b.Item!.Price) + deliveryMethod.Price;
        order.TotalPrice = totalPrice;

        return order;
    }

    private async Task<BasketIndexModel> PopulateBasketModel(string? userId)
    {
        // Get the basket items for the current user.
        var basketItems = await _context.BasketItems
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
            var basketItemModel = new BasketItemModel
            {
                Id = item.Id,
                Title = item.Item?.Title,
                Quantity = item.Quantity,
                ItemPrice = item.Item!.Price,
                TotalPrice = item.Quantity * item.Item.Price,
                ItemType = item.Item.GetType().Name
            };

            // If the model is a service add the serviceDate.
            if (item is BasketService service) basketItemModel.ServiceDate = service.ServiceDate.ToLocalTime();

            // Add the BasketItem Total to the overall total price.
            basketModel.TotalPrice += basketItemModel.TotalPrice;

            basketModel.BasketItemModels.Add(basketItemModel);
        }

        return basketModel;
    }

    private SelectList GetFormattedDeliveryMethods()
    {
        // Combine Price and Title to select list.
        var deliveryMethods = _context.DeliveryMethods.Select(x => new
        {
            id = x.Id,
            name = x.Title + " " + x.Price.ToString("(+£0.00)")
        });

        return new SelectList(deliveryMethods, "id", "name");
    }

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

        [DataType(DataType.Date)] public DateTime? ServiceDate { get; set; }

        public decimal ItemPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string? ItemType { get; set; }
    }

    public class OrderInputModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        [Display(Name = "First name")]
        public string? FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        [Display(Name = "Last name")]

        public string? LastName { get; set; }

        [Required] [EmailAddress] public string? Email { get; set; }

        [Required] [Display(Name = "Address")] public string? AddressLine1 { get; set; }

        [Display(Name = "Address 2")] public string? AddressLine2 { get; set; }

        [Required] 
        [MinLength(3)]
        [MaxLength(50)]
        public string? City { get; set; }
        [Required] public string? Country { get; set; }

        [Required]
        [RegularExpression(
            @"([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\s?[0-9][A-Za-z]{2})",
            ErrorMessage = "Must be a valid UK Postcode")]
        public string? Postcode { get; set; }

        [Required]
        [Display(Name = "Delivery Method")]
        public int DeliveryMethodId { get; set; }

        public Card Card { get; set; } = null!;
    }
}