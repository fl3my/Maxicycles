namespace Maxicycles.Models;

public class Product
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    
    // Many product to one subcategory.
    public int SubCategoryId { get; set; }
    public SubCategory? SubCategory { get; set; }
}