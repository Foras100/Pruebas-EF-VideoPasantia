using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVideoEF
{
    class PersonaJuridica: Persona
    {
        public string RazonSocial { get; set; }
        public override string Descripcion
        {
            get
            {
                return this.RazonSocial;
            }
        }
    }
}
