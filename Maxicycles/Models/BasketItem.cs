using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class BasketItem
{
    // Get add set the product ID.
    public int Id { get; set; }

    // Get add set the Quantity.
    [Required] [Range(1, 1000)] public int Quantity { get; set; }

    // Get add set the ItemId.
    // One BasketItem to many Items (required).
    public int ItemId { get; set; }
    public Item? Item { get; set; }

    // Get add set the user ID.
    // Many basketItem to one MaxicyclesUser.
    public string? MaxicyclesUserId { get; set; }
    public MaxicyclesUser? MaxicyclesUser { get; set; }
}