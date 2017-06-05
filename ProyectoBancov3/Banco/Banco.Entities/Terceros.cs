using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
   public class Terceros : Transferencia
    {
        public int TercerosId { get; set; }
        public int CuentaTerceros { get; set; }
        public Terceros(int transaccionId, int codigoSeguimiento, DateTime fecha, int transferenciaId, double montoTransferir, int codSeguridad
           , int tercerosId, int cuentaTerceros)
            : base(transaccionId, codigoSeguimiento, fecha, transaccionId, montoTransferir, codSeguridad)
        {
            this.TransaccionId = transaccionId;
            this.CodigoSeguimiento = codigoSeguimiento;
            this.Fecha = fecha;
            this.TransferenciaId = transferenciaId;
            this.MontoTransferir = montoTransferir;
            this.CodSeguridad = CodSeguridad;
            this.TercerosId = tercerosId;
            this.CuentaTerceros = cuentaTerceros;
        }
    }
}
