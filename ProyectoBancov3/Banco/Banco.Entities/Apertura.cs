using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class Apertura : Transaccion
    {
        public int AperturaId { get; set; }
        public double Tasa { get; set; }

        public string TipoTarjeta { get; set; }

        public int saldo { get; set; }
        public DateTime FechaEntrega { get; set; }
        public Apertura(int transaccionId, int codigoSeguimiento, DateTime fecha, int aperturaId, double tasa, string tipoTarjeta
            , int saldo, DateTime fechaEntrega)
            : base (transaccionId, codigoSeguimiento,fecha)
        {
            this.TransaccionId = transaccionId;
            this.CodigoSeguimiento = codigoSeguimiento;
            this.Fecha = fecha;
            this.AperturaId = aperturaId;
            this.Tasa = tasa;
            this.TipoTarjeta = tipoTarjeta;
            this.saldo = saldo;
            this.FechaEntrega = fechaEntrega;
        }
    }
}
