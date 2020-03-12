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
using UCErrorTextBox;

namespace UI
{
    public partial class FrmBuscaEliminaPaciente : FormBase, CVentanaPlugin.IVentana
    {
        public FrmBuscaEliminaPaciente(string accion)
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
            paneliz.Size = panelder.Size = new Size(pnBody.Size.Width / 2, paneliz.Height);
            txtBuscar.AutoCompleteCustomSource = CBuscarPaciente.Paciente.getAutoCompleteString("Cedula");
        }

        private void pnBody_SizeChanged(object sender, EventArgs e)
        {
            paneliz.Size = panelder.Size = new Size(pnBody.Size.Width / 2, paneliz.Height);
            paneliniz.Size = panelinde.Size = new Size((int)(bunifuCardspersonales.Size.Width / 2), paneliniz.Height);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (pacienteTemp == null)
                MessageBox.Show("Primero seleccione un Paciente", "No has Seleccionado el Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    switch (btnAccion.ButtonText)
                    {
                        case "Salvar":
                            new FrmReportePaciente(pacienteTemp.VIDENTIFICACION).Show();
                            break;
                        case "Modificar":
                            CambiarVentana(new FrmAddPaciente(pacienteTemp));
                            break;
                        case "Eliminar":
                            if (CPacientes.Paciente.Eliminar(pacienteTemp))
                            {
                                MessageBox.Show("El Paciente ha sido eliminado exitosamente", "Paciente eliminado del registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CambiarVentana(new FrmPacientes());
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
        
        private void AgregaEvento()
        {
            if (rbNombre.Checked)
                busqueda = new Busqueda(CBuscarPaciente.Paciente.getPacienteNombre);
            else if (rbApellido.Checked)
                busqueda = new Busqueda(CBuscarPaciente.Paciente.getPacienteApellido);
            else if (rbDiagnostico.Checked)
                busqueda = new Busqueda(CBuscarPaciente.Paciente.getPacienteDiagnostico);
            else
                busqueda = new Busqueda(CBuscarPaciente.Paciente.getPacienteCedula);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            CambiarVentana(new FrmPacientes());
        }

        private void dgvPacientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.SelectedRows.Count > 0)
                {
                    int i = dgvPacientes.SelectedRows[0].Index;
                    List<CPaciente> lista = (List<CPaciente>)dgvPacientes.DataSource;
                    paciente = lista.ElementAt(i);
                    pacienteTemp = CBuscarPaciente.Paciente.getPaciente(paciente);
                    Cargar(pacienteTemp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar(PACIENTE p)
        {
            txtcedula.Text = p.DATOSPERSONALES.VCEDULA;
            txtnombre.Text = p.DATOSPERSONALES.VNOMBRE;
            txtapellido1.Text = p.DATOSPERSONALES.VPRIMERAPELLIDO;
            txtapellido2.Text = p.DATOSPERSONALES.VSEGUNDOPELLIDO;
            txtfechana.Text = p.DATOSPERSONALES.DTFECHANACIMIENTO.ToShortDateString();
            cuGenero.Genero = (p.DATOSPERSONALES.VGENERO.Equals("Masculino"));
            txtEdad.Text = p.IEDAD.ToString();
            txtestatura.Text = p.DTALLA.ToString();
            txtpeso.Text = p.DPESO.ToString();
            txtdiagnostico.Text = p.DIAGNOSTICO.VDIAGNOSTICO;
            lbPadecimientos.Items.Clear();
            p.PADECIMIENTO.ToList<PADECIMIENTO>().ForEach(
                pa => lbPadecimientos.Items.Add(pa.DIAGNOSTICO.VDIAGNOSTICO + "\t\tEstado = " +((pa.BESTADO) ? "Activo" : "Remición"))
                );
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Comprobacion.ValidarCampos(pnBody,errorProvider1))
            {
                AgregaEvento();
                List<CPaciente> list;
                try
                {
                    list = busqueda.Invoke(txtBuscar.Text);
                    dgvPacientes.DataSource = list;
                    if (list.Count == 0)
                    {
                        pacienteTemp = null;
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
        private CPaciente paciente;
        private PACIENTE pacienteTemp;
        private delegate List<CPaciente> Busqueda(string id);

        private void rbCedula_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.MaxLength = 11;
            txtBuscar.AutoCompleteCustomSource = CBuscarPaciente.Paciente.getAutoCompleteString("Cedula");
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.MaxLength = 100;
            txtBuscar.AutoCompleteCustomSource = CBuscarPaciente.Paciente.getAutoCompleteString("Nombre");
        }

        private void rbApellido_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.MaxLength = 100;
            txtBuscar.AutoCompleteCustomSource = CBuscarPaciente.Paciente.getAutoCompleteString("Apellido");
        }

        private void rbDiagnostico_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.MaxLength = 100;
            txtBuscar.AutoCompleteCustomSource = CBuscarPaciente.Paciente.getAutoCompleteString("Diagnostico");
        }
    }
}
