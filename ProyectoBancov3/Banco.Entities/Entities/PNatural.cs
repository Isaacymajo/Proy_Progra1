using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class PNatural: PJuridica
    {
        public int DNI { get; set; }
        public string Ocupacion { get; set; }

       
    }
}
