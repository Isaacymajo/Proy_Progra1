using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public abstract class Cliente
    {

        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido{ get; set; }
        public char Direccion { get; set; }
        public char Correo { get; set; }
        public int Telefono { get; set; }
        Tarjeta tarjeta;
        public Cliente (int clienteId, string nombre, string apellido, char direccion, char correo, int telefono, Tarjeta tarjeta)
        {
            this.ClienteId = clienteId;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Correo = correo;
            this.Telefono = telefono;
            this.tarjeta = tarjeta;
            
        }
    }
}
