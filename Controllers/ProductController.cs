using ASP_NET_Practice_withDB.Services;
using ASP_NET_Practice_withDB.DTOs;
using Microsoft.AspNetCore.Mvc;
using ASP_NET_Practice_withDB.ViewModel;

namespace ASP_NET_Practice_withDB.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
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
        public IActionResult Update(ProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return View(productDto);
            }
            _service.Update(productDto);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            
            _service.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Order()
        {
            var vm = new ProductModelView
            {
                OrderProducts = _service.OrderProducts(),
                ExpensiveProducts = _service.ExpensiveProducts(),
                MostExpensive = _service.MostExpensive(),
                ProductCount = _service.ProductCount(),
            };

            return View(vm);
        }
    }
}
