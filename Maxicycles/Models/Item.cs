using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class Item
{
    public int Id { get; set; }
    [Required]
    [MinLength(5)]
    [MaxLength(100)]
    public string? Title { get; set; }
    
    [Required]
    [RegularExpression("^[a-z](-?[a-z])*$", ErrorMessage = "Slug must be a string in format 'a-fantastic-product'")]
    public string? Slug { get; set; }
    
    [Required]
    [DataType(DataType.MultilineText)]
    [MinLength(10)]
    [MaxLength(1000)]
    public string? Description { get; set; }
    
    [Required]
    [Range(0, 10000)]
    public decimal Price { get; set; }

    // Many item to one subcategory.
    [Required]
    public int SubCategoryId { get; set; }
    
    [Display(Name = "Sub Category Name")]
    public SubCategory? SubCategory { get; set; }
    
    // Many item to one image.
    public int ImageId { get; set; }
    public Image? Image { get; set; }
    
    // Many Items to one basketItem.
    public ICollection<BasketItem> BasketItems = new List<BasketItem>();
}