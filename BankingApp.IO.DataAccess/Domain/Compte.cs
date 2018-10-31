using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.L0.DataAccess.Domain
{
    //[Table(name)]
    // to enable migration do:
    // Tools > Package Manager Console
    // PM> Enable-Migrations
    // PM> Add-Migration "Creation initiale"
    // implement Seed method
    // PM> Update-Database
    public class Compte
    {
        [Key]
        public string Numero { get; set; }

        public string Proprietaire { get; set; }

        public decimal Solde { get; set; }

        public void Debiter(decimal montant)
        {
            Solde += montant;
        }

        public void Crediter(decimal montant)
        {
            Solde -= montant;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Compte cpt = obj as Compte;
            return this.Numero.Equals(cpt.Numero);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return Numero.GetHashCode();
        }
    }
}
