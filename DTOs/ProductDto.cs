
using System.ComponentModel.DataAnnotations;

namespace ASP_NET_Practice_withDB.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Product name is required")]
        [StringLength(50, MinimumLength =2)]
        public string Name { get; set; }

        [Range(0,200000)]
        public decimal SalePrice { get; set; }
    }
}
