namespace Maxicycles.Models;

public class Comment
{
    public int Id { get; set; }

    public string? Content { get; set; }
    public DateTime UploadedAt { get; set; }
    
    // Many comment to one user.
    public string? MaxicyclesUserId { get; set; }
    public MaxicyclesUser? MaxicyclesUser { get; set; }
    
    // Many comment to one post.
    public int PostId { get; set; }
    public Post? Post { get; set; }
}