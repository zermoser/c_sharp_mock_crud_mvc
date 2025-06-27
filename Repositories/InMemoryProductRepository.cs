using ProductApiMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductApiMvc.Repositories
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Prod1", Price = 10M },
            new Product { Id = 2, Name = "Prod2", Price = 20M }
        };

        public Product Add(Product product)
        {
            product.Id = _products.Any() ? _products.Max(p => p.Id) + 1 : 1;
            _products.Add(product);
            return product;
        }

        public void Delete(int id)
        {
            var p = _products.FirstOrDefault(x => x.Id == id);
            if (p != null) _products.Remove(p);
        }

        public IEnumerable<Product> GetAll() => _products;

        public Product? GetById(int id) => _products.FirstOrDefault(x => x.Id == id);

        public void Update(Product product)
        {
            var existing = _products.FirstOrDefault(x => x.Id == product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
            }
        }
    }
}