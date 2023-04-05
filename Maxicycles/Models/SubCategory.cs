namespace Maxicycles.Models;

public class SubCategory
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    
    // Many subcategory have one Category.
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}