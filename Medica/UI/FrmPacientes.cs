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
    public partial class FrmPacientes : FormBase, CVentanaPlugin.IVentana
    {
        public FrmPacientes()
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

        private void pnBody_Resize(object sender, EventArgs e)
        {

        }

        private void cuCarpeta1_Load(object sender, EventArgs e)
        {
            Autorizar("Agregar");
        }

        private void cuCarpeta5_Load(object sender, EventArgs e)
        {
            CambiarVentana(new FrmBuscaEliminaPaciente("Salvar"));
        }

        private void cuCarpeta2_Load(object sender, EventArgs e)
        {
            Autorizar("Modificar");
        }

        private void cuCarpeta4_Load(object sender, EventArgs e)
        {
            Autorizar("Eliminar");
        }

        private void Autorizar(string ventana)
        {
            switch (Utiles.Util.GetRol())
            {
                case Utiles.Rol.Administrador:
                case Utiles.Rol.Medico:
                case Utiles.Rol.Enfermera:
                    if (ventana.Equals("Agregar"))
                        CambiarVentana(new FrmAddPaciente(null));
                    else
                        CambiarVentana(new FrmBuscaEliminaPaciente(ventana));
                    break;
                default:
                    MessageBox.Show("No estas Autorizado para esta accion", "No tienes el privilegio Requrido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
            }
        }
    }
}
