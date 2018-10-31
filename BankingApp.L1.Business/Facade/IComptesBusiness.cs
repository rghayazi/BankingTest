using BankingApp.L0.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L1.Business.Facade
{
    public interface IComptesBusiness
    {
        decimal? ConsulterSolde(string numero);

        IEnumerable<Compte> TousLesComptes();
    }
}
