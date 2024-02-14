using Microsoft.EntityFrameworkCore;
using PrimaryKey_vs_UniqueKey;
using System.Collections.Generic;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        using (var dbContext = new AppDbContext())//instace of context
        {
           
            dbContext.Database.EnsureCreated();//ensure database created

            // Add some products
            dbContext.Products.AddRange(
                new Product { Name = "Product A", Category = "Category 1" },
                new Product { Name = "Product B", Category = "Category 2" },
                new Product { Name = "Product C", Category = "Category 1" }
            );

            // Try to add a product with a duplicate name (should fail due to unique key constraint)
            try
            {
                dbContext.Products.Add(new Product { Name = "Product A", Category = "Category 3" });
                dbContext.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Failed to add product: {ex.Message}");
            }

            // Save changes
            dbContext.SaveChanges();

            // Query all products
            var products = dbContext.Products.ToList();
            Console.WriteLine("All Products:");
            foreach (var product in products)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Category: {product.Category}");
            }
        }
    }
}
