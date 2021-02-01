using Ex8.Models;
using System.Collections.Generic;

namespace Ex8.Services
{
    public interface IProductsService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        bool DeleteById(int id);
        bool Update(int id, Product product);
        Product Create(Product newProduct);
    }
}
