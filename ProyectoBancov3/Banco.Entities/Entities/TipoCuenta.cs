using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class TipoCuenta
    {
        public int TipoCuentaId { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Cuenta> Cuenta { get; set; }

        public TipoCuenta()
        {
            Cuenta = new List<Cuenta>();
        }
    }
}
