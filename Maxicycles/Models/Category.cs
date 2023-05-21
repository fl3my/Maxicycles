using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class Category
{
    // Get add set the category ID.
    public int Id { get; set; }

    // Get add set the title.
    [Required] public string? Title { get; set; }

    // Get add set the navigational slug.
    [Required]
    [RegularExpression("^[a-z](-?[a-z])*$", ErrorMessage = "Slug must be a string in format 'a-fantastic-product'")]
    public string? Slug { get; set; }

    // One category has many subcategory.
    public ICollection<SubCategory> SubCategories { get; } = new List<SubCategory>();
}