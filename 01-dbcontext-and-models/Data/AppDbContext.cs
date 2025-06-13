using DbContextAndModels.Models;
using Microsoft.EntityFrameworkCore;

namespace DbContextAndModels.Data;

/// <summary>
/// Application DbContext that manages database access.
/// </summary>
public class AppDbContext : DbContext
{
    /// <summary>
    /// Represents the Products table.
    /// </summary>
    public DbSet<Product> Products => Set<Product>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Using LocalDB for development.
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\mssqllocaldb;Database=EfCoreExamplesDb;Trusted_Connection=True;");
    }
}
