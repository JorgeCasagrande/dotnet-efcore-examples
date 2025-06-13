using System;
using System.Linq;
using ManyToMany.Data;
using ManyToMany.Models;

class Program
{
    static void Main()
    {
        using var db = new AppDbContext();

        // Ensure database is created
        db.Database.EnsureCreated();

        // Add students and courses with many-to-many relationship
        var math = new Course { Title = "Mathematics" };
        var history = new Course { Title = "History" };

        var alice = new Student { Name = "Alice", Courses = { math, history } };
        var bob = new Student { Name = "Bob", Courses = { math } };

        db.Students.AddRange(alice, bob);
        db.SaveChanges();

        // Query students with their courses
        var students = db.Students
            .Select(s => new { s.Name, Courses = s.Courses.Select(c => c.Title) })
            .ToList();

        foreach (var s in students)
        {
            Console.WriteLine($"Student: {s.Name}");
            foreach (var courseTitle in s.Courses)
                Console.WriteLine($"  - {courseTitle}");
        }
    }
}
