namespace Maxicycles.Models;

public class Payment
{
    public int Id { get; set; }

    // One payment to one order.
    public int OrderId { get; set; }
    public Order? Order { get; set; }
}