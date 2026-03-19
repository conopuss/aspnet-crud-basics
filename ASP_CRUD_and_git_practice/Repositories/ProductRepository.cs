using ASP_CRUD_and_git_practice.Data;
using ASP_CRUD_and_git_practice.Models;

namespace ASP_CRUD_and_git_practice.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly ConnectionDB _context;
        public ProductRepository(ConnectionDB context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(Product product)
        {

            _context.Products.Remove(product); 
            _context.SaveChanges();
        }

        public void Edit(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public Product GetID(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
}
