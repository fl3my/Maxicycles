using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class DeliveryMethod
{
    // Get add set the deliveryMethodId.
    public int Id { get; set; }

    // Get and set the title.
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    public string? Title { get; set; }

    // Get add set the price of postage.
    [Required] [Range(0, 100)] public decimal Price { get; set; }

    // Get add set the minimum days to deliver a parcel.
    [Required]
    [Display(Name = "Minimum Days to Deliver")]
    [Range(1, 30)]
    public int MinDaysToDeliver { get; set; }

    // Get add set a bool for allowing any day shipping.
    [Display(Name = "Is Shipping Day Selectable")]
    public bool IsDaySelectable { get; set; }

    // Many DeliveryMethods to one order.
    public ICollection<Order> Orders { get; } = new List<Order>();
}