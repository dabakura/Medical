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
using UCErrorTextBox;
using DO;

namespace UI
{
    public partial class FrmBuscaEliminaMedicamento : FormBase, CVentanaPlugin.IVentana
    {
        public FrmBuscaEliminaMedicamento(string accion)
        {
            InitializeComponent();
            btnAccion.ButtonText = accion;
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
            txtBuscar.AutoCompleteCustomSource = CBuscarMedicamento.Medicamento.getAutoCompleteString(rbNombre.Text);
            txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            CambiarVentana(new FrmAddMedicamentos2(null));
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (m != null)
                new FrmMasInfoMedicamento(m).Show();
            else
                MessageBox.Show("Primero Busque y seleccione el Medicamento","No hay Selecciòn",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            CambiarVentana(new FrmMedicamentos());
        }

        private void AgregaEvento()
        {
            if (rbNombre.Checked)
                busqueda = new Busqueda(CBuscarMedicamento.Medicamento.getMedicamentoNombre);
            else if (rbindicacionSIntoma.Checked)
                busqueda = new Busqueda(CBuscarMedicamento.Medicamento.getMediacamentoIndicacionSintoma);
            else
                busqueda = new Busqueda(CBuscarMedicamento.Medicamento.getMediacamentoIndicacionDiagnosticoa);
        }

        private void dgvMedicamentos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.SelectedRows.Count > 0)
                {
                    int i = dgvPacientes.SelectedRows[0].Index;
                    List<CMedicamento> lista = (List<CMedicamento>)dgvPacientes.DataSource;
                    paciente = lista.ElementAt(i);
                    m = CBuscarMedicamento.Medicamento.getMedicamento(paciente);
                    Cargar(m);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            listVia.Items.Clear();
            listNombres.Items.Clear();
            listDosis.Items.Clear();
            txtCompoEstero.Clear();
            txtdescripcion.Clear();
            Composicion = Esteroquimica = "";
        }

        private void Cargar(MEDICAMENTO p)
        {
            Limpiar();
            p.MEDI_NOMBRE.ToList().ForEach(n => listNombres.Items.Add(n.VNOMBRE));
            p.DOSIS.ToList().ForEach(n => listDosis.Items.Add(n.VRANGO + " Dosis: " + n.DDOSIS + " MAX " + n.DMAX + " MIN " + n.DMIN));
            p.VIA_ADMINISTRACION.ToList().ForEach(n => listVia.Items.Add(n.VNOMBRE));
            txtdescripcion.Text = p.VDESCRIPCION;
            Composicion = (String.IsNullOrEmpty(p.VCOMPOSIION) ? null : p.VCOMPOSIION);
            Esteroquimica = (String.IsNullOrEmpty(p.VESTEROQUIMICA) ? null : p.VESTEROQUIMICA);
            if (Composicion!=null)
            {
                txtCompoEstero.Text = Composicion;
            }
        }

        private void rbcomposicion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComposi.Checked)
            {
                Esteroquimica = txtCompoEstero.Text;
                txtCompoEstero.Text = Composicion;
            }
        }

        private void rbesteroquimica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstero.Checked)
            {
                Composicion = txtCompoEstero.Text;
                txtCompoEstero.Text = Esteroquimica;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Comprobacion.ValidarCampos(pnBody, errorProvider1))
            {
                AgregaEvento();
                List<CMedicamento> list;
                try
                {
                    list = busqueda.Invoke(txtBuscar.Text);
                    dgvPacientes.DataSource = list;
                    if (list.Count == 0)
                    {
                        m = null;
                        Limpiar();
                        MessageBox.Show("No se encontraron concidencias", "No hay Concidencias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Busqueda busqueda;
        private CMedicamento paciente;
        private MEDICAMENTO m;
        private string Composicion;
        private string Esteroquimica;

        private delegate List<CMedicamento> Busqueda(string id);

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (m == null)
                MessageBox.Show("Primero seleccione un Medicamento", "No has Seleccionado el Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    switch (btnAccion.ButtonText)
                    {
                        case "Salvar":
                            new FrmReporteMedicamento(m.ICODIGO).Show();
                            break;
                        case "Modificar":
                            CambiarVentana(new FrmAddMedicamentos(m));
                            break;
                        case "Eliminar":
                            if (CMedicamentos.Medicamento.Eliminar(m))
                            {
                                MessageBox.Show("El Medicamento ha sido eliminado exitosamente", "Medicamento eliminado del registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CambiarVentana(new FrmMedicamentos());
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNombre.Checked)
                txtBuscar.AutoCompleteCustomSource = CBuscarMedicamento.Medicamento.getAutoCompleteString(rbNombre.Text); 
            else if (rbindicacionSIntoma.Checked)
                txtBuscar.AutoCompleteCustomSource = CBuscarMedicamento.Medicamento.getAutoCompleteString(rbindicacionSIntoma.Text);
            else
                txtBuscar.AutoCompleteCustomSource = CBuscarMedicamento.Medicamento.getAutoCompleteString(rbIndicaDiagnostico.Text);
            
            txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
