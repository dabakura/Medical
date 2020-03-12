using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    [Serializable]
    public class Libro
    {
        private DateTime fecha;
        private String descripcion;

        public Libro()
        {
            this.fecha = DateTime.Now;
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        public DateTime Fecha
        {
            get { return fecha; }
        }

    }
}
