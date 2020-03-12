using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazPlugin;

namespace CPlugin
{
    [CVentanaPlugin.CInfoPlugIn(Creador ="David", Informacion ="Calculador de canditades requeridas", Licencia = "open", Nombre ="Cuantificador", Version ="1")]
    public class CPluginMedical : CVentanaPlugin.IVentana
    {
        private MyFormulario myFormulario;
        private IUtiles util;
        private CVentanaPlugin.IVentana ventana;
        private static CPluginMedical formulario;
        public CPluginMedical()
        {
            this.myFormulario = new MyFormulario();
            formulario = this;
        }

        public Panel Panel { get { return myFormulario.pnBody; } set { throw new NotImplementedException(); } }
        public IButtonControl AcceptButton { get { return myFormulario.AcceptButton; } set { throw new NotImplementedException(); } }

        public IUtiles Util { get { return util; } set { util = value; } }

        public Image Icono { get { return Properties.Resources.medicamentos; } }

        public static CPluginMedical Formulario { get { return formulario; } set { formulario = value; } }

        public CVentanaPlugin.IVentana Ventana { get { return ventana; } set { ventana = value; } }

        public void CambiarVentana(CVentanaPlugin.IVentana ventana)
        {
            Ventana.CambiarVentana(ventana);
        }

        public void load()
        {
            myFormulario.load();
        }
    }
}
