using Microsoft.AspNetCore.Identity;

namespace Maxicycles.Models;

public class MaxicyclesUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; } 
    public string? City { get; set; }
    public string? Postcode { get; set; }
}