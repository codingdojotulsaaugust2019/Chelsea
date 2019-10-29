using Microsoft.EntityFrameworkCore;
 
namespace catProds.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Product> Products {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<Association> Associations {get;set;}
        public MyContext(DbContextOptions options) : base(options) { }
    }
}