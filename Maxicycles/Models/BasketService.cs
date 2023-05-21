using System.ComponentModel.DataAnnotations;
using Maxicycles.Validators;

namespace Maxicycles.Models;

// This class inherits from the parent basket item class.
public class BasketService : BasketItem
{
    // Get add set the Service Date.
    [Required]
    [WithinFourteenDays]
    [NotOnHoliday]
    [DataType(DataType.Date)]
    public DateTime ServiceDate { get; set; }
}