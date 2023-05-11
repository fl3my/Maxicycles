namespace Maxicycles.Models;

public class Post
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime UploadedAt { get; set; }
    
    // Many post to one user.
    public string? MaxicyclesUserId { get; set; }
    public MaxicyclesUser? MaxicyclesUser { get; set; }

    // One post ot many comments.
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}