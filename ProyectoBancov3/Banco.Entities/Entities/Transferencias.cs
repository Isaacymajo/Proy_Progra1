using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public abstract class Transferencias: Transaccion
    {
        public decimal MontoTransferir { get; set; }
        public long CodSeguridad { get; set; }

        
    }
}
