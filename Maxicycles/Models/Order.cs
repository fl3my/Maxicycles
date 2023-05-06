using Maxicycles.Enums;

namespace Maxicycles.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    public OrderStatus OrderStatus { get; set; } = OrderStatus.AwaitingPayment;
    
    // Many Order to one Maxicycles User.
    public ICollection<OrderItem> OrderItems = new List<OrderItem>();
    
    // One Order to one payment.
    public Payment? Payment { get; set; }
    
    // One Order to many Delivery.
    public int DeliveryMethodId { get; set; }
    public DeliveryMethod DeliveryMethod { get; set; } = null!;

    // Many Order to one MaxicyclesUser.
    public string MaxicyclesUserId { get; set; } = string.Empty;
    public MaxicyclesUser MaxicyclesUser { get; set; } = null!;
}