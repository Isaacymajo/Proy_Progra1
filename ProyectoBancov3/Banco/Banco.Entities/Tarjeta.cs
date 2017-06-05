using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
   public  class Tarjeta
    {
        public int TarjetaId { get; set; }
        public int CodSeguridad { get; set; }
        public char Contraseña { get; set; }
        public int Debito { get; set; }
        public int Credito { get; set; }
        public double Moneda { get; set; }
        Transaccion transaccion;

        public Tarjeta (int tarjetaId, int codSeguridad, char contraseña, int debito, int credito, double moneda, Transaccion transaccion)
        {
            this.TarjetaId = tarjetaId;
            this.CodSeguridad = codSeguridad;
            this.Contraseña = contraseña;
            this.Debito = debito;
            this.Credito = credito;
            this.Moneda = moneda;
            this.transaccion = transaccion; 
        }
    }
}
