using ASP_CRUD_and_git_practice.DTOs;

namespace ASP_CRUD_and_git_practice.ViewModel
{
    public class ProductViewModel
    {
        public List<ProductDto> OrderProducts { get; set; }
        public List<ProductDto> ExpensiveProducts { get; set; }
        public ProductDto MostExpensive { get; set; }
        public int ProductCount { get; set; }
    }
}
