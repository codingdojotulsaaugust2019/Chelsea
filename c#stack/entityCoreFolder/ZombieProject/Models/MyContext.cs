using Microsoft.EntityFrameworkCore;

namespace ZombieProject.Models
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users {get;set;}
        public DbSet<Message> Messages {get;set;}
        public MyContext(DbContextOptions options) : base(options) { }
    }
}