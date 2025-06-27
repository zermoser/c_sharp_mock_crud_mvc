using Microsoft.AspNetCore.Mvc;
using ProductApiMvc.Models;
using ProductApiMvc.Services;

namespace ProductApiMvc.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductsController(IProductService service) => _service = service;

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var prod = _service.Get(id);
            if (prod == null) return NotFound();
            return Ok(prod);
        }

        [HttpPost]
        public ActionResult<Product> Post(Product product)
        {
            var created = _service.Create(product);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Product product)
        {
            var existing = _service.Get(id);
            if (existing == null) return NotFound();
            _service.Update(id, product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _service.Get(id);
            if (existing == null) return NotFound();
            _service.Delete(id);
            return NoContent();
        }
    }
}