using System.ComponentModel.DataAnnotations;

namespace Maxicycles.Models;

public class SubCategory
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Slug { get; set; }

    // Many subcategory have one Category.
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    
    // One subcategory to many products.
    public ICollection<Item> Items { get; } = new List<Item>();
}