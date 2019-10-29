using weddingPlanner.Models;
using Microsoft.EntityFrameworkCore;


namespace weddingPlanner.Models
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users {get;set;}
        public DbSet<Guest> Guests {get;set;}
        public DbSet<Wedding> Weddings {get;set;}
        public MyContext(DbContextOptions options) : base(options) { }
    }
}