using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazPlugin;

namespace BS
{
    public class CWindows : CVentanaPlugin.IVentana
    {
        private static CWindows ventana;
        private static Panel body;
        private Form form;

        public static CWindows Ventana { get { return (ventana!=null) ? ventana : ventana = new CWindows(); } set { ventana = value; } }
        public Form Formulario { get { return (form != null) ? form : new Form(); } set { form = value; } }

        public Panel Panel { get { return body; } set { body = value; } }

        public IButtonControl AcceptButton { get { return Formulario.AcceptButton; } set { Formulario.AcceptButton = value; } }

        public IUtiles Util { get { return Utiles.Util; } set { throw new NotImplementedException(); } }

        public Image Icono { get { throw new NotImplementedException(); } }

        CVentanaPlugin.IVentana CVentanaPlugin.IVentana.Ventana { get { return Ventana; } set { throw new NotImplementedException(); } }

        public void CambiarVentana(CVentanaPlugin.IVentana formulario)
        {
            if (this.Panel.Controls.Count != 0)
                this.Panel.Controls.RemoveAt(0);
            formulario.load();
            formulario.Panel.BorderStyle = BorderStyle.None;
            formulario.Panel.Dock = DockStyle.Fill;
            this.Panel.Controls.Add(formulario.Panel);
            this.AcceptButton = formulario.AcceptButton;
            this.Panel.Refresh();
        }
        public void load()
        {
            
        }
    }
}
