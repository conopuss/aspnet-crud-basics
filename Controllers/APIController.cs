using ASP_NET_Practice_withDB.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Practice_withDB.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class APIController : ControllerBase
    {
        private readonly IProductService _service;
        public APIController(IProductService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var products = _service.GetProductDtos();
            return Ok(products);
        }
    }
}
