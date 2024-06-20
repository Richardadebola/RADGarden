// Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;
using RADGarden.Models;
using System.Collections.Generic;

namespace RADGarden.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {
            return View();
        }


        public IActionResult Shop()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Rose", Description = "plastic, Natural", Price = 9.99m, ImageUrl = "/image/rose.jpg", Category = "Flower", Stock = 100, Rating = 4.5, Dimensions = "10x10 cm", Weight = 0.1 },
                new Product { Id = 2, Name = "Tulip", Description = "plastic, Natural", Price = 7.99m, ImageUrl = "/image/tulip.jpg", Category = "Flower", Stock = 50, Rating = 4.0, Dimensions = "8x8 cm", Weight = 0.08 },
                new Product { Id = 3, Name = "Sunflower", Description = "Natural", Price = 5.99m, ImageUrl = "/image/sunflower.jpg", Category = "Flower", Stock = 75, Rating = 4.8, Dimensions = "15x15 cm", Weight = 0.2 },
                new Product { Id = 4, Name = "Daisy", Description = "plastic, Natural", Price = 3.99m, ImageUrl = "/image/daisy.jpg", Category = "Flower", Stock = 200, Rating = 4.3, Dimensions = "5x5 cm", Weight = 0.05 },
                new Product { Id = 5, Name = "Orchid", Description = "Plastic", Price = 15.99m, ImageUrl = "/image/orchid.jpg", Category = "Flower", Stock = 30, Rating = 4.9, Dimensions = "12x12 cm", Weight = 0.15 },
                new Product { Id = 6, Name = "Lily", Description = "Natural", Price = 8.99m, ImageUrl = "/image/lily.jpg", Category = "Flower", Stock = 60, Rating = 4.2, Dimensions = "10x10 cm", Weight = 0.1 },
                new Product { Id = 7, Name = "Marigold", Description = "Natural", Price = 4.99m, ImageUrl = "/image/marigold.jpg", Category = "Flower", Stock = 90, Rating = 4.1, Dimensions = "7x7 cm", Weight = 0.07 },
                new Product { Id = 8, Name = "Lavender", Description = "Natural", Price = 6.99m, ImageUrl = "/image/lavender.jpg", Category = "Herb", Stock = 120, Rating = 4.7, Dimensions = "10x15 cm", Weight = 0.12 },
                new Product { Id = 9, Name = "Carnation", Description = "", Price = 2.99m, ImageUrl = "/image/carnation.jpg", Category = "Flower", Stock = 150, Rating = 4.0, Dimensions = "6x6 cm", Weight = 0.06 },
                new Product { Id = 10, Name = "Chrysanthemum", Description = "Plastic", Price = 12.99m, ImageUrl = "/image/chrysanthemum.jpg", Category = "Flower", Stock = 40, Rating = 4.6, Dimensions = "10x12 cm", Weight = 0.14 }
            };

            return View(products);
        }
    }
}
public class HomeController : Controller
{
    // Existing actions...

    public IActionResult About()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    // Other actions...
}





