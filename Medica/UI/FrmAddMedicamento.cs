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


namespace UI
{
    public partial class FrmAddMedicamentos : FormBase, CVentanaPlugin.IVentana
    {
        public FrmAddMedicamentos(MEDICAMENTO m)
        {
            InitializeComponent();
            Refrescar();
            Compocicion = Esteroquimica = "";
            adulto = true;
            CAddMedicamento.Medicamento.Clean();
            if (m != null)
                CargarM(m);
        }

        private void CargarM(MEDICAMENTO m)
        {
            if (m.VCOMPOSIION != null)
                txtCompoEstero.Text = m.VCOMPOSIION;
            Compocicion = (String.IsNullOrEmpty(m.VCOMPOSIION)) ? "" : m.VCOMPOSIION;
            Esteroquimica = (String.IsNullOrEmpty(m.VESTEROQUIMICA)) ? "" : m.VESTEROQUIMICA;
            m.MEDI_NOMBRE.ToList().ForEach(n => {
                CAddMedicamento.Medicamento.AgregarNombre(n.VNOMBRE);
                ucnombres.AddSource(n.VNOMBRE);
            });
            m.DOSIS.ToList().ForEach(d => {
                CAddMedicamento.Medicamento.AgregarDosis(d);
                ucdosis.AddSource(d.VRANGO + " Dosis: " + d.DDOSIS + " MAX " + d.DMAX + " MIN " + d.DMIN);
            });
            Adulto = m.DOSIS.ToList().Find(d => d.VRANGO.Equals("Adultos"));
            Menor = m.DOSIS.ToList().Find(d => !d.VRANGO.Equals("Adultos"));
            if (Adulto != null)
            {
                txtdosis.Text = Adulto.DDOSIS + "";
                txtmax.Text = Adulto.DMAX + "";
                txtmin.Text = Adulto.DMIN + "";
            }
            txtdescripcion.Text = m.VDESCRIPCION;
            m.VIA_ADMINISTRACION.ToList().ForEach(v => {
                CAddMedicamento.Medicamento.AgregarVia(v);
                ucVias.AddSource(v.VNOMBRE);
            });
            temporal = m;
        }

        private void Refrescar()
        {
            List<string> lista1 = new List<string>();
            cuVia.setLista((List<VIA_ADMINISTRACION>)Util.GetVias_Administracion());
            ((List<VIA_ADMINISTRACION>)Util.GetVias_Administracion()).ForEach(d => { lista1.Add(d.VNOMBRE); });
            cuVia.Items = lista1;
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
            ucnombres.GetDelete += new CUAdd.DeleteChanged(RemoveNombre);
            ucdosis.GetDelete += new CUAdd.DeleteChanged(RemoveDosis);
            ucVias.GetDelete += new CUAdd.DeleteChanged(RemoveVia);
        }

        private void RemoveVia(string eliminado)
        {
            CAddMedicamento.Medicamento.EliminaVia(eliminado);
        }

        private void RemoveDosis(string eliminado)
        {
            String rango;
            if ((rango = eliminado.Split(' ')[0]).Equals("Adulto"))
                Adulto = null;
            else
                Menor = null;
            CAddMedicamento.Medicamento.EliminaDosis(rango);
        }

        private void RemoveNombre(string eliminado)
        {
            CAddMedicamento.Medicamento.EliminaNombre(eliminado);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (Validar())
                CambiarVentana(new FrmAddMedicamentos2(temporal));
        }

        private bool Validar()
        {
            bool estado;
            estado = ((CAddMedicamento.Medicamento.Dosis.Count>0) &&
                (CAddMedicamento.Medicamento.Vias.Count > 0) &&
                (CAddMedicamento.Medicamento.Nombre.Count > 0) &&
                !String.IsNullOrEmpty(txtdescripcion.Text));
            if (estado)
            {
                CAddMedicamento.Medicamento.Medi = new MEDICAMENTO() {
                    BESTADO = true,
                    DOSIS = CAddMedicamento.Medicamento.Dosis,
                    MEDI_NOMBRE = CAddMedicamento.Medicamento.Nombre,
                    VIA_ADMINISTRACION = CAddMedicamento.Medicamento.Vias,
                    VDESCRIPCION = txtdescripcion.Text,
                    VCOMPOSIION = (String.IsNullOrEmpty(Compocicion)) ? null : Compocicion,
                    VESTEROQUIMICA = (String.IsNullOrEmpty(Esteroquimica)) ? null : Esteroquimica,
                };
            }
            else
                MessageBox.Show("Ingrese todos los campos Requeridos", "Faltan Datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            return estado;
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && validaNulo(new Control[] { txtnombre }))
            {
                if (CAddMedicamento.Medicamento.AgregarNombre(txtnombre.Text))
                    ucnombres.AddSource(txtnombre.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void rbcomposicion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcomposicion.Checked)
            {
                Esteroquimica = txtCompoEstero.Text;
                txtCompoEstero.Text = Compocicion;
            }
        }

        private String Compocicion;
        private String Esteroquimica;
        private MEDICAMENTO temporal;

        private void rbesteroquimica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbesteroquimica.Checked)
            {
                Compocicion = txtCompoEstero.Text;
                txtCompoEstero.Text = Esteroquimica;
            }
        }

