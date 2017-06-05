using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class PNatural : Cliente
    {
        public int PNaturalId { get; set; }
        public int DNI { get; set; }
        public string Ocupacion { get; set; }

        public PNatural(int clienteId, string nombre, string apellido, char direccion, char correo, int telefono,Tarjeta tarjeta,
            int pNaturalId, int dni, string ocupacion): base (clienteId, nombre,apellido,direccion,correo,telefono,tarjeta)
        {
            this.ClienteId = clienteId;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Correo = correo;
            this.Telefono = telefono;
            this.PNaturalId = pNaturalId;
            this.DNI = dni;
            this.Ocupacion = ocupacion;
        }
    }
}
