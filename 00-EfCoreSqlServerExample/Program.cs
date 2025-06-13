using EfCoreSqlServerExample.Data;
using EfCoreSqlServerExample.Models;

Console.WriteLine("== EF Core + SQL Server LocalDB Example ==");

using var context = new AppDbContext();

// Crea la base de datos si no existe (recomendado solo para pruebas rápidas)
context.Database.EnsureCreated();

// Inserta productos solo si aún no hay registros
if (!context.Products.Any())
{
    context.Products.AddRange(
        new Product { Name = "Mouse", Price = 15.99M },
        new Product { Name = "Keyboard", Price = 39.99M },
        new Product { Name = "Monitor", Price = 129.50M }
    );
    context.SaveChanges();
    Console.WriteLine("Productos insertados.");
}
else
{
    Console.WriteLine("Ya existen productos en la base de datos.");
}

// Mostrar todos los productos
Console.WriteLine("\n== Lista de productos ==");
foreach (var product in context.Products)
{
    Console.WriteLine($"[{product.Id}] {product.Name} - ${product.Price}");
}
