using Microsoft.EntityFrameworkCore;

namespace CodeFirst_Core.DBContext
{
    public class SalesDBContext : DbContext
    {
        public SalesDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<SalesProducts> salesProducts { get; set; }
    }
}
