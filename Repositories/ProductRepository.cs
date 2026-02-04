using ASP_NET_Practice_withDB.Models;
using ASP_NET_Practice_withDB.Data;
namespace ASP_NET_Practice_withDB.Repositories
{
    public class ProductRepository:IProductRespository
    {
        private readonly ConnectDB _context;
        public ProductRepository(ConnectDB context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public Product GetID(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public void Edit(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        public void Delete(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

    }
}
