using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVideoEF.Mapeos
{
    class MapeoPersona: EntityTypeConfiguration<Persona>
    {
        public MapeoPersona()
        {
            //Tabla
            this.ToTable("Persona");

            //Primary Key
            this.HasKey(p => p.CodigoPersona);

            //Propiedades
            this.Property(p => p.CodigoPersona)
                .HasColumnName("CodigoPersona");
            //Esto se hace para poder cambiar el nombre de la clase dentro del codigo fuente si compormenter el nombre de BD


            //Indico mapeo de la jerarquia de las clases de persona
            this.Map<PersonaFisica>(p => p.Requires("EsFisica").HasValue(true));
            this.Map<PersonaJuridica>(p => p.Requires("EsFisica").HasValue(false));
        }
    }
}
