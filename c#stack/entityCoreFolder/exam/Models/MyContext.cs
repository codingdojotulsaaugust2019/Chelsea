using Microsoft.EntityFrameworkCore;
 
namespace exam.Models
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users {get;set;}
        public DbSet<Relationship> Relationships {get;set;}

        public MyContext(DbContextOptions options) : base(options) { }
    }
}