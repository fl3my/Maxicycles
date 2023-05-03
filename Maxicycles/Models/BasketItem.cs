using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class BasketItem
{
    public int Id { get; set; }
    
    [Required]
    [Range(1, 1000)]
    public int Quantity { get; set; }

    // One BasketItem to many Items (required).
    public int ItemId { get; set; }
    public Item? Item { get; set; }

    // Many basketItem to one MaxicyclesUser.
    public string? MaxicyclesUserId { get; set; }
    public MaxicyclesUser? MaxicyclesUser { get; set; }
}