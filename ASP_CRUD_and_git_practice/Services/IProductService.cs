using ASP_CRUD_and_git_practice.DTOs;

namespace ASP_CRUD_and_git_practice.Services
{
    public interface IProductService
    {
        List<ProductDto> GetProductDtos();
        void Create(ProductDto product);
        ProductDto GetID_Rep(int id);
        void Update(int id,ProductDto product);
        void Delete(int id);
        List<ProductDto> OrderProducts();
        List<ProductDto> ExpensiveProducts();
        ProductDto MostExpensive();
        int ProductCount();
    }
}
