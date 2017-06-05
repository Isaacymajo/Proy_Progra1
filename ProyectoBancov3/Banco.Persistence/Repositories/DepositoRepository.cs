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
    public class DepositoRepository : Repository<Deposito>, IDepositoRepository
    {
        public DepositoRepository(BancoDbContext context) : base(context)
        {
        }
    }
}
