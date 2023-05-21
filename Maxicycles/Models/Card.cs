using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

// This class inherits from the parent payment class.
public class Card : Payment
{
    // Get add set the payment cards Full Name.
    [Required] public string? Name { get; set; }

    // Get add set the Long card Number.
    [Required]
    [CreditCard]
    [Display(Name = "Card Number")]
    public string? LongNumber { get; set; }


    // Get add set the card security number.
    [Required]
    [RegularExpression("^[0-9]*$", ErrorMessage = "CVV must be only numbers.")]
    [StringLength(4, MinimumLength = 3)]
    public string? Cvv { get; set; }

    // Get add set the Expiry month.
    [Required] [Range(1, 12)] public int ExpiryMonth { get; set; }

    // Get add set the expiry year.
    [Required] [Range(0, 3000)] public int ExpiryYear { get; set; }
}