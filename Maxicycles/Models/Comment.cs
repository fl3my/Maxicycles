namespace Maxicycles.Models;

public class Comment
{
    // Get add set the Comment ID.
    public int Id { get; set; }

    // Get add set the comment content.
    public string? Content { get; set; }

    // Get add set the upload date.
    public DateTime UploadedAt { get; set; }

    // Get and set the userID.
    // Many comment to one user.
    public string? MaxicyclesUserId { get; set; }
    public MaxicyclesUser? MaxicyclesUser { get; set; }

    // Get and set the parent post ID.
    // Many comment to one post.
    public int PostId { get; set; }
    public Post? Post { get; set; }
}