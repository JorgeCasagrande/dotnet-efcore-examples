using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BasicCrud.Models;
using BasicCrud.Data;

// This static class demonstrates how to add a new product to the database.
public static class AddExample
{
    // Adds a new Product and saves changes asynchronously.
    public static async Task<Product> AddProductAsync(AppDbContext db)
    {
        var product = new Product { Name = "Laptop", Price = 1200m };
        db.Products.Add(product);
        await db.SaveChangesAsync();
        Console.WriteLine($"[CREATE] Added: {product.Name} (${product.Price})");
        return product;
    }
}

// This static class demonstrates how to read products from the database.
public static class GetExample
{
    // Retrieves all products and prints them to the console.
    public static async Task<List<Product>> GetAllProductsAsync(AppDbContext db)
    {
        var products = await db.Products.ToListAsync();
        Console.WriteLine("[READ] All products:");
        foreach (var p in products)
            Console.WriteLine($"- {p.Name} (${p.Price})");
        return products;
    }
}

// This static class demonstrates how to update an existing product.
public static class UpdateExample
{
    // Updates the price of a product identified by its ID.
    public static async Task UpdateProductAsync(AppDbContext db, int id)
    {
        var product = await db.Products.FindAsync(id);
        if (product != null)
        {
            product.Price = 999m;
            await db.SaveChangesAsync();
            Console.WriteLine($"[UPDATE] Updated: {product.Name} now costs ${product.Price}");
        }
    }
}

// This static class demonstrates how to delete a product from the database.
public static class DeleteExample
{
    // Deletes a product identified by its ID.
    public static async Task DeleteProductAsync(AppDbContext db, int id)
    {
        var product = await db.Products.FindAsync(id);
        if (product != null)
        {
            db.Products.Remove(product);
            await db.SaveChangesAsync();
            Console.WriteLine($"[DELETE] Deleted: {product.Name}");
        }
    }
}

// Entry point of the application. Demonstrates the full CRUD cycle.
class Program
{
    static async Task Main()
    {
        using var db = new AppDbContext();

        // CREATE: Add a new product
        var product = await AddExample.AddProductAsync(db);

        // READ: List all products
        await GetExample.GetAllProductsAsync(db);

        // UPDATE: Update the product's price
        await UpdateExample.UpdateProductAsync(db, product.Id);

        // DELETE: Remove the product
        await DeleteExample.DeleteProductAsync(db, product.Id);

        // Confirm deletion by counting products
        int count = await db.Products.CountAsync();
        Console.WriteLine($"Products in database: {count}");
    }
}
