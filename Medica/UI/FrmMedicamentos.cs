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
    public partial class FrmMedicamentos : FormBase, CVentanaPlugin.IVentana
    {
        public FrmMedicamentos()
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
            Autorizar("Agregar");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CambiarVentana(new FrmBuscaEliminaMedicamento("Salvar"));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Autorizar("Modificar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Autorizar("Eliminar");
        }

        private void Autorizar(string ventana)
        {
            switch (Utiles.Util.GetRol())
            {
                case Utiles.Rol.Administrador:
                case Utiles.Rol.Farmaceutico:
                    if (ventana.Equals("Agregar"))
                        CambiarVentana(new FrmAddMedicamentos(null));
                    else
                        CambiarVentana(new FrmBuscaEliminaMedicamento(ventana));
                    break;
                default:
                    MessageBox.Show("No estas Autorizado para esta accion", "No tienes el privilegio Requrido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
            }
        }

    }
}
