using Maxicycles.Data;
using Maxicycles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maxicycles.Pages.Basket;

public class AddProductModel : PageModel
{
    private readonly MaxicyclesDbContext _context;
    private readonly UserManager<MaxicyclesUser> _userManager;

    public AddProductModel(MaxicyclesDbContext context, UserManager<MaxicyclesUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [BindProperty] public BasketProduct BasketProduct { get; set; } = default!;

    public IActionResult OnGet(int? id)
    {
        // Check if the id is not null.
        if (id == null) return NotFound();

        // Get the product from the id parameter.
        var product = _context.Products.FirstOrDefault(i => i.Id == id);

        // If the product does not exist.
        if (product == null) return NotFound("Product does not exist.");

        // Create a basket product model with a default value of 1 and details of the current product.
        BasketProduct = new BasketProduct
        {
            Item = product,
            Quantity = 1
        };

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        // Check that the id is not null.
        if (id == null) return NotFound();

        // Get the product from the id parameter.
        var product = _context.Products.FirstOrDefault(i => i.Id == id);

        // Return not found if the product does not exist.
        if (product == null) return NotFound("Product does not exist.");

        // Get the current User Id from the logged in user.
        var userId = _userManager.GetUserId(User);

        // Return unauthorized if the user is not logged in.
        if (userId == null) return Unauthorized();

        // Check if the user already has the current product in their basket.
        var alreadyInBasket = _context.BasketItems
            .Where(b => b.MaxicyclesUserId == userId)
            .Any(b => b.ItemId == product.Id);

        // Add a model error to the model if alreadyInBasket is true.
        if (alreadyInBasket) ModelState.AddModelError("", "Already in basket");

        // Add a model error fs the quantity in basket is more than is available in stock.
        if (BasketProduct.Quantity > product.Quantity)
            ModelState.AddModelError("BasketProduct.Quantity", "Not enough items in stock");

        // Add the product and the userId to the model.
        BasketProduct.Item = product;
        BasketProduct.MaxicyclesUserId = userId;

        // If validation is not successful.
        if (!ModelState.IsValid) return Page();

        // Add the product to the basketItem Table.
        _context.BasketProducts.Add(BasketProduct);

        // Save changes to the database.
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}