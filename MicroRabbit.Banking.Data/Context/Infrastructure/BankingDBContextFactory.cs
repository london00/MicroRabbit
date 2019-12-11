using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDBContextFactory : IDesignTimeDbContextFactory<BankingDBContext>
    {
        public BankingDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BankingDBContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-5GIEO5J\\SQLEXPRESS;Database=BankingDB;Trusted_Connection=True;MultipleActiveResultSets=True");

            return new BankingDBContext(optionsBuilder.Options);
        }
    }
}
