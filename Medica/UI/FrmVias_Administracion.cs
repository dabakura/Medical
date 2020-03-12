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
    public partial class FrmVias_Administracion : Form
    {
        public FrmVias_Administracion()
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
                        estado = CVia_Administracion.Via.Guardar(new VIA_ADMINISTRACION() { VNOMBRE = txtVia.Text, VDESCRIPCION = txtDescripcion.Text });
                    else return;
                }
                else
                {
                    if (Comprobacion.ValidarCampos(this, errorProvider1))
                    {
                        via.VNOMBRE = txtVia.Text;
                        via.VDESCRIPCION = txtDescripcion.Text;
                        estado = CVia_Administracion.Via.Modificar(via);
                    }
                    else return;
                }
                if (estado)
                {
                    MessageBox.Show("Se ha realizado la operaciòn correptamente", "Operaciòn Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    viaChanged.Invoke();
                    this.Close();
                }
                else
                    MessageBox.Show("Por Favor compruebe los Campos o\nla existencia de la Via de Administracion ingresada", "La Operaciòn Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "La Operaciòn Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiagnostico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && rbModificar.Checked)
                if ((via = Utiles.Util.GetVia_Administracion(txtVia.Text)) != null)
                    txtDescripcion.Text = via.VDESCRIPCION;
                else
                {
                    MessageBox.Show("No existe esta Via de Administracion", "No se encuentra registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Comprobacion.LimpiarCampos(this);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private VIA_ADMINISTRACION via;

        private void FrmDiagnostico_Load(object sender, EventArgs e)
        {
            txtVia.AutoCompleteCustomSource = CVia_Administracion.Via.getAutoCompleteString();
            txtVia.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void rbAceptar_CheckedChanged(object sender, EventArgs e)
        {
            Comprobacion.LimpiarCampos(this);
        }
        

        //----------------------------------------------------------
        public ViaChanged viaChanged;
        public delegate void ViaChanged();
        
    }
}
