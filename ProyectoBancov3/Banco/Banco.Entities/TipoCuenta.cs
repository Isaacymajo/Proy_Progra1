using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
   public  class TipoCuenta
    {
        public int TipoCuentaId { get; set; }
        public string descripcion { get; set; }

        public TipoCuenta(int tipoCuentaId, string descripcion)
        {
            this.TipoCuentaId = tipoCuentaId;
            this.descripcion = descripcion;
        }
    }
}
