using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    class PagoServicios : Transaccion
    {
        public int codServicio { get; set; }
        public decimal deuda { get; set; }
        public int cuentaCargo { get; set; }
        public string empresa { get; set; }
        public PagoServicios(int transaccionId, int codigoSeguimiento, DateTime fecha, int codServicio, decimal deuda , int cuentaCargo, string empresa)
            : base (transaccionId, codigoSeguimiento, fecha)
        {
            this.TransaccionId = transaccionId;
            this.CodigoSeguimiento = codigoSeguimiento;
            this.Fecha = fecha;
            this.codServicio = codServicio;
            this.deuda = deuda;
            this.cuentaCargo = cuentaCargo;
            this.empresa = empresa;
        }
    }
}
