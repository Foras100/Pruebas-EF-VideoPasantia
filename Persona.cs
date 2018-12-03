
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVideoEF
{
    public abstract class Persona
    {
        public int CodigoPersona { get; set; }
        public abstract string Descripcion { get; }
        public string Observaciones { get; set; }
    }
}
