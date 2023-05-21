using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class Image
{
    // Get and set the image id.
    public int Id { get; set; }

    // Get and set a descriptive name for the image.
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    public string? Title { get; set; }

    // Get and set the alternative text for the image.
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    [Display(Name = "Alternative Text")]
    public string? AltText { get; set; }

    // Get and set the Image file name.
    public string? ImageName { get; set; }

    // Get and set the uploaded at datetime.
    public DateTime UploadedAt { get; set; }

    // One image can have many products.
    public ICollection<Item> Item { get; } = new List<Item>();
}