using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entity;

namespace Shop.Domain
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
