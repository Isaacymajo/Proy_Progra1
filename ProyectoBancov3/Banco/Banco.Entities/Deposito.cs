using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
  public   class Deposito : Transaccion
    {
        public int DepositoId { get; set; }
        public int CuentaDestino { get; set; }
        public decimal Monto{ get; set; }
        public Deposito(int transaccionId, int codigoSeguimiento, DateTime fecha, int depositoId, int cuentaDestino, decimal monto)
            : base (transaccionId, codigoSeguimiento, fecha)
        {
            this.TransaccionId = transaccionId;
            this.CodigoSeguimiento = codigoSeguimiento;
            this.Fecha = fecha;
            this.DepositoId = depositoId;
            this.CuentaDestino = cuentaDestino;
            this.Monto = monto;
        }
    }
}
