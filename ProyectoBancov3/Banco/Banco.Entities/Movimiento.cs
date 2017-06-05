using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
   public class Movimiento : Transaccion
    {
        public int MovimientoId { get; set; }
        public string InformacionCuenta { get; set; }
        public string DetalleSaldo { get; set; }
        public Movimiento (int transaccionId, int codigoSeguimiento, DateTime fecha, int movimientoId, string informacionCuenta, string detalleSaldo)
            : base (transaccionId, codigoSeguimiento, fecha)
        {
            this.TransaccionId = transaccionId;
            this.CodigoSeguimiento = codigoSeguimiento;
            this.Fecha = fecha;
            this.MovimientoId = movimientoId;
            this.InformacionCuenta = informacionCuenta;
            this.DetalleSaldo = detalleSaldo;
        }
    }
}
