using ASP_NET_Practice_withDB.DTOs;
namespace ASP_NET_Practice_withDB.Services
{
    public interface IProductService
    {
        List<ProductDto> GetProductDtos();
        void Create(ProductDto productDto);
        ProductDto GetID_Rep(int id);
        void Update(ProductDto productDto);
        void Delete(int id);

        List<ProductDto> OrderProducts();
        List<ProductDto> ExpensiveProducts();
        ProductDto MostExpensive();
        int ProductCount();
    }
}
