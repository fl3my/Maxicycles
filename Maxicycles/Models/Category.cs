using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class Category
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Slug { get; set; }
    
    // One category has many subcategory.
    public ICollection<SubCategory> SubCategories { get; } = new List<SubCategory>();
}