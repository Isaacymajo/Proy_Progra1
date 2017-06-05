using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class Movimientos:Transaccion
    {
        public string InformacionCuenta { get; set; }
        public string DetalleSaldo { get; set; }

       
    }
}
