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
    public partial class FrmSintoma : Form
    {
        public FrmSintoma()
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
                        estado = CSintoma.Sintoma.Guardar(new SINTOMA() { VEFECTO = txtSintoma.Text, VDESCRIPCION = txtDescripcion.Text });
                    else return;
                }
                else 
                {
                    if (Comprobacion.ValidarCampos(this, errorProvider1))
                    {
                        sintoma.VEFECTO = txtSintoma.Text;
                        sintoma.VDESCRIPCION = txtDescripcion.Text;
                        estado = CSintoma.Sintoma.Modificar(sintoma);
                    }
                    else return;
                }
                if (estado)
                {
                    MessageBox.Show("Se ha realizado la operaciòn correptamente", "Operaciòn Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sintomaChanged.Invoke();
                    this.Close();
                } 
                else
                    MessageBox.Show("Por Favor compruebe los Campos o\nla existencia del sintoma ingresado", "La Operaciòn Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "La Operaciòn Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiagnostico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && rbModificar.Checked)
                if ((sintoma = Utiles.Util.GetSintoma(txtSintoma.Text)) != null)
                    txtDescripcion.Text = sintoma.VDESCRIPCION;
                else
                {
                    MessageBox.Show("No existe este sintoma", "No se encuentra registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Comprobacion.LimpiarCampos(this);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private SINTOMA sintoma;

        private void FrmSintoma_Load(object sender, EventArgs e)
        {
            txtSintoma.AutoCompleteCustomSource = CSintoma.Sintoma.getAutoCompleteString();
            txtSintoma.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void rbAceptar_CheckedChanged(object sender, EventArgs e)
        {
            Comprobacion.LimpiarCampos(this);
        }
        
        public SintomaChanged sintomaChanged;
        public delegate void SintomaChanged();
    }
}
