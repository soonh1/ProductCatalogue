
using ProductCatalogue.Data;
using ProductCatalogue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Type = ProductCatalogue.Models.Type;

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
                
                new Product{Name="Carson", Color="Red", Descriptions="I have no idea what im doing", Price=49, Size=10},
                new Product{Name="Meredith", Color="Blue", Descriptions="I have an idea what im doing", Price=29, Size=20},
                new Product{Name="Arturo", Color="Yellow", Descriptions="??", Price=19, Size=30},
                new Product{Name="test", Color="Yellow", Descriptions="test", Price=19, Size=30}
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var types = new Type[]
            {
                new Type{ TypeID=100, Title="pants"},
                new Type{ TypeID=101, Title="top"}
            };

            context.Types.AddRange(types);
            context.SaveChanges();

            var genders = new Gender[]
            {
                new Gender{ ProductID=1, TypeID=100, Grade=Grade.A},
                new Gender{ ProductID=2, TypeID=101, Grade=Grade.A}
            };

            context.Genders.AddRange(genders);
            context.SaveChanges();
        }
    }
}
