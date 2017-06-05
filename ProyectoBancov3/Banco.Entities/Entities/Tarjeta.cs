using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class Tarjeta
    {
        public int TarjetaId { get; set; }
        public long CodSeguridad { get; set; }
        public string Contraseña { get; set; }
        public long Debito { get; set; }
        public long Credito { get; set; }
        public string Moneda { get; set; }
        public virtual int clienteid { get; set; }
        public virtual PJuridica Cliente { get; set; }
        public virtual ICollection<Transaccion> Transaccion { get; set; }

        public Tarjeta()
        {
            
            Transaccion = new List<Transaccion>();

        }
    }
}
