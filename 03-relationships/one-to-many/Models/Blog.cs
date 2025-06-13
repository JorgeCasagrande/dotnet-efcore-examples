namespace OneToMany.Models;

public class Blog
{
    public int Id { get; set; }
    public string Name { get; set; } = "";

    // Navigation property: a blog has many posts
    public List<Post> Posts { get; set; } = new();
}