using Microsoft.EntityFrameworkCore;
using ManyToMany.Models;

namespace ManyToMany.Data;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Course> Courses => Set<Course>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        // Use SQL Server LocalDB for local development
        => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ManyToManyDemoDb;Trusted_Connection=True;");
}