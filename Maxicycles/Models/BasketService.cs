using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class BasketService : BasketItem
{
    [Required]
    [DataType(DataType.Date)]
    public DateTime ServiceDate { get; set; } 
}