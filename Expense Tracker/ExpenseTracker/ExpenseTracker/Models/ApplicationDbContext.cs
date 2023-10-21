using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models
{
    public class ApplicationDbContext:DbContext //Main Db classından inheritledim
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {}

        public DbSet<transaction>Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
