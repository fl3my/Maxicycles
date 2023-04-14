using Microsoft.Build.Framework;

namespace Maxicycles.Models;

public class Product : Item
{
    [Required]
    public int Quantity { get; set; }
}