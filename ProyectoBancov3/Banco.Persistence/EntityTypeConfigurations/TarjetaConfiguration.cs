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
    public class TarjetaConfiguration: EntityTypeConfiguration<Tarjeta>
    {
        public TarjetaConfiguration()
        {
            //Table Configurations
            ToTable("Tarjetas");
            HasKey(c => c.TarjetaId);
            Property(c => c.TarjetaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Relationships Configurations
            //...

            HasMany(p => p.Transaccion)
                .WithRequired(c => c.Tarjeta);
        }
    }
}
