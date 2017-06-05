using Banco.Entities;
using Banco.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Banco.Persistence.Repositories
{
    public class ClienteRepository : Repository<PJuridica>, IClienteRepository

    {
        private readonly BancoDbContext _Context;
        public ClienteRepository(BancoDbContext context) : base(context)
        {
            _Context = context;
        }
         public IEnumerable<PJuridica> GetAllPersonaNatural()
        {
            return _Context.Set<PJuridica>().ToList();
        }
        public IEnumerable<PJuridica> GetAllPersonaJuridca()
        {
            return _Context.Set<PJuridica>().ToList();
        }

        void AddPersonaJuridica(PJuridica entity)
        {
            //Aqui se debe modificar la consulta para agregar el valor de discrimador 
            //para persona juridica
            _Context.Set<PJuridica>().Add(entity);
        }
    }
}
