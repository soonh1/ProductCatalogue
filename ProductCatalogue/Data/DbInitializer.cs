
using ProductCatalogue.Data;
using ProductCatalogue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogue.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Product[]
            {
                
                new Product{Name="Carson", Color="Red", Descriptions="I have no idea what im doing", Gender="Men", Price=49, Size=10, Type="Pants"},
                new Product{Name="Meredith", Color="Blue", Descriptions="I have an idea what im doing", Gender="Women", Price=29, Size=20, Type="Top"},
                new Product{Name="Arturo", Color="Yellow", Descriptions="??", Gender="Kid", Price=19, Size=30, Type="Hoodie"}
            };

            context.Products.AddRange(products);
            context.SaveChanges();

        }
    }
}
