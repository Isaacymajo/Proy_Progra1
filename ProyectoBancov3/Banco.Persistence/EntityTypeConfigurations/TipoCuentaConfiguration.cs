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
    public class TipoCuentaConfiguration: EntityTypeConfiguration<TipoCuenta>
    {
        public TipoCuentaConfiguration()
        {
            //Table Configurations
            ToTable("TipoCuentas");
            HasKey(c => c.TipoCuentaId);
            Property(c => c.TipoCuentaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Relationships Configurations
            //...

            HasMany(c => c.Cuenta)
                .WithRequired(t => t.TipoCuenta);
        }
    }
}
