namespace Maxicycles.Models;

public class Card : Payment
{
    public string? Name { get; set; }
    public string? LongNumber { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? City { get; set; }
    public string? Postcode { get; set; }
}