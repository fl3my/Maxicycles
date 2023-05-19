using System.ComponentModel.DataAnnotations;
using Maxicycles.Enums;

namespace Maxicycles.Models;

public class Order
{
    public int Id { get; set; }
    [Display(Name = "Date ordered")]
    public DateTime OrderDate { get; set; }
    [DataType(DataType.Date)]
    
    [Display(Name = "Target Delivery Date")]
    public DateTime RequiredDate { get; set; }
    
    [Display(Name = "Date Shipped")]
    public DateTime? ShippedDate { get; set; }
    
    [Display(Name = "Order Status")]
    public OrderStatus OrderStatus { get; set; } = OrderStatus.AwaitingPayment;

    public bool ReceiptSent { get; set; }
    [Display(Name = "Total Price")]
    public decimal TotalPrice { get; set; }
    [Display(Name = "First Name")]

    public string? FirstName { get; set; }
    [Display(Name = "Last Name")]

    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Country { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; } 
    public string? City { get; set; }
    public string? Postcode { get; set; }
    
    // Many Order to one Maxicycles User.
    public ICollection<OrderItem> OrderItems { get; set; }= new List<OrderItem>();
    
    // One Order to one payment.
    public Payment? Payment { get; set; }
    
    // One Order to many Delivery.
    public int? DeliveryMethodId { get; set; }
    [Display(Name = "Delivery Method")]
    public DeliveryMethod? DeliveryMethod { get; set; }

    // Many Order to one MaxicyclesUser.
    public string MaxicyclesUserId { get; set; } = string.Empty;
    public MaxicyclesUser MaxicyclesUser { get; set; } = null!;
}