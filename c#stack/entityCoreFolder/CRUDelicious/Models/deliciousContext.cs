using Microsoft.EntityFrameworkCore;
 
namespace CRUDelicious.Models
{
    public class deliciousContext : DbContext
    {
        public deliciousContext(DbContextOptions options) : base(options) { }

        public DbSet<Dish> Dishes {get;set;}
    }
}
