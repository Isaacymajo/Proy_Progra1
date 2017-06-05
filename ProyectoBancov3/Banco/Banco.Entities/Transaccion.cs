using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
   public abstract class Transaccion
    {
        public int TransaccionId { get; set; }
        public int CodigoSeguimiento { get; set; }
        public DateTime Fecha { get; set; }

        public Transaccion(int transaccionId, int codigoSeguimiento, DateTime fecha)
        {
            this.TransaccionId = transaccionId;
            this.CodigoSeguimiento = codigoSeguimiento;
            this.Fecha = fecha;
        }

    }
}
