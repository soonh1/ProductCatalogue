using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductCatalogue.Models;
using Type = ProductCatalogue.Models.Type;

namespace ProductCatalogue.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext (DbContextOptions<ShopContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Women> Womens { get; set; }
        public DbSet<Men> Mens { get; set; }

        public DbSet<Kid> Kids { get; set; }
        public DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Women>().ToTable("Women");
            modelBuilder.Entity<Men>().ToTable("Men");
            modelBuilder.Entity<Kid>().ToTable("Kid");
            modelBuilder.Entity<Type>().ToTable("Type");
        }

    }
}
