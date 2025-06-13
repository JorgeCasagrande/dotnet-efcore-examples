namespace OneToMany.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";

    // Foreign key
    public int BlogId { get; set; }

    // Navigation property: each post belongs to one blog
    public Blog? Blog { get; set; }
}