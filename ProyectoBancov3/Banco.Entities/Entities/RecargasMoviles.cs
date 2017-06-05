using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class RecargasMoviles:Transaccion
    {
        public string Operador { get; set; }
        public decimal MontoRecarga { get; set; }
        public long NumeroMovil { get; set; }

       
    }
}
