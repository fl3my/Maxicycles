using Microsoft.Build.Framework;

namespace Maxicycles.Models;

// This class inherits from the item class.
public class Product : Item
{
    // Get and set the product quantity in stock.
    [Required] public int Quantity { get; set; }
}