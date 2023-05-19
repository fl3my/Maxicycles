using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class DeliveryMethod
{
    public int Id { get; set; }
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    public string? Title { get; set; }
    
    [Required]
    [Range(0, 100)]
    public decimal Price { get; set; }
    
    [Required]
    [Display(Name = "Minimum Days to Deliver")]
    [Range(1, 30)]
    public int MinDaysToDeliver { get; set; }
    
    [Display(Name = "Is Shipping Day Selectable")]
    public bool IsDaySelectable { get; set; }

// Many DeliveryMethods to one order.
    public ICollection<Order> Orders { get; } = new List<Order>();
}