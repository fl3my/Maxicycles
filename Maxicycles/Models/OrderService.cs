namespace Maxicycles.Models;

// This inherits from the order item class.
public class OrderService : OrderItem
{
    // Get and set the date of service.
    public DateTime ServiceDate { get; set; }
}