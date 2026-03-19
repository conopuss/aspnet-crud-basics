using ASP_CRUD_and_git_practice.DTOs;
using ASP_CRUD_and_git_practice.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_CRUD_and_git_practice.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductApiController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var products = _service.GetProductDtos();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var productID = _service.GetID_Rep(id);
            return Ok(productID);
        }
        [HttpPost]
        public IActionResult Create([FromBody]ProductDto productDto)
        {
            _service.Create(productDto);
            return Created("", productDto);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,ProductDto productDto)
        {
            _service.Update(id, productDto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }

    }
}
