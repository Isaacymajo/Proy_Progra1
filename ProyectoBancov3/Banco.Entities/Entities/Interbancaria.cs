using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class Interbancaria: Transferencias
    {
        public int CodCuentaInterbancaria { get; set; }
        public long RUC { get; set; }
        public string RazonSocial { get; set; }

        
    }
}
