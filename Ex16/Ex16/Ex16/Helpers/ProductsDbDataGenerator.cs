using Ex16.Enums;
using Ex16.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Ex16.Helpers
{
    public static class ProductsDbDataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ProductsContext(serviceProvider.GetRequiredService<DbContextOptions<ProductsContext>>());
            if (context.Products.Any())
            {
                return;
            }

            context.Products.AddRange(
                new Product {Id = 1, Name = "Milk", Price = 1, Type = ProductType.Drink},
                new Product {Id = 2, Name = "Bread", Price = 2, Type = ProductType.Food},
                new Product {Id = 3, Name = "Soap", Price = 4, Type = ProductType.Other});

            context.SaveChanges();
        }
    }
}
