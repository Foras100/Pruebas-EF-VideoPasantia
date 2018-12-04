using PruebaVideoEF.Mapeos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.entityFrameworkCore;

namespace PruebaVideoEF
{
    public class MiDbContext: DbContext
    {
        public MiDbContext()
            : base("name=conexionDB")
        {
        }

        public DbSet<Persona> Personas
        {
            get { return this.Set<Persona>(); }
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MapeoPersona());
        }
    }
}
