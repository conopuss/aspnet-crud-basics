using ASP_CRUD_and_git_practice.DTOs;
using ASP_CRUD_and_git_practice.Models;
using ASP_CRUD_and_git_practice.Repositories;

namespace ASP_CRUD_and_git_practice.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _repository;
        private readonly ILogger<ProductService> _logger;
        public ProductService(IProductRepository repository, ILogger<ProductService> logger )
        {
            _repository = repository;
            _logger = logger;
        }

        public void Create(ProductDto productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                SalePrice = productDto.SalePrice,
            };
            _logger.LogInformation("Creating product");
            _repository.Add(product);
        }

        public void Delete(int id)
        {
            var productID = _repository.GetID(id);
            _logger.LogInformation("Deleting product with id {productID}", id);
            _repository.Delete(productID);
        }

        public List<ProductDto> ExpensiveProducts()
        {
            var products = _repository.GetProducts();
            return products.Where(p=> p.SalePrice > 55000).Select(p=> new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                SalePrice = p.SalePrice,
            }).ToList();
        }

        public ProductDto GetID_Rep(int id)
        {
            var productID = _repository.GetID(id);
            return new ProductDto
            {
                Id = productID.Id,
                Name = productID.Name,
                SalePrice = productID.SalePrice,
            };
        }

        public List<ProductDto> GetProductDtos()
        {
            var products = _repository.GetProducts();
            return products.Select(p=> new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                SalePrice = p.SalePrice,
            }).ToList();
        }

        public ProductDto MostExpensive()
        {
            var productID = _repository.GetProducts().OrderByDescending(p => p.SalePrice).FirstOrDefault();
            return new ProductDto
            {
                Id = productID.Id,
                Name = productID.Name,
                SalePrice = productID.SalePrice,
            };
        }

        public List<ProductDto> OrderProducts()
        {
            var products = _repository.GetProducts();
            return products.OrderByDescending(p=> p.SalePrice).Select(p=> new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                SalePrice = p.SalePrice,
            }).ToList();
        }

        public int ProductCount()
        {
            return _repository.GetProducts().Count();
        }

        public void Update(int id, ProductDto product)
        {
            var productID = _repository.GetID(id);
            productID.Name = product.Name;
            productID.SalePrice = product.SalePrice;

            _logger.LogInformation("Updating product with id {productID}", id);
            _repository.Edit(productID);
        }
    }
}
