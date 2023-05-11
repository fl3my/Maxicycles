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
    
    // One MaxicyclesUser to many BasketItems.
    public ICollection<BasketItem> BasketItem { get; } = new List<BasketItem>();
    
    // One Maxicycles User to many Comments.
    public ICollection<Comment> Comments { get; } = new List<Comment>();
    
    // One Maxicycles User to many Posts.
    public ICollection<Post> Posts { get; } = new List<Post>();
}