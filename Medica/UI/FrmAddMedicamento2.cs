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
    public partial class FrmAddMedicamentos2 : FormBase, CVentanaPlugin.IVentana
    {
        public FrmAddMedicamentos2(MEDICAMENTO m)
        {
            InitializeComponent();
            Refrescar();
            if (m != null)
                CargarM(m);
        }

        private void CargarM(MEDICAMENTO m)
        {
            btnAccion.ButtonText = "Modificar";
            CAddMedicamento.Medicamento.Medi.ICODIGO = m.ICODIGO;
            m.SINTOMA.ToList().ForEach(n => {
                CAddMedicamento.Medicamento.AgregarEfecto(n);
                ucEfetos.AddSource(n.VEFECTO);
            });
            m.CONTRAINDICACION_DIAGNOSTICO.ToList().ForEach(n => {
                CAddMedicamento.Medicamento.AgregarContraDiagnostico(n);
                ucContraDiagnostico.AddSource(n.DIAGNOSTICO.VDIAGNOSTICO);
            });
            m.CONTRAINDICACION_SINTOMA.ToList().ForEach(n => {
                CAddMedicamento.Medicamento.AgregarContraSintoma(n);
                ucContraSintoma.AddSource(n.SINTOMA.VEFECTO);
            });
            m.CONTRAINDICACION_MEDICAMENTO.ToList().ForEach(n => {
                CAddMedicamento.Medicamento.AgregarContraMedicamento(n);
                ucmedicamento.AddSource(n.MEDICAMENTO1.MEDI_NOMBRE.First().VNOMBRE);
            });
            m.INDICACION_DIAGNOSTICO.ToList().ForEach(n => {
                CAddMedicamento.Medicamento.AgregarIndicaDiagnostico(n);
                ucDiagnostico.AddSource(n.DIAGNOSTICO.VDIAGNOSTICO);
            });
            m.INDICACION_SINTOMA.ToList().ForEach(n => {
                CAddMedicamento.Medicamento.AgregarIndicaSintoma(n);
                ucSintomas.AddSource(n.SINTOMA.VEFECTO);
            });
        }

        private void Refrescar()
        {
            List<string> list1 = ((List<DIAGNOSTICO>)Util.GetDiagnosticos()).ConvertAll(p => Converter<DIAGNOSTICO>(p));
            List<string> list3 = ((List<SINTOMA>)Util.GetSintomas()).ConvertAll(p => Converter<SINTOMA>(p));
            cuContraDiagnostico.setLista((List<DIAGNOSTICO>)Util.GetDiagnosticos());
            cudiagnostico.setLista((List<DIAGNOSTICO>)Util.GetDiagnosticos());
            cuContraSintomas.setLista((List<SINTOMA>)Util.GetSintomas());
            cuEfecto.setLista((List<SINTOMA>)Util.GetSintomas());
            cuSintomas.setLista((List<SINTOMA>)Util.GetSintomas());
            cuSintomas.Items = cuEfecto.Items = cuContraSintomas.Items = list3;
            cuContraDiagnostico.Items = cudiagnostico.Items = list1;
        }

        private string Converter<T>(dynamic convertir)
        {
            if (convertir is DIAGNOSTICO) 
            {
                DIAGNOSTICO c = (DIAGNOSTICO)convertir;
                return c.VDIAGNOSTICO;
            }
            else if (convertir is SINTOMA)
            {
                SINTOMA c = (SINTOMA)convertir;
                return c.VEFECTO;
            }
            return "";
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
            ucContraDiagnostico.GetDelete += new CUAdd.DeleteChanged(EliminaContraDiagnostico);
            ucContraSintoma.GetDelete += new CUAdd.DeleteChanged(EliminaContraSintoma);
            ucDiagnostico.GetDelete += new CUAdd.DeleteChanged(EliminaDiagnostico); 
            ucmedicamento.GetDelete += new CUAdd.DeleteChanged(EliminaMedicamento);
            ucSintomas.GetDelete += new CUAdd.DeleteChanged(EliminaSintoma);
            ucEfetos.GetDelete += new CUAdd.DeleteChanged(EliminaEfecto);
            m = ((List<MEDICAMENTO>)Util.GetMedicamentos());
            if (m!=null)
                m.ForEach(me => cbMedicamento.Items.Add(me.MEDI_NOMBRE.First().VNOMBRE));
        }

        private void EliminaContraSintoma(string eliminado)
        {
            CAddMedicamento.Medicamento.EliminaContraSintoma(eliminado);
        }

        private void EliminaEfecto(string eliminado)
        {
            CAddMedicamento.Medicamento.EliminaEfecto(eliminado);
            CAddMedicamento.Medicamento.EliminaContraSintoma(eliminado);
        }

        private void EliminaMedicamento(string eliminado)
        {
            CAddMedicamento.Medicamento.EliminaMedicamento(eliminado);
        }

        private void EliminaSintoma(string eliminado)
        {
            CAddMedicamento.Medicamento.EliminaSintoma(eliminado);
        }

        private void EliminaContraDiagnostico(string eliminado)
        {
            CAddMedicamento.Medicamento.EliminaContraDiagnostico(eliminado);
        }

        private void EliminaDiagnostico(string eliminado)
        {
            CAddMedicamento.Medicamento.EliminaDiagnostico(eliminado);
        }

        private void cuSintomas_Click(object sender, EventArgs e)
        {
            FrmSintoma frd = new FrmSintoma();
            frd.sintomaChanged += new FrmSintoma.SintomaChanged(Refrescar);
            frd.Visible = true;
        }

        private void cudiagnostico_Click(object sender, EventArgs e)
        {
            FrmDiagnostico frd = new FrmDiagnostico();
            frd.diagnosticoChanged += new FrmDiagnostico.DiagnosticoChanged(Refrescar);
            frd.Visible = true;
        }

        private String Descripcion(Control c)
        {
            return (String.IsNullOrEmpty(c.Text) || c.Text.Equals("Descripción")) ? null : c.Text;
        }

        private List<MEDICAMENTO> m;

        private void btningresarefecto_Click(object sender, EventArgs e)
        {
            try
            {
                SINTOMA s = cuEfecto.Seleccion<SINTOMA>();
                if (CAddMedicamento.Medicamento.AgregarEfecto(s))
                {
                    ucEfetos.AddSource(s.VEFECTO);
                    ingresarContraSintoma(s);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Primero seleccione el Efecto a ingresar","Faltan datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btningresarSintoma_Click(object sender, EventArgs e)
        {
            try
            {
                SINTOMA s = cuSintomas.Seleccion<SINTOMA>();
                INDICACION_SINTOMA indi = new INDICACION_SINTOMA() { VDESCRIPCION= Descripcion(txtdescsintomas), SINTOMA = s, ISINTOMA = s.IID};
                if (CAddMedicamento.Medicamento.AgregarIndicaSintoma(indi))
                {
                    ucSintomas.AddSource(s.VEFECTO);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Primero seleccione el Sintoma a ingresar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtdescsintomas.Text = "Descripción";
        }

        private void btningresarContraSintoma_Click(object sender, EventArgs e)
        {
            try
            {
                SINTOMA s = cuContraSintomas.Seleccion<SINTOMA>();
                ingresarContraSintoma(s);
            }
            catch (Exception)
            {
                MessageBox.Show("Primero seleccione el Sintoma a ingresar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtdescContraSintoma.Text = "Descripción";
        }

        private void ingresarContraSintoma(SINTOMA s)
        {
            CONTRAINDICACION_SINTOMA contra = new CONTRAINDICACION_SINTOMA() { VDESCRIPCION = Descripcion(txtdescContraSintoma), SINTOMA = s, IIDSINTOMA = s.IID };
            if (CAddMedicamento.Medicamento.AgregarContraSintoma(contra))
            {
                ucContraSintoma.AddSource(s.VEFECTO);
            }
        }

        private void btningresardiagnostico_Click(object sender, EventArgs e)
        {
            try
            {
                DIAGNOSTICO s = cudiagnostico.Seleccion<DIAGNOSTICO>();
                INDICACION_DIAGNOSTICO contra = new INDICACION_DIAGNOSTICO() { VDESCRIPCION = Descripcion(txtdescdiagnostico), DIAGNOSTICO = s, IIDIAGNOSTICO = s.IID };
                if (CAddMedicamento.Medicamento.AgregarIndicaDiagnostico(contra))
                {
                    ucDiagnostico.AddSource(s.VDIAGNOSTICO);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Primero seleccione el Diagnostico a ingresar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtdescdiagnostico.Text = "Descripción";
        }

        private void btnIngresarContraDiagnostico_Click(object sender, EventArgs e)
        {
            try
            {
                DIAGNOSTICO s = cuContraDiagnostico.Seleccion<DIAGNOSTICO>();
                CONTRAINDICACION_DIAGNOSTICO contra = new CONTRAINDICACION_DIAGNOSTICO() { VDESCRIPCION = Descripcion(txtdescContraDiagnostico), DIAGNOSTICO = s, IIDIAGNOSTICO = s.IID };
                if (CAddMedicamento.Medicamento.AgregarContraDiagnostico(contra))
                {
                    ucContraDiagnostico.AddSource(s.VDIAGNOSTICO);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Primero seleccione el Diagnostico a ingresar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtdescContraDiagnostico.Text = "Descripción";
        }

        private void btningresarMendicamento_Click(object sender, EventArgs e)
        {
            try
            {
                MEDICAMENTO s = m.ElementAt(cbMedicamento.SelectedIndex);
                CONTRAINDICACION_MEDICAMENTO contra = new CONTRAINDICACION_MEDICAMENTO() { VDESCRIPCION = Descripcion(txtdescMedicamento), MEDICAMENTO1 = s, IIDMEDICAMENTO = s.ICODIGO };
                if (CAddMedicamento.Medicamento.AgregarContraMedicamento(contra))
                {
                    ucmedicamento.AddSource(s.MEDI_NOMBRE.First().VNOMBRE);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Primero seleccione el Medicamento a ingresar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtdescMedicamento.Text = "Descripción";
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    if (btnAccion.ButtonText.Equals("Modificar"))
                    {
                        if (CAddMedicamento.Medicamento.Modificar(null))
                        {
                            MessageBox.Show("Se ha modificado el Registro con Exito", "Modifiacación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CambiarVentana(new FrmMedicamentos());
                        }
                    }
                    else
                    {
                        if (CAddMedicamento.Medicamento.Guardar(null))
                        {
                            MessageBox.Show("Se ha Guardado el Registro con Exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CambiarVentana(new FrmMedicamentos());
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
        }

        private bool Validar()
        {
            bool estado;
            estado = (((CAddMedicamento.Medicamento.IndiDiag.Count >0) ||
                (CAddMedicamento.Medicamento.IndiSint.Count > 0)));
            if (!estado)
            {
                MessageBox.Show("El Medicamento debe estar indicado para el Tratamiento de algun padecimiento", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return estado;
        }

        private void txtdescsintomas_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text.Equals("Descripción"))
                t.Clear();
        }

        private void txtdescsintomas_Click(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text.Equals("Descripción"))
                t.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CambiarVentana(new FrmMedicamentos());
        }
    }
}
