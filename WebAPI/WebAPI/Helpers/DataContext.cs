using Microsoft.EntityFrameworkCore;
using WebAPI.Entities;

namespace WebAPI.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
          : base(options)
        {

        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
