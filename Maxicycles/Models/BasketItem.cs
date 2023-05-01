namespace Maxicycles.Models;

public class BasketItem
{
    public int Id { get; set; }
    public int? Quantity { get; set; }
    public DateTime? ServiceDate { get; set; }
    
    // One BasketItem to many Items (required).
    public int ItemId { get; set; }
    public Item Item { get; set; } = null!;

    // Many basketItem to one MaxicyclesUser.
    public string? MaxicyclesUserId { get; set; }
    public MaxicyclesUser? MaxicyclesUser { get; set; }
}