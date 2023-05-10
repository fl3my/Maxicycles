using System.ComponentModel.DataAnnotations;
using Maxicycles.Validators;

namespace Maxicycles.Models;

public class BasketService : BasketItem
{
    [Required]
    [WithinFourteenDays]
    [NotOnHoliday]
    [DataType(DataType.Date)]
    public DateTime ServiceDate { get; set; } 
}