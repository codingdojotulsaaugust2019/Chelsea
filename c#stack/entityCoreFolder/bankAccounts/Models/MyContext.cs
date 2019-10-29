using Microsoft.EntityFrameworkCore;
 
namespace bankAccounts.Models
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users {get;set;}
        public DbSet<Transaction> Transactions {get;set;}
                public MyContext(DbContextOptions options) : base(options) { }
    }
}