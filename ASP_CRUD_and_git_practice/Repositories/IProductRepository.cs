using ASP_CRUD_and_git_practice.Models;

namespace ASP_CRUD_and_git_practice.Repositories
{
    public interface IProductRepository
    {
        List<Product>GetProducts();
        void Add(Product product);
        Product GetID(int id);
        void Edit(Product product);
        void Delete(Product product);
    }
}
