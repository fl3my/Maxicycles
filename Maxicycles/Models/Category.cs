using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class Category
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    [RegularExpression("^[a-z](-?[a-z])*$", ErrorMessage = "Slug must be a string in format 'a-fantastic-product'")]
    public string? Slug { get; set; }
    
    // One category has many subcategory.
    public ICollection<SubCategory> SubCategories { get; } = new List<SubCategory>();
}