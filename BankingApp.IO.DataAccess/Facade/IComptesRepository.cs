using BankingApp.L0.DataAccess.Domain;
using System.Collections.Generic;

namespace BankingApp.L0.DataAccess.Facade
{
    public interface IComptesRepository
    {
        // CRUD Contract
        void Create(Compte compte);

        Compte FindById(string id);

        IEnumerable<Compte> FindAll();

        void Update(Compte compte);

        void Delete(string id);
    }
}
