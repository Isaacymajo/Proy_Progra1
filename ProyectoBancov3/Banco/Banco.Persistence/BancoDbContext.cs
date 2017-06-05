using Banco.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Persistence
{
    class BancoDbContext: DbContext
    {
        public DbSet <Apertura> Apertura { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<Deposito> Deposito { get; set; }
        public DbSet<Interbancaria> Interbancaria { get; set; }
        public DbSet<Movimiento> Movimiento { get; set; }
        public DbSet<PJuridica> PJuridica { get; set; }
        public DbSet<PNatural> PNatural { get; set; }
        public DbSet<Propia> Propia { get; set; }
        public DbSet<RecargasMobiles> RecargasMobiles { get; set; }
        public DbSet<Tarjeta> Tarjeta{ get; set; }
        public DbSet<Terceros> Terceros { get; set; }
        public DbSet<Transaccion> Transaccion { get; set; }
        public DbSet<Transferencia> Transferencia { get; set; }
        public DbSet<TipoCuenta> TipoCuenta { get; set; }


    }
}
