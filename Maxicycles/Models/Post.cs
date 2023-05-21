namespace Maxicycles.Models;

public class Post
{
    // Get and set the post id.
    public int Id { get; set; }

    // Get and set the post title.
    public string? Title { get; set; }

    // Get and set the post content.
    public string? Content { get; set; }

    // Get and set the post excerpt.
    public string? Excerpt { get; set; }

    // Get and set the uploaded at time.
    public DateTime UploadedAt { get; set; }

    // Get and set the author id.
    // Many post to one user.
    public string? MaxicyclesUserId { get; set; }
    public MaxicyclesUser? MaxicyclesUser { get; set; }

    // One post ot many comments.
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    // Get and set the image id.
    // Many Posts to one image.
    public int? ImageId { get; set; }
    public Image? Image { get; set; }
}