using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class CPaciente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido_1 { get; set; }
        public string Apellido_2 { get; set; }
        public string Diagnostico { get; set; }

        public override string ToString()
        {
            return Cedula + " Nombre: " + Nombre + " Apellido " + Apellido_1 + " Diagnostico " + Diagnostico;
        }
    }
}
