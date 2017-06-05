using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
   public class Interbancaria : Transferencia
    {
        public int InterbancariaId { get; set; }
        public int CodCuentaInterbancaria { get; set; }
        public int RUC { get; set; }
        public string RazonSocial { get; set; }
        public Interbancaria(int transaccionId, int codigoSeguimiento, DateTime fecha, int transferenciaId, double montoTransferir, int codSeguridad
            , int interbancariaId, int codCuentaInterbancaria, int ruc, string razonSocial)
            : base(transaccionId, codigoSeguimiento, fecha, transaccionId, montoTransferir, codSeguridad)
        {
            this.TransaccionId = transaccionId;
            this.CodigoSeguimiento = codigoSeguimiento;
            this.Fecha = fecha;
            this.TransferenciaId = transferenciaId;
            this.MontoTransferir = montoTransferir;
            this.CodSeguridad = CodSeguridad;
            this.InterbancariaId = interbancariaId;
            this.CodCuentaInterbancaria = codCuentaInterbancaria;
            this.RUC = ruc;
            this.RazonSocial = razonSocial;
        }
    }
}
