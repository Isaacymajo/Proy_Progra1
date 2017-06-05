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
        public long CodigoSeguimiento { get; set; }
        public DateTime Fecha { get; set; }
        public virtual int TarjetaId { get; set; }
        public virtual Tarjeta Tarjeta { get; set; }

       
    }
}
