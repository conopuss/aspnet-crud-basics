using ASP_NET_Practice_withDB.DTOs;

namespace ASP_NET_Practice_withDB.ViewModel
{
    public class ProductModelView
    {
        public List<ProductDto> OrderProducts { get; set; }
        public List<ProductDto> ExpensiveProducts { get; set; }
        public ProductDto MostExpensive {  get; set; }  
        public int ProductCount { get; set; }
    }
}
