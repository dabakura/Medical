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

namespace UI
{
    public partial class FrmAddPaciente : FormBase, CVentanaPlugin.IVentana
    {
        public FrmAddPaciente(PACIENTE p)
        {
            InitializeComponent();
            Refrescar();
            CAddPaciente.Paciente.Clean();
            if (p != null)
                CargarP(p);
        }

        private void CargarP(PACIENTE p)
        {
            btnAccion.ButtonText = "Modificar";
            txtcedula.Text = p.VIDENTIFICACION;
            txtcedula.Enabled = false;
            txtapellido1.Text = p.DATOSPERSONALES.VPRIMERAPELLIDO;
            txtapellido2.Text = p.DATOSPERSONALES.VSEGUNDOPELLIDO;
            txtestatura.Text = p.DTALLA.ToString();
            txtnombre.Text = p.DATOSPERSONALES.VNOMBRE;
            txtpeso.Text = p.DPESO.ToString();
            dtnacimiento.Value = p.DATOSPERSONALES.DTFECHANACIMIENTO;
            cuGenero.Genero = (p.DATOSPERSONALES.VGENERO.Equals("Masculino"));
            cddiagnostico.TextSelect = p.DIAGNOSTICO.VDIAGNOSTICO;
            p.PADECIMIENTO.ToList().ForEach(pa =>
            {
                if (CAddPaciente.Paciente.AgregarPadecimiento(pa))
                {
                    uclistapade.AddSource(pa.DIAGNOSTICO.VDIAGNOSTICO);
                }
            });
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
            uclistapade.GetDelete += new CUAdd.DeleteChanged(Remover);
        }

        private void cuComboBoxAdd1_Click(object sender, EventArgs e)
        {
            FrmDiagnostico frd = new FrmDiagnostico();
            frd.diagnosticoChanged += new FrmDiagnostico.DiagnosticoChanged(Refrescar);
            frd.Visible = true;
        }

        private void pnBody_SizeChanged(object sender, EventArgs e)
        {
            paneliz.Size = panelder.Size = new Size(pnBody.Size.Width / 2, paneliz.Height);
            paneliniz.Size = panelinde.Size = new Size((int)(bunifuCardspersonales.Size.Width / 2), paneliniz.Height);
            dtnacimiento.AutoSize = false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Comprobacion.ValidarCampos(pnBody,errorProvider1))
            {
                DIAGNOSTICO diagnostico;
                try
                {
                    diagnostico = cddiagnostico.Seleccion<DIAGNOSTICO>();
                    DATOSPERSONALES persona = new DATOSPERSONALES()
                    {
                        VCEDULA = txtcedula.Text,
                        VNOMBRE = txtnombre.Text,
                        VPRIMERAPELLIDO = txtapellido1.Text,
                        VSEGUNDOPELLIDO = txtapellido2.Text,
                        DTFECHANACIMIENTO = dtnacimiento.Value,
                        VGENERO = (cuGenero.Genero) ? "Masculino" : "Femenino"
                    };
                    PACIENTE paciente = new PACIENTE()
                    {
                        VIDENTIFICACION = txtcedula.Text,
                        IDIAGNOSTICO = diagnostico.IID,
                        DPESO = Convert.ToDecimal(txtpeso.Text),
                        DTALLA = Convert.ToDecimal(txtestatura.Text),
                        DATOSPERSONALES = persona,
                        DIAGNOSTICO = diagnostico,
                    };
                    try
                    {
                        if (btnAccion.ButtonText.Equals("Modificar"))
                        {
                            if (CAddPaciente.Paciente.Modificar(paciente))
                            {
                                MessageBox.Show("Se ha modificado el Registro con Exito", "Modifiacación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CambiarVentana(new FrmPacientes());
                            }
                        }
                        else
                        {
                            if (CAddPaciente.Paciente.Guardar(paciente))
                            {
                                MessageBox.Show("Se ha Guardado el Registro con Exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CambiarVentana(new FrmPacientes());
                            }
                            else
                                MessageBox.Show("No se ha podido guardar el Registro\nDado que el paciente ya estaba registrado", "El paciente ya estaba registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Debes ingresar el Diagnostico Actual", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            panelfin.Visible = !chbpadeestado.Checked;
        }

        private void Refrescar()
        {
            List<string> lista1 = new List<string>();
            cdpadecimiento.setLista<DIAGNOSTICO>((List<DIAGNOSTICO>)Util.GetDiagnosticos());
            cddiagnostico.setLista<DIAGNOSTICO>((List<DIAGNOSTICO>)Util.GetDiagnosticos());
            ((List<DIAGNOSTICO>)Util.GetDiagnosticos()).ForEach(d => { lista1.Add(d.VDIAGNOSTICO); });
            cddiagnostico.Items = cdpadecimiento.Items = lista1;
        }

        private void Remover(string o)
        {
            CAddPaciente.Paciente.RemoverPadecimiento(o);
        }

        private void btningresarpadecimiento_Click(object sender, EventArgs e)
        {
            try
            {
                DIAGNOSTICO dgt = cdpadecimiento.Seleccion<DIAGNOSTICO>();
                PADECIMIENTO p = new PADECIMIENTO()
                {
                    IIDDIAGNOSTICO = dgt.IID,
                    DTFECHAINICIO = dtpadeinicio.Value,
                    BESTADO = chbpadeestado.Checked,
                    DIAGNOSTICO = dgt
                };
                if (chbpadeestado.Checked)
                    p.DTFECHAFINALIZACION = dtpadefin.Value;
                if (CAddPaciente.Paciente.AgregarPadecimiento(p))
                {
                    uclistapade.AddSource(dgt.VDIAGNOSTICO);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debes ingresar un diagnostico", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            CambiarVentana(new FrmPacientes());
        }
    }
}
