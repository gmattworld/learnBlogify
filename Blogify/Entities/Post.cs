using Blogify.Enums;

namespace Blogify.Entities;

public class Post
{
    public string PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string AuthorId { get; set; }
    public User Author { get; set; }
    public PostStatus Status { get; set; } 
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}