using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BS;
using UCErrorTextBox;

namespace UI
{
    public partial class FrmDiagnostico : Form
    {
        public FrmDiagnostico()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool estado;
           
            try
            {
                if (rbAceptar.Checked)
                {
                    if (Comprobacion.ValidarCampos(this, errorProvider1))
                        estado = CDiagnoctico.Diagnoctico.Guardar(new DIAGNOSTICO() { VDIAGNOSTICO = txtDiagnostico.Text, TDESCRIPCION = txtDescripcion.Text, SINTOMA = CDiagnoctico.Diagnoctico.Sigtomas });
                    else return;
                }
                else 
                {
                    if (Comprobacion.ValidarCampos(this, errorProvider1))
                    {
                        diagnostico.VDIAGNOSTICO = txtDiagnostico.Text;
                        diagnostico.TDESCRIPCION = txtDescripcion.Text;
                        diagnostico.SINTOMA = CDiagnoctico.Diagnoctico.Sigtomas;
                        estado = CDiagnoctico.Diagnoctico.Modificar(diagnostico);
                    }
                    else return;
                }
                if (estado)
                {
                    MessageBox.Show("Se ha realizado la operaciòn correptamente", "Operaciòn Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    diagnosticoChanged.Invoke();
                    this.Close();
                } 
                else
                    MessageBox.Show("Por Favor compruebe los Campos o\nla existencia del diagnostico ingresado", "La Operaciòn Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "La Operaciòn Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiagnostico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && rbModificar.Checked)
                if ((diagnostico = Utiles.Util.GetDiagnostico(txtDiagnostico.Text)) != null)
                {
                    txtDescripcion.Text = diagnostico.TDESCRIPCION;
                    CDiagnoctico.Diagnoctico.Sigtomas = null;
                    udlistefecto.Clear();
                    foreach (SINTOMA sig in diagnostico.SINTOMA)
                    {
                        if (CDiagnoctico.Diagnoctico.AgregarSintoma(sig))
                        {
                            udlistefecto.AddSource(sig.VEFECTO);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No existe este diagnostico", "No se encuentra registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Comprobacion.LimpiarCampos(this);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CDiagnoctico.Diagnoctico.Sigtomas = null;
            this.Close();
        }
        
        private DIAGNOSTICO diagnostico;

        private void FrmDiagnostico_Load(object sender, EventArgs e)
        {
            txtDiagnostico.AutoCompleteCustomSource = CDiagnoctico.Diagnoctico.getAutoCompleteString();
            txtDiagnostico.AutoCompleteSource = AutoCompleteSource.CustomSource;
            udlistefecto.GetDelete += new CUAdd.DeleteChanged(Remover);
            Refrescar();
        }

        private void rbAceptar_CheckedChanged(object sender, EventArgs e)
        {
            Comprobacion.LimpiarCampos(this);
        }
        

        private void cuComboBoxAdd1_Click(object sender, EventArgs e)
        {
            FrmSintoma frd = new FrmSintoma();
            frd.sintomaChanged += new FrmSintoma.SintomaChanged(Refrescar);
            frd.ShowDialog();
        }

        private void Refrescar()
        {
            List<string> lista1 = new List<string>();
            ccbefecto.setLista<SINTOMA>((List<SINTOMA>)Utiles.Util.GetSintomas());
            ((List<SINTOMA>)Utiles.Util.GetSintomas()).ForEach(d => { lista1.Add(d.VEFECTO); });
            ccbefecto.Items = lista1;
        }

        private void Remover(string o)
        {
            CDiagnoctico.Diagnoctico.RemoverPadecimiento(o);
        }

        private void btningresarsintoma_Click(object sender, EventArgs e)
        {
            try
            {
                SINTOMA sig = ccbefecto.Seleccion<SINTOMA>();
                if (CDiagnoctico.Diagnoctico.AgregarSintoma(sig))
                {
                    udlistefecto.AddSource(sig.VEFECTO);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debes ingresar un sintoma", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //----------------------------------------------------------
        public DiagnosticoChanged diagnosticoChanged;
        public delegate void DiagnosticoChanged();

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.Width == 477)
            {
                this.Visible = false;
                this.Width = 752;
                TransitionPanel.ShowSync(this);
            }
            else
            {
                //this.Visible = false;
                this.Width = 477;
                TransitionPanel.ShowSync(this);
            }
        }
    }
}
