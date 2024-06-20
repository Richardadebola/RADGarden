using System.Collections.Generic;
using RADGarden.Models;

namespace RADGarden.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Name = "Rose", Description = "Beautiful red roses", Price = 19.99m },
                new Product { Name = "Tulip", Description = "Elegant tulips", Price = 14.99m },
                new Product { Name = "Sunflower", Description = "Bright sunflowers", Price = 9.99m },
                new Product { Name = "Orchid", Description = "Exotic orchids", Price = 29.99m },
                new Product { Name = "Daisy", Description = "Cheerful daisies", Price = 12.99m },
                new Product { Name = "Lily", Description = "Fragrant lilies", Price = 25.99m },
                new Product { Name = "Lavender", Description = "Soothing lavender", Price = 15.99m },
                new Product { Name = "Chrysanthemum", Description = "Vibrant chrysanthemums", Price = 18.99m },
                new Product { Name = "Peony", Description = "Luxurious peonies", Price = 24.99m },
                new Product { Name = "Begonia", Description = "Colorful begonias", Price = 17.99m }
            };
        }
    }
}
