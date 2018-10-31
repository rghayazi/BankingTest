namespace BankingApp.L0.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creationinitiale : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comptes",
                c => new
                    {
                        Numero = c.String(nullable: false, maxLength: 128),
                        Proprietaire = c.String(),
                        Solde = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Numero);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Comptes");
        }
    }
}
