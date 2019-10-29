using Microsoft.EntityFrameworkCore;
 
namespace exam2.Models
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users {get;set;}
        public DbSet<Like> Likes {get;set;}
        public DbSet<Idea> Ideas {get;set;}
        public MyContext(DbContextOptions options) : base(options) { }
    }
}