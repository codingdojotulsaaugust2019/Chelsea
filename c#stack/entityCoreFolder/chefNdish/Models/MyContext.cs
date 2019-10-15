using Microsoft.EntityFrameworkCore;
using chefNdish.Models;
 
namespace chefNdish.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Dish> Dishes {get;set;}
        public DbSet<Chef> Chefs {get;set;}

        public MyContext(DbContextOptions options) : base(options) { }
    }
}