using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class Propia: Transferencias
    {
        public string CuentaPropia { get; set; }
        public long DNI { get; set; }

        
    }
}
