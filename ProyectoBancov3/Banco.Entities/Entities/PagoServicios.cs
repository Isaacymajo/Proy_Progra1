using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class PagoServicios:Transaccion
    {
        public decimal Deuda { get; set; }
        public long CuentaCargo { get; set; }
        public string Empresa { get; set; }

        
    }
}
