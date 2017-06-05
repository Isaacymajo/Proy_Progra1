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
    public class AperturaRepository : Repository<Apertura>, IAperturaRepository
    {
        public AperturaRepository(BancoDbContext context) : base(context)
        {
        }
    }
}
