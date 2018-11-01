namespace ScaffoldedBanking.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BankingModel : DbContext
    {
        public BankingModel()
            : base("name=BankingModel")
        {
        }

        public virtual DbSet<Compte> Comptes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
