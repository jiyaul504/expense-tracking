using Microsoft.EntityFrameworkCore;

namespace expense_tracking.Models
{
    public class ApplicationDB: DbContext
    {
        public ApplicationDB(DbContextOptions options):base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
       public DbSet<Category> Categories { get; set; }
    }
}
