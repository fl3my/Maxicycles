using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class Image
{
    public int Id { get; set; }
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    public string? Title { get; set; }
    
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    [Display(Name = "Alternative Text")]
    public string? AltText { get; set; }
    
    [Required]
    public string? ImageName { get; set; }
    public DateTime UploadedAt { get; set; }
    
    // One image can have many products.
    public ICollection<Item> Item { get; } = new List<Item>();

}