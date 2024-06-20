// Models/Product.cs
namespace RADGarden.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } // Image URL
        public string Category { get; set; } // New property
        public int Stock { get; set; } // New property
        public double Rating { get; set; } // New property
        public string Dimensions { get; set; } // New property
        public double Weight { get; set; } // New property
    }
}
