using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
   public class Cuenta : Transaccion
    {
        TipoCuenta tipoCuenta;
        
        public Cuenta (int transaccionId, int codigoSeguimiento, DateTime fecha,TipoCuenta tipoCuenta, int numeroCuenta, decimal saldoDisponible, decimal saldoTotal)
            : base(transaccionId, codigoSeguimiento, fecha)
        {
            this.TransaccionId = transaccionId;
            this.CodigoSeguimiento = codigoSeguimiento;
            this.Fecha = fecha;
            this.tipoCuenta = tipoCuenta;
            this.NumeroCuenta = numeroCuenta;
            this.SaldoDisponible = saldoDisponible;
            this.SaldoTotal = SaldoTotal;
        }
        public int CuentaId { get; set; }
        public int TipoCuenta { get; set; }
        public int NumeroCuenta { get; set; }   
        public decimal SaldoDisponible { get; set; }
        public decimal SaldoTotal { get; set; }
    }
}
