using ASP_NET_Practice_withDB.Models;
using Microsoft.EntityFrameworkCore;
namespace ASP_NET_Practice_withDB.Data
{
    public class ConnectDB:DbContext
    {
        public ConnectDB(DbContextOptions<ConnectDB>options):base(options) 
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
