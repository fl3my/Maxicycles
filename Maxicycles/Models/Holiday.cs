using System.ComponentModel.DataAnnotations;
using Maxicycles.Validators;

namespace Maxicycles.Models;

public class Holiday
{
    // Get and set the holiday id.
    public int Id { get; set; }

    // Get and set the holiday title.
    [Required]
    [MinLength(2)]
    [MaxLength(40)]
    public string? Title { get; set; }

    // Get and set the Start date of the holiday.
    [Required]
    [Display(Name = "Inclusive Start Date")]
    [NotOnHoliday]
    [DataType(DataType.Date)]
    public DateTime Start { get; set; }

    // Get and set the end date of the holiday.
    [Required]
    [Display(Name = "Inclusive End Date")]
    [NotOnHoliday]
    [DataType(DataType.Date)]
    public DateTime End { get; set; }
}