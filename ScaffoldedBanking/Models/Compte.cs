namespace ScaffoldedBanking.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Compte
    {
        [Key]
        public string Numero { get; set; }

        public string Proprietaire { get; set; }

        public decimal Solde { get; set; }
    }
}
