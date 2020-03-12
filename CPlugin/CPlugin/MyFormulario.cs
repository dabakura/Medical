using InterfazPlugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPlugin
{
    public partial class MyFormulario : Form, CVentanaPlugin.IVentana
    {
        public MyFormulario()
        {
            InitializeComponent();
        }

        public Panel Panel { get { return this.pnBody; } set { throw new NotImplementedException(); } }

        public IUtiles Util { get { return CPluginMedical.Formulario.Util; } set { CPluginMedical.Formulario.Util = value; } }

        public CVentanaPlugin.IVentana Ventana { get { return CPluginMedical.Formulario.Ventana; } set { throw new NotImplementedException(); } }

        public Image Icono { get { return Properties.Resources.medicamentos; } }

        public void CambiarVentana(CVentanaPlugin.IVentana ventana)
        {
            Ventana.CambiarVentana(ventana);
        }

        public void load()
        {
            int index = 0;
            ListViewItem[] lista = new ListViewItem[Util.GetMedicamentos().Count];
            foreach (dynamic item in Util.GetMedicamentos())
            {
                ListViewItem listViewItem1 = new ListViewItem(item.MEDI_NOMBRE[0].VNOMBRE, 0);
                listViewItem1.Tag = item;
                lista[index] = listViewItem1;
                index++;
            }
            listaMedicamento.Items.AddRange(lista);
        }


        private dynamic Medicamento;

        private void listaMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaMedicamento.SelectedItems.Count > 0)
            {
                Medicamento = listaMedicamento.SelectedItems[0].Tag;
                Cargar();
            }
        }

        private void Cargar()
        {
            txtmedi.Text = Medicamento.MEDI_NOMBRE[0].VNOMBRE;
            cbvia.Text = "--- Seleccione ---";
            cbvia.Items.Clear();
            txtdd.Clear();
            txtdu.Clear();
            lbresultado.Text = "";
            foreach (dynamic item in Medicamento.VIA_ADMINISTRACION)
            {
                cbvia.Items.Add(item.VNOMBRE);
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (cbvia.Text.Equals("--- Seleccione ---"))
                MessageBox.Show("Seleccione un via de administracion primero");
            else
            {
                if (Validar())
                {
                    double d = (Convert.ToDouble(txtdd.Text) / Convert.ToDouble(txtdu.Text));
                    if (d != Convert.ToDouble(((int)d)))
                        d = Convert.ToDouble(((int)d) + 1);
                    lbresultado.Text = "Nesesitaras: " + d + " " + cbvia.Text;
                }
                else
                    MessageBox.Show("Ingrese dosis validas");
            }
        }

        private bool Validar()
        {
            try
            {
                Convert.ToDouble(txtdu.Text);
                Convert.ToDouble(txtdd.Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
