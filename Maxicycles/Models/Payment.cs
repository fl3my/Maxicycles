namespace Maxicycles.Models;

public class Payment
{
    // Get and set the Id.
    public int Id { get; set; }

    // Get and set the order id.
    // One payment to one order.
    public int OrderId { get; set; }
    public Order? Order { get; set; }
}