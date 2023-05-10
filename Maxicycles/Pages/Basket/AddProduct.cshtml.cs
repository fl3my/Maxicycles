using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Pages.Basket
{
    public class AddProductModel : PageModel
    {
        private readonly Maxicycles.Data.MaxicyclesDbContext _context;
        private readonly UserManager<MaxicyclesUser> _userManager;

        public AddProductModel(Maxicycles.Data.MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet(int id)
        {
            var product = _context.Product.FirstOrDefault(i => i.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            BasketProduct = new BasketProduct()
            {
                Item = product
            };

            return Page();
        }

        [BindProperty]
        public BasketProduct BasketProduct { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync(int id)
        {
            // Get the product from the id.
            var product = _context.Product
                .FirstOrDefault(i => i.Id == id);
   
            if (product == null)
            {
                return NotFound();
            }
            
            // Get the current User Id.
            var userId = _userManager.GetUserId(User);

            if (userId == null)
            {
                return Unauthorized();
            }
            
            // Check if the user already has the current product in their basket.
            var alreadyInBasket = _context.BasketItem
                .Where(b => b.MaxicyclesUserId == userId)
                .Any(b => b.ItemId == product.Id);
            
            if (alreadyInBasket)
            {
                ModelState.AddModelError("", "Already in basket");
            }
            
            // Add the product and the userId to the model.
            BasketProduct.Item = product;
            BasketProduct.MaxicyclesUserId = userId;
            
            // Add a model error is the quantity in basket is more than is available in stock.
            if (BasketProduct.Quantity > product.Quantity)
            {
                ModelState.AddModelError("BasketProduct.Quantity", "Not enough items in stock");
            }
            
            // If validation is not successful.
            if (!ModelState.IsValid)
            {
                BasketProduct.MaxicyclesUserId = userId;
                BasketProduct.Item = product;
                return Page();
            }
            
            // Add the product to the basketItem Table.
            _context.BasketProduct.Add(BasketProduct);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
