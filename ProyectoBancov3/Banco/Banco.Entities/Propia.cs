using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class Propia : Transferencia
    {
        public int PropiaId { get; set; }
        public string CuentaPropia { get; set; }
        public int DNI { get; set; }
        public Propia(int transaccionId, int codigoSeguimiento, DateTime fecha, int transferenciaId, double montoTransferir, int codSeguridad
            , int propiaId, string cuentaPropia, int dni)
            : base (transaccionId, codigoSeguimiento,fecha,transaccionId,montoTransferir,codSeguridad)
        {
            this.TransaccionId = transaccionId;
            this.CodigoSeguimiento = codigoSeguimiento;
            this.Fecha = fecha;
            this.TransferenciaId = transferenciaId;
            this.MontoTransferir = montoTransferir;
            this.CodSeguridad = CodSeguridad;
            this.PropiaId = propiaId;
            this.CuentaPropia = cuentaPropia;
            this.DNI = dni;
        }
    }
}
