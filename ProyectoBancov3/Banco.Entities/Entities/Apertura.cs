using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class Apertura:Transaccion
    {
        public double Tasa { get; set; }
        public string TipoTarjeta { get; set; }
        public long Saldo { get; set; }
        public DateTime FechaEntrega { get; set; }

       
    }
}
