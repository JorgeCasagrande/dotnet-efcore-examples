namespace ManyToMany.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";

    // Navigation property: a student can enroll in many courses
    public List<Course> Courses { get; set; } = new();
}