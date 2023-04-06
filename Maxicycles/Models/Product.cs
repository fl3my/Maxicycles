using Microsoft.Build.Framework;

namespace Maxicycles.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    public string? ImagePath { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public int Quantity { get; set; }

    // Many product to one subcategory.
    [Required]
    public int SubCategoryId { get; set; }
    public SubCategory? SubCategory { get; set; }
    
    // Many products to one image.
    public int ImageId { get; set; }
    public Image? Image { get; set; }
}