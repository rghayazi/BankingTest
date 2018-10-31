using BankingApp.L0.DataAccess.Domain;
using System.Data.Entity;

namespace BankingApp.L0.DataAccess.Infrastructure
{
    public class BankingContext : DbContext
    {
        public BankingContext() : base("name=bankingdb")
        {
        }

        public virtual DbSet<Compte> Comptes { get; set; }
    }
}
