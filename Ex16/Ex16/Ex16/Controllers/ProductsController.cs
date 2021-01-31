using AutoMapper;
using Ex16.DTO;
using Ex16.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Ex16.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ProductsContext _productsContext;

        public ProductsController(IMapper mapper, ProductsContext productsContext)
        {
            _mapper = mapper;
            _productsContext = productsContext;
        }

        [HttpGet]
		public IActionResult GetAll()
		{
			var products = _productsContext.Products.ToList();
			return Ok(_mapper.Map<ProductDto[]>(products));
		}

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            var product = await _productsContext.Products.FindAsync(id);
            if (product == null)
            {
                return NoContent();
            }
            return Ok(_mapper.Map<ProductDto>(product));
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreate productCreate)
        {
            var newProduct = _mapper.Map<Product>(productCreate);
            newProduct.Id = _productsContext.Products.Max(i => i.Id) + 1;
            _productsContext.Products.Add(newProduct);
            await _productsContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new {id = newProduct.Id}, _mapper.Map<ProductDto>(newProduct));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ProductUpdate productUpdate)
        {
            var product = await _productsContext.Products.FindAsync(id);
            if (product == null)
            {
                return StatusCode(500);
            }
            _mapper.Map(productUpdate, product);
            await _productsContext.SaveChangesAsync();
            return Ok(_mapper.Map<ProductDto>(product));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productsContext.Products.FindAsync(id);
            if (product == null)
            {
                return NoContent();
            }
            _productsContext.Remove(product);
            await _productsContext.SaveChangesAsync();
            return Ok();
        }
    }
}
