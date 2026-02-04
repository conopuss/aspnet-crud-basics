using ASP_NET_Practice_withDB.Repositories;
using ASP_NET_Practice_withDB.Models;
using ASP_NET_Practice_withDB.DTOs;
namespace ASP_NET_Practice_withDB.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRespository _respository;
        public ProductService(IProductRespository respository)
        {
            _respository = respository;
        }

        public List<ProductDto>GetProductDtos()
        {
            var products = _respository.GetAll();
            return products.Select(p=> new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                SalePrice = p.SalePrice
            }).ToList();
        }

        public void Create(ProductDto productDto)
        {
            var products = new Product
            {
                Name = productDto.Name,
                SalePrice = productDto.SalePrice,
            };
            _respository.Add(products);
        }

        public ProductDto GetID_Rep(int id)
        {
            var productID = _respository.GetID(id);
            if (productID == null) return null;
            return new ProductDto
            {
                Id = productID.Id,
                Name = productID.Name,
                SalePrice = productID.SalePrice,
            };
        }
        public void Update(ProductDto productDto)
        {
            var productID = _respository.GetID(productDto.Id);
            productID.Id = productDto.Id;
            productID.Name = productDto.Name;
            productID.SalePrice = productDto.SalePrice;
            _respository.Edit(productID);

        }
        public void Delete(int id)
        {
            var productID = _respository.GetID(id);
            _respository.Delete(productID);
        }

        public List<ProductDto> OrderProducts()
        {
            var products = _respository.GetAll();
            if (products == null) return null;
            return products.OrderByDescending(p=> p.SalePrice).Select(p=> new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                SalePrice = p.SalePrice,
            }).ToList();
        }
        public List<ProductDto> ExpensiveProducts()
        {
            var products = _respository.GetAll();
            if (products == null) return null;
            return products.Where(p => p.SalePrice > 55000).Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                SalePrice = p.SalePrice,
            }).ToList();
        }
        public ProductDto MostExpensive()
        {
            var product = _respository.GetAll().OrderByDescending(p => p.SalePrice).FirstOrDefault();
            if (product == null) return null;
            return new ProductDto
            {
                Id = product.Id,
                Name= product.Name,
                SalePrice = product.SalePrice,
            };
        }
        public int ProductCount()
        {
            return _respository.GetAll().Count();
        }
    }
}
