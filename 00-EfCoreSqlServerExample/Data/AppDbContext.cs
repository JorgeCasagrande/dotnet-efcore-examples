using EfCoreSqlServerExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreSqlServerExample.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\mssqllocaldb;Database=EfCoreTestDb;Trusted_Connection=True;");
    }
}
