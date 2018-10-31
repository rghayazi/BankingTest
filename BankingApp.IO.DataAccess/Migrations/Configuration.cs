namespace BankingApp.L0.DataAccess.Migrations
{
    using BankingApp.L0.DataAccess.Domain;
    using BankingApp.L0.DataAccess.Infrastructure;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BankingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BankingContext context)
        {
            context.Comptes.AddOrUpdate(new Compte {Numero="C1000", Proprietaire="Rania", Solde=1000M });
            context.Comptes.AddOrUpdate(new Compte { Numero = "C2000", Proprietaire = "Seif", Solde = 2000M });
            context.Comptes.AddOrUpdate(new Compte { Numero = "C3000", Proprietaire = "Ahmed", Solde = 2000M });
        }
    }
}
