

using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

// This class inherits from the item class.
public class Product : Item
{
    // Get and set the product quantity in stock.
    [Required]
    [Range(0, 500)]
    public int Quantity { get; set; }
}