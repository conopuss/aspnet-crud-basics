using ASP_CRUD_and_git_practice.Models;
using ASP_CRUD_and_git_practice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_CRUD_and_git_practice.Tests
{
    public class FakeProductRepository : IProductRepository
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public void Edit(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Test Product",
                    SalePrice = 2000
                }
            };
        }
    }
}
