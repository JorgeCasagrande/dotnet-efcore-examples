using Microsoft.EntityFrameworkCore;
using BasicCrud.Models;

namespace BasicCrud.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        // Use LocalDB (default for local development with Visual Studio)
        => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CrudDemoDb;Trusted_Connection=True;");
}