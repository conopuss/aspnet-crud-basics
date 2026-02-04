using ASP_NET_Practice_withDB.Models;
namespace ASP_NET_Practice_withDB.Repositories
{
    public interface IProductRespository
    {
        List<Product> GetAll();
        void Add(Product product);
        Product GetID(int id);
        void Edit(Product product);
        void Delete(Product product);   
    }
}
