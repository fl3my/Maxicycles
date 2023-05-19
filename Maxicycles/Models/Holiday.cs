using System.ComponentModel.DataAnnotations;
using Maxicycles.Validators;

namespace Maxicycles.Models;

public class Holiday
{
    public int Id { get; set; }
    [Required]
    [MinLength(2)]
    [MaxLength(40)]
    public string? Title { get; set; }
    [Required]
    [Display(Name="Inclusive Start Date")]
    [NotOnHoliday]
    [DataType(DataType.Date)]
    public DateTime Start { get; set; }
    [Required]
    [Display(Name="Inclusive End Date")]
    [NotOnHoliday]
    [DataType(DataType.Date)]

    public DateTime End { get; set; }
}