namespace Maxicycles.Models;

public class Category
{
    public int Id { get; set; }
    public string? Title { get; set; }
    
    // One category has many subcategory.
    public ICollection<SubCategory> SubCategories { get; } = new List<SubCategory>();
}