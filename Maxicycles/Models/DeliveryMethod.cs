namespace Maxicycles.Models;

public class DeliveryMethod
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public decimal Price { get; set; }
    public int MinDaysToDeliver { get; set; }

    // Many DeliveryMethods to one order.
    public ICollection<Order> Orders { get; } = new List<Order>();
}