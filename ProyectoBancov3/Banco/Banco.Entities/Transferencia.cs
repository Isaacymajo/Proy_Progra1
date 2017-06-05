using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
   public abstract class Transferencia : Transaccion
    {
        public int TransferenciaId { get; set; }
        public double MontoTransferir { get; set; }
        public int CodSeguridad { get; set; }

        public Transferencia(int transaccionId, int codigoSeguimiento, DateTime fecha,int transferenciaId, double montoTransferir, int codSeguridad)
            : base (transaccionId, codigoSeguimiento, fecha)
        {
            this.TransaccionId = transaccionId;
            this.CodigoSeguimiento = codigoSeguimiento;
            this.Fecha = fecha;
            this.TransferenciaId = TransferenciaId;
            this.MontoTransferir = montoTransferir;
            this.CodSeguridad = codSeguridad;
        }
    }
}
