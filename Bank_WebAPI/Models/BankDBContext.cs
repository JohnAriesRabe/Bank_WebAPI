using Microsoft.EntityFrameworkCore;

namespace Bank_WebAPI.Models
{
    public class BankDBContext: DbContext
    {
        public BankDBContext(DbContextOptions<BankDBContext> options) : base(options)
        {

        }
        public DbSet<TransferRequest> _TransferRequest { get; set; }
        public DbSet<DepositRequest> _DepositRequest { get; set; }
        public DbSet<WithdrawRequest> _WithdrawRequest { get; set; }
        public DbSet<User> _User { get; set; }
    }
}
