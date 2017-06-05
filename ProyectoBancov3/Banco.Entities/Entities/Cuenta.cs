using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class Cuenta:Transaccion
    {
        public long NumeroCuenta { get; set; }
        public decimal SaldoDisponible { get; set; }
        public decimal SaldoTotal { get; set; }

        public virtual TipoCuenta TipoCuenta { get; set; }

        public virtual int TipoCuentaId { get; set; }
    }
}
