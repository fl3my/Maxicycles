namespace Maxicycles.Models;

// This class inherits from the parent payment class. 
public class ExternalPayment : Payment
{
    // Get and set the external payment title.
    public string? Title { get; set; }
}