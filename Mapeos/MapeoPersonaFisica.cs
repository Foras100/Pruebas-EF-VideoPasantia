using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVideoEF.Mapeos
{
    class MapeoPersonaFisica: EntityTypeConfiguration<PersonaFisica>
    {
        public MapeoPersonaFisica()
            : base()
        {
            //Tabla
            this.ToTable("Persona");

            //Primary Key
            this.HasKey(p => p.CodigoPersona);

            this.Property(p => p.Edad)
                .HasColumnName("Edad");
            this.Property(p => p.Nombre)
                .HasColumnName("Nombre");
        }
    }
}
