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
    public class TercerosRepository : Repository<Terceros>, ITercerosRepository
    {
        public TercerosRepository(BancoDbContext context) : base(context)
        {
        }
    }
}
