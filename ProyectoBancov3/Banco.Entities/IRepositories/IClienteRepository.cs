using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities.IRepositories
{
    public interface IClienteRepository : IRepository<PJuridica>
    {
        IEnumerable<PJuridica> GetAllPersonaNatural();
        IEnumerable<PJuridica> GetAllPersonaJuridca();

        void AddPersonaJuridica(PJuridica entity);

    }
}
