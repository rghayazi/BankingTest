using System.Collections.Generic;
using System.Linq;
using BankingApp.L0.DataAccess.Domain;
using BankingApp.L0.DataAccess.Facade;
using BankingApp.L0.DataAccess.Infrastructure;

namespace BankingApp.L0.DataAccess.Implementation
{
    public class ComptesRepositoryImpl_EF : IComptesRepository
    {
        public void Create(Compte compte)
        {
            using (BankingContext context = new BankingContext())
            {
                context.Comptes.Add(compte);
                context.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            using (BankingContext context = new BankingContext())
            {
                Compte c = context.Comptes.Find(id);
                context.Comptes.Remove(c);
                context.SaveChanges();
            }
        }

        public IEnumerable<Compte> FindAll()
        {
            IEnumerable<Compte> comptes;
            using (BankingContext context = new BankingContext())
            {
                comptes = context.Comptes.ToList();
            }

            return comptes;
        }

        public Compte FindById(string id)
        {
            Compte compte;
            using (BankingContext context = new BankingContext())
            {
                compte = context.Comptes.Find(id);
            }

            return compte;
        }

        public void Update(Compte compte)
        {
            throw new System.NotImplementedException();
        }
    }
}
