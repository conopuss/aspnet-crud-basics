using ASP_CRUD_and_git_practice.DTOs;
using ASP_CRUD_and_git_practice.Services;
using ASP_CRUD_and_git_practice.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ASP_CRUD_and_git_practice.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        private readonly ILogger<ProductController> _logger;
        public ProductController(IProductService service, ILogger<ProductController> logger)
        {
            _logger = logger;
            _service = service;
        }
        public IActionResult Index()
        {
            var products = _service.GetProductDtos();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid product data entered.");
                return View(productDto);
            }
            _service.Create(productDto);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var productID = _service.GetID_Rep(id);
            return View(productID);
        }

        [HttpPost]
        public IActionResult Update(int id, ProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid product update data entering attempt. ");
                return View(productDto);
            }

            _service.Update(id, productDto);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Order()
        {
            var VM = new ProductViewModel
            {
                OrderProducts = _service.OrderProducts(),
                ExpensiveProducts = _service.ExpensiveProducts(),
                MostExpensive = _service.MostExpensive(),
                ProductCount = _service.ProductCount(),
            };
            return View(VM);
        }
    }
}
