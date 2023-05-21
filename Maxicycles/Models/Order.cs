using System.ComponentModel.DataAnnotations;
using Maxicycles.Enums;

namespace Maxicycles.Models;

public class Order
{
    // Get and set the order ID.
    public int Id { get; set; }

    // Get and set the date ordered.
    [Display(Name = "Date ordered")] public DateTime OrderDate { get; set; }

    // Get and set the target deliveryDate.
    [DataType(DataType.Date)]
    [Display(Name = "Target Delivery Date")]
    public DateTime TargetDeliveryDate { get; set; }

    // Get and set the shipped date.
    [Display(Name = "Date Shipped")] public DateTime? ShippedDate { get; set; }

    // Get and set the enum for order status.
    [Display(Name = "Order Status")] public OrderStatus OrderStatus { get; set; }

    // Get and set a boolean for if the receipt has been sent or not.
    public bool ReceiptSent { get; set; }

    // Get and set the Total price of the order.
    [Display(Name = "Total Price")] public decimal TotalPrice { get; set; }

    // Get and set the billing First name.
    [Display(Name = "First Name")] public string? FirstName { get; set; }

    // Get and set the billing last name.
    [Display(Name = "Last Name")] public string? LastName { get; set; }

    // Get and set the billing email.
    public string? Email { get; set; }

    // Get and set the billing Country.
    public string? Country { get; set; }

    // Get and set the billing Address line 1.
    public string? AddressLine1 { get; set; }

    // Get and set the billing Address line 2.
    public string? AddressLine2 { get; set; }

    // Get and set the billing city.
    public string? City { get; set; }

    // Get and set the billing postcode.
    public string? Postcode { get; set; }

    // Many Order to one Maxicycles User.
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    // One Order to one payment.
    public Payment? Payment { get; set; }

    // Get and set the delivery Method id.
    // One Order to many Delivery.
    public int? DeliveryMethodId { get; set; }

    [Display(Name = "Delivery Method")] public DeliveryMethod? DeliveryMethod { get; set; }

    // Get and set the user Id.
    // Many Order to one MaxicyclesUser.
    public string MaxicyclesUserId { get; set; } = string.Empty;
    public MaxicyclesUser MaxicyclesUser { get; set; } = null!;
}