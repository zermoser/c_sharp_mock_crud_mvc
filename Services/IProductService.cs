using ProductApiMvc.Models;
using System.Collections.Generic;

namespace ProductApiMvc.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product? Get(int id);
        Product Create(Product product);
        void Update(int id, Product product);
        void Delete(int id);
    }
}