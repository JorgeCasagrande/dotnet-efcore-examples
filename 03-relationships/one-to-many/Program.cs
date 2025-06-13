using System;
using System.Linq;
using OneToMany.Data;
using OneToMany.Models;

class Program
{
    static void Main()
    {
        using var db = new AppDbContext();

        // Ensure database is created
        db.Database.EnsureCreated();

        // Add a blog with posts
        var blog = new Blog
        {
            Name = "EF Core Blog",
            Posts = {
                new Post { Title = "First Post", Content = "Hello EF Core!" },
                new Post { Title = "Second Post", Content = "Relationships are easy." }
            }
        };
        db.Blogs.Add(blog);
        db.SaveChanges();

        // Query blogs with their posts
        var blogs = db.Blogs
            .Select(b => new { b.Name, Posts = b.Posts.Select(p => p.Title) })
            .ToList();

        foreach (var b in blogs)
        {
            Console.WriteLine($"Blog: {b.Name}");
            foreach (var postTitle in b.Posts)
                Console.WriteLine($"  - {postTitle}");
        }
    }
}
