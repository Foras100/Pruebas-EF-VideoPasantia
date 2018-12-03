using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVideoEF
{
    class PersonaFisica: Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public override string Descripcion
        {
            get
            {
                return this.Nombre+" - "+this.Edad;
            }
        }
    }
}
