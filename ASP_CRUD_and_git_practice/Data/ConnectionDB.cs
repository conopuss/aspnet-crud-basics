using ASP_CRUD_and_git_practice.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_CRUD_and_git_practice.Data
{
    public class ConnectionDB:DbContext
    {
        public ConnectionDB(DbContextOptions<ConnectionDB>options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
