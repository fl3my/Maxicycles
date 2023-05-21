namespace Maxicycles.Models;

public class OrderItem
{
    // Get and set the Id.
    public int Id { get; set; }

    // Get and set the order line quantity.
    public int Quantity { get; set; }

    // Get and se the item price.
    public decimal ItemPrice { get; set; }

    // Get and set the item name.
    public string? Title { get; set; }

    // Get and set the order id.
    // Many OrderItem to one Order.
    public int OrderId { get; set; }
    public Order? Order { get; set; }
}