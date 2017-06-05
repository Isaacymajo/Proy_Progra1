using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public abstract class PJuridica
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public virtual ICollection<Tarjeta> Tarjeta { get; set; }
        
        
        public PJuridica()
        {
            
            Tarjeta = new List<Tarjeta>();
        }
    }
}
