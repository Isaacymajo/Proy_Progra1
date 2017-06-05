using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    public class PJuridica : Cliente
    {
        public int PJuridicaId { get; set; }
        public int Ruc { get; set; }
        public string RazonSocial { get; set; }
        public PJuridica(int clienteId, string nombre, string apellido, char direccion, char correo, int telefono, Tarjeta tarjeta,
            int pJuridicaId, int Ruc, string RazonSocial): base (clienteId, nombre,apellido,direccion,correo,telefono,tarjeta)
        {
            this.ClienteId = clienteId;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Correo = correo;
            this.Telefono = telefono;
            this.PJuridicaId = pJuridicaId;
            this.Ruc = Ruc;
            this.RazonSocial = RazonSocial;
           

        }
    }
}
