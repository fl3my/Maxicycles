namespace Maxicycles.Models;

public class Card : Payment
{
    public string? Name { get; set; }
    public string? LongNumber { get; set; }
    public string? Cvv { get; set; }
    public DateTime ExpiryDate { get; set; }
}