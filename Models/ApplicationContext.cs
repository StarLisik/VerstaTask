using Microsoft.EntityFrameworkCore;

namespace VestaTask.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<OrderModel> Orders => Set<OrderModel>();
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }
    }
}
