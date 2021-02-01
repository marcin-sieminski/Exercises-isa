using Ex8.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ex8.Services
{
    public class ProductsService : IProductsService
    {
        private static readonly IList<Product> _products = new List<Product>
        {
            new Product {Id = 1, Name = "Playstation 4", Description = "Buy this, ignore the rest.", Price = 299.99},
            new Product {Id = 2, Name = "Xbox One", Description = "No one cares.", Price = 999.99},
            new Product {Id = 3, Name = "Nintendo Switch", Description = "Some day...", Price = 319.99}
        };

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(product => product.Id == id);
        }

        public bool DeleteById(int id)
        {
            return _products.Remove(GetById(id));
        }

        public bool Update(int id, Product product)
        {
            var currentProduct = GetById(id);
            currentProduct.Name = product.Name;
            currentProduct.Description = product.Description;
            currentProduct.Price = product.Price;
            return true;
        }

        public Product Create(Product newProduct)
        {
            newProduct.Id = _products.Max(product => product.Id) + 1;
            _products.Add(newProduct);
            return newProduct;
        }
    }
}
