using Banco.Entities;
using Banco.Persistence.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Persistence
{
    public class BancoDbContext: DbContext
    {
        public DbSet<PJuridica> Clientes { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<TipoCuenta> TipoCuentas { get; set; }

        public BancoDbContext() :base ("BancoDb")
        {
                
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new TarjetaConfiguration());
            modelBuilder.Configurations.Add(new TipoCuentaConfiguration());
            modelBuilder.Configurations.Add(new TransaccionConfiguration());



            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<Banco.Entities.Apertura> Transaccions { get; set; }
    }
}
