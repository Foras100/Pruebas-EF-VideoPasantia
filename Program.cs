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
                    MostrarPersonas(context);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        static void MostrarPersonas(MiDbContext context)
        {
            foreach(Persona p in context.Personas)
            {
                Console.WriteLine("{0} - ({1})",p.Descripcion,p is PersonaFisica? "Fisica":"Juridica");
            }
        }
    }
}
