using Microsoft.EntityFrameworkCore;
namespace BankAccount.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}

        public DbSet<User> Users { get; set; }
        public DbSet<History> Histories { get; set; }
    }
}