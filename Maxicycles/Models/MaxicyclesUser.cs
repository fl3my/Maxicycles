using Microsoft.AspNetCore.Identity;

namespace Maxicycles.Models;

public class MaxicyclesUser : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    
    // One user to one address.
    public Address? Address { get; set; }
}