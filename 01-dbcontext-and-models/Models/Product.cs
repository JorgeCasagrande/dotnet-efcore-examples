namespace DbContextAndModels.Models;

/// <summary>
/// Product model that will be mapped to a database table.
/// </summary>
public class Product
{
    /// <summary>
    /// Primary key (auto-incremented).
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the product.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Price of the product.
    /// </summary>
    public decimal Price { get; set; }
}
