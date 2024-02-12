namespace Blogify.Entities;

public class Comment
{
    public string CommentId { get; set; }
    public string CommentatorId { get; set; }
    public User Commentator { get; set; }
    public string Content { get; set; }
    public string PostId { get; set; }
    public Post Post { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}