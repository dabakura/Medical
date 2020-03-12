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
using DAL;
using DO;

namespace UI
{
    public partial class FrmInicio : FormBase, CVentanaPlugin.IVentana
    {

        public FrmInicio()
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
            inicio = false;
            user = (USUARIO) Utiles.Util.User;
            txt1apellido.Text = user.DATOSPERSONALES.VPRIMERAPELLIDO;
            txt2apellido.Text = user.DATOSPERSONALES.VSEGUNDOPELLIDO;
            txtcedula.Text = user.DATOSPERSONALES.VCEDULA;
            txtnombre.Text = user.DATOSPERSONALES.VNOMBRE;
            txtrol.Text = user.VROL;
            switch (Utiles.Util.GetRol(user.VROL))
            {
                case Utiles.Rol.Administrador:
                    pblogo.Image = Properties.Resources.Administrador;
                    break;
                case Utiles.Rol.Medico:
                    pblogo.Image = Properties.Resources.Medico;
                    break;
                case Utiles.Rol.Enfermera:
                    pblogo.Image = Properties.Resources.Enfermera;
                    break;
                case Utiles.Rol.Farmaceutico:
                    pblogo.Image = Properties.Resources.Farmaceutico;
                    break;
                case Utiles.Rol.Otros:
                    pblogo.Image = Properties.Resources.Otros;
                    break;
                case Utiles.Rol.Ninguno:
                    pblogo.Image = Properties.Resources.Ninguno;
                    break;
            }
            CInicio.GetCPacientes().ForEach(p =>
            {
                ListViewItem l = new ListViewItem(new string[] {
                    p.Cedula,
                    p.Nombre,
                    p.Apellido_1,
                    p.Apellido_2,
                    p.Diagnostico}, 0);
                l.Tag = p;
                lvpacientes.Items.Add(l);
            }
            );
            cbPacientes.DataSource = CInicio.GetCPacientes();
            inicio = true;
        }

        private USUARIO user;

        private void lvpacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicio && lvpacientes.SelectedItems.Count>0)
            {
                CPaciente p = (CPaciente)lvpacientes.SelectedItems[0].Tag;
                CInicio.Seleccion(p);
                Notificacion(p);
                pa = p;
                cbPacientes.Text = p.ToString();
            }
        }

        private void Notificacion(CPaciente p)
        {
            if ((pa == null) || (!pa.Cedula.Equals(p.Cedula)))
            {
                notify.BalloonTipText = "Se ha seleccionado a " + p.Nombre + " " + p.Apellido_1;
                notify.Visible = true;
                notify.ShowBalloonTip(60000);
            }
        }

        private void cbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbPacientes.SelectedIndex;
            if (indice>-1 && inicio)
            {
                CPaciente p = ((List<CPaciente>)cbPacientes.DataSource).ElementAt(indice);
                CInicio.Seleccion(p);
                Notificacion(p);
                pa = p;
            }
        }

        private void notify_BalloonTipClosed(object sender, EventArgs e)
        {
            notify.Visible = false;
        }

        private CPaciente pa;
        private bool inicio;
    }
}
