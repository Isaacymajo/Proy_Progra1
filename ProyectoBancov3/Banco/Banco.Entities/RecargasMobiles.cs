using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class RecargasMobiles : Transaccion
    {
        public int RecargasMobilesId { get; set; }
        public string Operador { get; set; }
        public double MontoRecarga { get; set; }
        public int NumeroMobil { get; set; }

        public RecargasMobiles(int transaccionId, int codigoSeguimiento, DateTime fecha, int recargasMobilesId,string operador, double montoRecarga,int numeroMobil)
            : base (transaccionId, codigoSeguimiento,fecha)
        {
            this.TransaccionId = transaccionId;
            this.CodigoSeguimiento = codigoSeguimiento;
            this.Fecha = fecha;
            this.RecargasMobilesId = recargasMobilesId;
            this.Operador = operador;
            this.MontoRecarga = montoRecarga;
            this.NumeroMobil = numeroMobil;
        }
    }
}
