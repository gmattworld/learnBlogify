using Blogify.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blogify.Persistence;

public class AppDBContext: DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
    {
    }
    
    
    public DbSet<Post> Posts { get; set; } 
    public DbSet<Tag> Tags { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Category> Categories { get; set; }
}