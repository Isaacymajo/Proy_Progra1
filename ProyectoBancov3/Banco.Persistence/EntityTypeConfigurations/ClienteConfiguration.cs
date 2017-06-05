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
    public class ClienteConfiguration: EntityTypeConfiguration<PJuridica>
    {
        public ClienteConfiguration()
        {
            //Table Configurations
            ToTable("Clientes");
            HasKey(c => c.ClienteId);
            Property(c => c.ClienteId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Relationships Configurations
            Property(p => p.Nombre).IsRequired();
            Property(p => p.Apellido).IsRequired();
           
            Property(p => p.Correo).IsRequired();
            Property(p => p.Telefono).IsRequired();

            HasMany(p => p.Tarjeta)
                .WithRequired(c => c.Cliente);

            Map<PNatural>(m => m.Requires("Discriminator").HasValue("PNatural"));
            Map<PJuridica>(m => m.Requires("Discriminator").HasValue("PJuridica"));
        }
    }
}
