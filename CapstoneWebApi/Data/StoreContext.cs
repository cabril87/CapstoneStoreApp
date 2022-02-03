using CapstoneWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CapstoneWebApi.Data
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
