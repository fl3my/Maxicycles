using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class Card : Payment
{
    [Required]
    public string? Name { get; set; }
    
    [Required]
    [CreditCard]
    [Display(Name = "Card Number")]
    public string? LongNumber { get; set; }
    
    [Required]
    [RegularExpression("^[0-9]*$", ErrorMessage = "CVV must be only numbers.")]
    [StringLength(4, MinimumLength = 3)]
    public string? Cvv { get; set; }
    
    [Required]
    [Range(1, 12)]
    public int ExpiryMonth { get; set; }
    
    [Required]
    [Range(0, 3000)]
    public int ExpiryYear { get; set; }
}