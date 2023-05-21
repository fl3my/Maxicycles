using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class SubCategory
{
    // Get and set the sub category id.
    public int Id { get; set; }

    // Get and set the title.
    [Required] public string? Title { get; set; }

    // Get and set the navigational slug.
    [Required]
    [RegularExpression("^[a-z](-?[a-z])*$", ErrorMessage = "Slug must be a string in format 'a-fantastic-product'")]
    public string? Slug { get; set; }

    // Get and set the category id.
    // Many subcategory have one Category.
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    // One subcategory to many products.
    public ICollection<Item> Items { get; } = new List<Item>();
}