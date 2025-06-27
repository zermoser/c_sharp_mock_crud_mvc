using ProductApiMvc.Models;
using ProductApiMvc.Repositories;
using System.Collections.Generic;

namespace ProductApiMvc.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo) => _repo = repo;

        public Product Create(Product product) => _repo.Add(product);

        public void Delete(int id) => _repo.Delete(id);

        public IEnumerable<Product> GetAll() => _repo.GetAll();

        public Product? Get(int id) => _repo.GetById(id);

        public void Update(int id, Product product)
        {
            product.Id = id;
            _repo.Update(product);
        }
    }
}