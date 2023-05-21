using Microsoft.AspNetCore.Identity;

namespace Maxicycles.Models;

// This class inherits from the Identity user class from identity framework.
public class MaxicyclesUser : IdentityUser
{
    // Get and set the First name.
    public string? FirstName { get; set; }

    // Get and set the lastname.
    public string? LastName { get; set; }

    // Get and set the address line 1.
    public string? AddressLine1 { get; set; }

    // Get and set the address line 2.
    public string? AddressLine2 { get; set; }

    // Get and set the city.
    public string? City { get; set; }

    // Get and set the postcode.
    public string? Postcode { get; set; }

    // One MaxicyclesUser to many BasketItems.
    public ICollection<BasketItem> BasketItem { get; } = new List<BasketItem>();

    // One Maxicycles User to many Comments.
    public ICollection<Comment> Comments { get; } = new List<Comment>();

    // One Maxicycles User to many Posts.
    public ICollection<Post> Posts { get; } = new List<Post>();
}