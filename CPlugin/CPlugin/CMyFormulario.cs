using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazPlugin;

namespace CPlugin
{
    public class CMyFormulario : CVentanaPlugin.IVentana
    {
        private MyFormulario myFormulario;
        private IUtiles util;
        public CMyFormulario()
        {
            this.myFormulario = new MyFormulario();
        }

        public Panel Panel { get { return myFormulario.panel1; } set { throw new NotImplementedException(); } }
        public IButtonControl AcceptButton { get { return myFormulario.AcceptButton; } set { throw new NotImplementedException(); } }

        public IUtiles Util { get { return util; } set { util = value; } }

        public void CambiarVentana(CVentanaPlugin.IVentana ventana)
        {
            
        }

        public void Load()
        {
            
        }
    }
}
