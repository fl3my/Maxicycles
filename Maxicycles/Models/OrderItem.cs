namespace Maxicycles.Models;

public class OrderItem
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public decimal ItemPrice { get; set; }
    public string? Title { get; set; }

    // Many OrderItem to one Order.
    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;
}