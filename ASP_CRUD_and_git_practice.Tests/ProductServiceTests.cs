using ASP_CRUD_and_git_practice.Repositories;
using ASP_CRUD_and_git_practice.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace ASP_CRUD_and_git_practice.Tests
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetProduct_ShouldReturnProduct()
        {
            //Arrange
            IProductRepository repository = new FakeProductRepository();
            ILogger<ProductService> logger = NullLogger<ProductService>.Instance;
            var service = new ProductService(repository, logger);

            //Act

            var result = service.GetProductDtos();

            //Assert

            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal(1, result[0].Id);
            Assert.Equal(2000, result[0].SalePrice);
        }
    }
}