using Banco.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Persistence.EntityTypeConfigurations
{
    public class TransaccionConfiguration: EntityTypeConfiguration<Transaccion>
    {
        public TransaccionConfiguration()
        {
            //Table Configurations
            ToTable("Transacciones");
            HasKey(c => c.TransaccionId);
            Property(c => c.TransaccionId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Relationships Configurations
            Property(p => p.TransaccionId).IsRequired();
            Property(p => p.CodigoSeguimiento).IsRequired();
            Property(p => p.Fecha).IsRequired();





            Map<Transferencias>(m => m.Requires("Discriminator").HasValue("Transferencia"));
            Map<Movimientos>(m => m.Requires("Discriminator").HasValue("Movimientos"));
            Map<RecargasMoviles>(m => m.Requires("Discriminator").HasValue("RecargasMobiles"));
            Map<Deposito>(m => m.Requires("Discriminator").HasValue("Deposito"));
            Map<Apertura>(m => m.Requires("Discriminator").HasValue("Apertura"));
            Map<PagoServicios>(m => m.Requires("Discriminator").HasValue("PagoServicio"));
            Map<Cuenta>(m => m.Requires("Discriminator").HasValue("Cuenta"));

            Map<Propia>(m => m.Requires("Discriminator").HasValue("Propia"));
            Map<Interbancaria>(m => m.Requires("Discriminator").HasValue("Interbancaria"));
            Map<Terceros>(m => m.Requires("Discriminator").HasValue("Terceros"));
            
        }
    }
}
