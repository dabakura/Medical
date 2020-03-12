using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazPlugin;
using BS;

namespace UI
{
    public partial class FrmLogin : FormBase, CVentanaPlugin.IVentana
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public Panel Panel { get { return pnBody; } set { throw new NotImplementedException(); } }

        public IUtiles Util { get { return Utiles.Util; } set { throw new NotImplementedException(); } }

        public CVentanaPlugin.IVentana Ventana { get { return CWindows.Ventana; } set { throw new NotImplementedException(); } }

        public Image Icono { get { throw new NotImplementedException(); } }

        public void CambiarVentana(CVentanaPlugin.IVentana ventana)
        {
            Ventana.CambiarVentana(ventana);
        }

        public void load()
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtUsuario.Text))
                    MessageBox.Show("Primero ingrese todos los dDatos", "Faltandatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (CLogin.Login.Logearce(txtUsuario.Text, txtPassword.Text))
                        CambiarVentana(new FrmInicio());
                    else
                        MessageBox.Show("Tus datos no coinciden con Ninguna Cuenta", "No estas Registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message,"Error desconocido",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
