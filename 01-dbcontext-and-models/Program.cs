using DbContextAndModels.Data;
using DbContextAndModels.Models;

Console.WriteLine("== EF Core: DbContext and Model Example ==");

// Create and configure the database if it doesn't exist
using var context = new AppDbContext();
context.Database.EnsureCreated(); // For learning only; use migrations in real projects

// Add a test product if database is empty
if (!context.Products.Any())
{
    context.Products.Add(new Product
    {
        Name = "Example Product",
        Price = 49.99M
    });

    context.SaveChanges();
    Console.WriteLine("Product added.");
}
else
{
    Console.WriteLine("Products already exist in the database.");
}

// Display all products
foreach (var product in context.Products)
{
    Console.WriteLine($"[{product.Id}] {product.Name} - ${product.Price}");
}
