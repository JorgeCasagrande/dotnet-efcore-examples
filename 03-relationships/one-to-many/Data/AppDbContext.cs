using Microsoft.EntityFrameworkCore;
using OneToMany.Models;

namespace OneToMany.Data;

public class AppDbContext : DbContext
{
    public DbSet<Blog> Blogs => Set<Blog>();
    public DbSet<Post> Posts => Set<Post>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
         // Use SQL Server LocalDB for local development
        => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OneToManyDemoDb;Trusted_Connection=True;");
}