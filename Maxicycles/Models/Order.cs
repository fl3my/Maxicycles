using System.ComponentModel.DataAnnotations;
using Maxicycles.Enums;

namespace Maxicycles.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    [DataType(DataType.Date)]
    public DateTime RequiredDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    public OrderStatus OrderStatus { get; set; } = OrderStatus.AwaitingPayment;

    public bool ReceiptSent { get; set; }
    public decimal TotalPrice { get; set; }
    
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; } 
    public string? City { get; set; }
    public string? Postcode { get; set; }
    
    // Many Order to one Maxicycles User.
    public ICollection<OrderItem> OrderItems { get; set; }= new List<OrderItem>();
    
    // One Order to one payment.
    public Payment? Payment { get; set; }
    
    // One Order to many Delivery.
    public int DeliveryMethodId { get; set; }
    public DeliveryMethod DeliveryMethod { get; set; } = null!;

    // Many Order to one MaxicyclesUser.
    public string MaxicyclesUserId { get; set; } = string.Empty;
    public MaxicyclesUser MaxicyclesUser { get; set; } = null!;
}