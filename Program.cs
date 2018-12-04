using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVideoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (MiDbContext context = new MiDbContext())
                {
                    //AgregarPersonaJuridica(context);
                    //AgregarPersonaFisica(context);
                    //ModificarPersonaFisica(context);
                    EliminarPersona(context);
                    MostrarPersonas(context);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        static void EliminarPersona(MiDbContext context)
        {
            Persona p = context.Set<Persona>().Find(7);
            if(p == null){
                throw new Exception("La persona a eliminar no existe con ese codigo");
            }
            context.Set<Persona>().Remove(p);
            context.SaveChanges();

        }
        static void ModificarPersonaFisica(MiDbContext context)
        {
            PersonaFisica p = context.Set<PersonaFisica>().Find(1);
            p.Nombre = "Forastieri";
            context.SaveChanges();
        }
        static void AgregarPersonaFisica(MiDbContext context)
        {
            PersonaFisica p = new PersonaFisica() {CodigoPersona=7,Edad=23,Nombre="Joan",Observaciones="Sin Obs"};

            context.Personas.Add(p);
            context.SaveChanges();
        }
        static void AgregarPersonaJuridica(MiDbContext context)
        {
            PersonaJuridica p = new PersonaJuridica();
            p.RazonSocial = "Musimundo";

            context.Set<Persona>().Add(p);
            context.SaveChanges();
        }
        static void MostrarPersonas(MiDbContext context)
        {
            foreach(Persona p in context.Set<Persona>())
            {
                Console.WriteLine("{0} - ({1})",p.Descripcion,p is PersonaFisica? "Fisica":"Juridica");
            }
        }
    }
}
