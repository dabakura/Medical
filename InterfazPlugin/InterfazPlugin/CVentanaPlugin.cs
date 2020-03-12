using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InterfazPlugin
{
    public interface IUtiles
    {
        dynamic GetEmpleado(string id);
        dynamic GetEmpleados();
        dynamic GetMedicamento(string id);
        dynamic GetPaciente(string id);
        dynamic GetMedicamentos();
        dynamic GetPacientes();
        dynamic GetDiagnostico(string id);
        dynamic GetDiagnosticos();
        dynamic GetVias_Administracion();
        dynamic GetVia_Administracion(string id);
        dynamic GetSintomas();
        dynamic GetSintoma(string id);
    }

    public class CVentanaPlugin
    {
        public interface IVentana 
        {
            void load();
            Panel Panel { get; set; }
            void CambiarVentana(IVentana ventana);
            IButtonControl AcceptButton { get; set; }
            IUtiles Util { get; set; }
            IVentana Ventana { get; set; }
            Image Icono { get; }
        }

        [AttributeUsage(AttributeTargets.Class)]
        public sealed class CInfoPlugIn : Attribute
        {
            private String nombre;
            private String informacion;
            private String creador;
            private String version;
            private String licencia;

            public string Informacion { get { return informacion; } set { informacion = value; } }
            public string Creador { get { return creador; } set { creador = value; } }
            public string Version { get { return version; } set { version = value; } }
            public string Licencia { get { return licencia; } set { licencia = value; } }
            public string Nombre { get { return nombre; } set { nombre = value; } }
            
        }

    }
}
