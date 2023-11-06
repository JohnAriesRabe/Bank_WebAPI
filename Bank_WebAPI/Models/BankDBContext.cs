using Microsoft.EntityFrameworkCore;

namespace Bank_WebAPI.Models
{
    public class BankDBContext: DbContext
    {
        public BankDBContext(DbContextOptions<BankDBContext> options) : base(options)
        {

        }
        public DbSet<b_user> b_Users { get; set; }
        public DbSet<b_savings> b_Savings { get; set; }
        public DbSet<b_transaction> b_Transactions { get; set; }
    }
}
