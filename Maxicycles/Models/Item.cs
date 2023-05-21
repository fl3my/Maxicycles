using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class Item
{
    // Many Items to one basketItem.
    public ICollection<BasketItem> BasketItems = new List<BasketItem>();

    // Get and set the item Id.
    public int Id { get; set; }

    // Get and set the item title.
    [Required]
    [MinLength(5)]
    [MaxLength(100)]
    public string? Title { get; set; }

    // Get and set the navigational slug.
    [Required]
    [RegularExpression("^[a-z](-?[a-z])*$", ErrorMessage = "Slug must be a string in format 'a-fantastic-product'")]
    public string? Slug { get; set; }

    // Get and set the items description.
    [Required]
    [DataType(DataType.MultilineText)]
    [MinLength(10)]
    [MaxLength(1000)]
    public string? Description { get; set; }

    // Get and set the items price.
    [Required] [Range(0, 10000)] public decimal Price { get; set; }

    // Get and set the subcategory Id.
    // Many item to one subcategory.
    [Required] public int? SubCategoryId { get; set; }

    [Display(Name = "Sub Category Name")] public SubCategory? SubCategory { get; set; }

    // Get and set the image id.
    // Many item to one image.
    [Required] public int? ImageId { get; set; }

    public Image? Image { get; set; }
}