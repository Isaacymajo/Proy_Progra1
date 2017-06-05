using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class Deposito:Transaccion
    {
        public long CuentaDestino { get; set; }
        public decimal Monto { get; set; }

       
    }
}