        private void btningresarDosis_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidaDosis())
                {
                    if (DosisActual == null)
                    {
                        DosisActual = new DOSIS()
                        {
                            DDOSIS = Convert.ToDecimal(txtdosis.Text),
                            DMAX = Convert.ToDecimal(txtmax.Text),
                            DMIN = Convert.ToDecimal(txtmin.Text),
                            VRANGO = cbRango.Text
                        };
                        CAddMedicamento.Medicamento.AgregarDosis(DosisActual);
                        ucdosis.AddSource(DosisActual.VRANGO + " Dosis: " + DosisActual.DDOSIS + " MAX " + DosisActual.DMAX + " MIN " + DosisActual.DMIN);
                    }
                    else
                    {
                        DosisActual = new DOSIS()
                        {
                            DDOSIS = Convert.ToDecimal(txtdosis.Text),
                            DMAX = Convert.ToDecimal(txtmax.Text),
                            DMIN = Convert.ToDecimal(txtmin.Text),
                            VRANGO = cbRango.Text
                        };
                        CAddMedicamento.Medicamento.ModificarDosis(DosisActual);
                        ucdosis.Clear();
                        CAddMedicamento.Medicamento.Dosis.ForEach(d => { ucdosis.AddSource(d.VRANGO + " Dosis: " + d.DDOSIS + " MAX " + d.DMAX + " MIN " + d.DMIN); });
                    }
                }
                else
                    MessageBox.Show("Ingrese todos los campos Requeridos", "Faltan Datos");
            }
            catch (Exception)
            {
                MessageBox.Show("El Formato correpto es 12,5 o 12.5", "El Formato de los campos no es el Requerido");
            }
        }

        private bool ValidaDosis()
        {
            try
            {
                Convert.ToDecimal(txtdosis.Text);
                Convert.ToDecimal(txtmax.Text);
                Convert.ToDecimal(txtmin.Text);
                return validaNulo(new Control[] { txtdosis, txtmax, txtmin });
            }
            catch (Exception)
            {
                throw;
            }

        }

        private bool validaNulo(Control[] c) {
            foreach (Control item in c)
            {
                if (String.IsNullOrEmpty(item.Text))
                    return false;
            }
            return true;
        }

        private void cbRango_SelectedIndexChanged(object sender, EventArgs e)
        {
            adulto = (cbRango.SelectedIndex == 0);
            if (DosisActual!=null)
            {
                txtdosis.Text = DosisActual.DDOSIS + "";
                txtmax.Text = DosisActual.DMAX + "";
                txtmin.Text = DosisActual.DMIN + "";
            }
            else
                txtdosis.Text = txtmax.Text = txtmin.Text = "";
        }

        private DOSIS Adulto, Menor;
        private DOSIS DosisActual { get { return (adulto) ? Adulto : Menor; } set { if (adulto) Adulto = value; else Menor = value; } }

        private void cuVia_Click(object sender, EventArgs e)
        {
            FrmVias_Administracion frv = new FrmVias_Administracion();
            frv.viaChanged += new FrmVias_Administracion.ViaChanged(Refrescar);
            frv.Visible = true;
        }

        private void btningresarVia_Click(object sender, EventArgs e)
        {
            try
            {
                VIA_ADMINISTRACION via = cuVia.Seleccion<VIA_ADMINISTRACION>();
                if (CAddMedicamento.Medicamento.AgregarVia(via))
                {
                    ucVias.AddSource(via.VNOMBRE);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debes ingresar una Via de Administracion", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool adulto;
    }
}
