using Microsoft.EntityFrameworkCore;
 
namespace pro_cat.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories {get;set;}
        public DbSet<Product> Products {get;set;}

    }
}