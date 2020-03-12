using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BS;

namespace UI
{
    public partial class FrmWindows : Form
    {
        public FrmWindows()
        {
            InitializeComponent();
            CWindows.Ventana.Formulario = this;
            CWindows.Ventana.Panel = pnBody;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bibMenu_Click(object sender, EventArgs e)
        {
            if (pnLateral.Width == 50)
            {
                pnLateral.Visible = false;
                pnLateral.Width = 200;
                TransitionPanel.ShowSync(pnLateral);
                TransitionLogo.ShowSync(pbLogo);
            }
            else
            {
                TransitionLogo.HideSync(pbLogo);
                pnLateral.Visible = false;
                pnLateral.Width = 50;
                TransitionPanel.ShowSync(pnLateral);
            }
        }

        private void bunifuImageButton3_MouseLeave(object sender, EventArgs e)
        {
            bibExit.BackColor = Color.FromArgb(44, 46, 62);
            bibHelp.BackColor = Color.FromArgb(44, 46, 62);
            bibMini.BackColor = Color.FromArgb(44, 46, 62);
        }

        private void bibExit_MouseEnter(object sender, EventArgs e)
        {
            bibExit.BackColor = Color.FromArgb(245, 32, 62);
        }

        private void bibMini_MouseEnter(object sender, EventArgs e)
        {
            bibMini.BackColor = Color.FromArgb(25, 34, 56);
        }

        private void bibHelp_MouseEnter(object sender, EventArgs e)
        {
            bibHelp.BackColor = Color.FromArgb(25, 34, 56);
        }

        private void bibMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bfbInicio_Click(object sender, EventArgs e)
        {
            if (Utiles.Util.User != null)
                CWindows.Ventana.CambiarVentana(new FrmInicio());
            else
                CWindows.Ventana.CambiarVentana(new FrmLogin());
        }

        private void FrmWindows_Load(object sender, EventArgs e)
        {
            CWindows.Ventana.CambiarVentana(new FrmLogin());
        }

        private void bfbPacientes_Click(object sender, EventArgs e)
        {
            CWindows.Ventana.CambiarVentana(new FrmPacientes());
        }

        private void bfbMedicamentos_Click(object sender, EventArgs e)
        {
            CWindows.Ventana.CambiarVentana(new FrmMedicamentos());
        }

        private void bfbKardex_Click(object sender, EventArgs e)
        {
            if (Utiles.Util.Paciente != null)
                Autorizar(new FrmKardex());
            else
                CWindows.Ventana.CambiarVentana(new FrmBloqueo());
        }

        private void bfbSignosVitales_Click(object sender, EventArgs e)
        {
            if (Utiles.Util.Paciente != null)
                Autorizar(new FrmSignosVitales());
            else
                CWindows.Ventana.CambiarVentana(new FrmBloqueo());
        }

        private void bfbExpediente_Click(object sender, EventArgs e)
        {
            if(Utiles.Util.Paciente != null)
                Autorizar(new FrmExpediente());
            else
                CWindows.Ventana.CambiarVentana(new FrmBloqueo());
        }

        private void bfbPlugins_Click(object sender, EventArgs e)
        {
            CWindows.Ventana.CambiarVentana(new FrmPlugins());
        }

        private void Autorizar(InterfazPlugin.CVentanaPlugin.IVentana ventana)
        {
            switch (Utiles.Util.GetRol())
            {
                case Utiles.Rol.Administrador:
                case Utiles.Rol.Medico:
                case Utiles.Rol.Enfermera:
                    CWindows.Ventana.CambiarVentana(ventana);
                    break;
                default:
                    MessageBox.Show("No estas Autorizado para esta accion", "No tienes el privilegio Requrido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
            }
        }
    }
}
