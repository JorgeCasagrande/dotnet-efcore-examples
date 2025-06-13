namespace ManyToMany.Models;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = "";

    // Navigation property: a course can have many students
    public List<Student> Students { get; set; } = new();
}