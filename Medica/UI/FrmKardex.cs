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
using DO;
using DAL;

namespace UI
{
    public partial class FrmKardex : FormBase, CVentanaPlugin.IVentana
    {
        public FrmKardex()
        {
            InitializeComponent();
            indexLabel = 0;
            seleccionado = -1;
            Index = -1;
            Modificar = false;
            Refrescar();
        }

        public Panel Panel { get { return pnBody; } set { throw new NotImplementedException(); } }

        public IUtiles Util { get { return Utiles.Util; } set { throw new NotImplementedException(); } }

        public CVentanaPlugin.IVentana Ventana { get { return CWindows.Ventana; } set { throw new NotImplementedException(); } }

        public Image Icono { get { throw new NotImplementedException(); } }

        private List<Libro> descripciones;

        private bool mediselec, mediestado;

        private MEDICAMENTO m;

        private ComboBox[] medicombos;

        private int Index { get; set; }

        private bool Modificar { get; set; }

        private PACIENTE_MEDICAMENTO PacienteMedicamentoSelected { get; set; }

        public List<Libro> Descripciones
        {
            get { return (descripciones != null) ? descripciones : descripciones = new List<Libro>(); }
            set { descripciones = value; flpLateral.Controls.Clear(); CargarLibros(); }
        }

        private void CargarLibros()
        {
            if (Descripciones != null && Descripciones.Count > 0)
            {
                
                indexLabel = 0;
                Descripciones.ForEach(d => flpLateral.Controls.Add(GetLibro(d.Fecha.ToShortDateString())));
                txtDescripcion.Text = LineasNueva(Descripciones.First().Descripcion);
                seleccionado = 0;
            }
            seleccionado = -1;
        }

        public void CambiarVentana(CVentanaPlugin.IVentana ventana)
        {
            Ventana.CambiarVentana(ventana);
        }

        public string LineasNueva(string texto)
        {
            string salida = "";
            foreach (Char item in texto)
            {
                if (item.Equals('\n'))
                    salida += String.Format(Environment.NewLine);
                else
                    salida += item;
            }
            return salida;
        }
       
        private void Refrescar()
        {
            try
            {
                List<string> lista1 = new List<string>();
                cdsintoma.setLista<SINTOMA>((List<SINTOMA>)Util.GetSintomas());
                ((List<SINTOMA>)Util.GetSintomas()).ForEach(d => { lista1.Add(d.VEFECTO); });
                cdsintoma.Items = lista1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void load()
        {
            try
            {
                cuSignos1.SetSignos(CSignosVitales.SignosVitales.GetListSignosVitales(Utiles.Util.Paciente.VIDENTIFICACION));
                Descripciones = Utiles.DeSerializarXML<Libro>("Libros" + Utiles.Util.Paciente.VIDENTIFICACION + ".xml");
                lbPadecimientos.Items.Clear();
                CKardex.Kardex.GetMYPACIENTE().PADECIMIENTO.ToList<PADECIMIENTO>().ForEach(
                    pa => lbPadecimientos.Items.Add(pa.DIAGNOSTICO.VDIAGNOSTICO + "\t\tEstado = " + ((pa.BESTADO) ? "Activo" : "Remición"))
                    );
                txtDiagnostico.Text = CKardex.Kardex.GetMYPACIENTE().DIAGNOSTICO.VDIAGNOSTICO;
                uclistasintoma.GetDelete += new CUAdd.DeleteChanged(Remover);
                CKardex.Kardex.Sintomas.Clear();
                CKardex.Kardex.GetMYPACIENTE().PACIENTE_SINTOMA.ToList().ForEach(ps => CKardex.Kardex.Sintomas.Add(ps));
                CargaSintoma();
                cbMedicamento.AutoCompleteCustomSource = CKardex.Kardex.getAutoCompleteString(cbMedicamento);
                mediselec = mediestado = false;
                medicombos = new ComboBox[] { cbRango, cbMedicamento, cbViaAdministracion };
                this.cuDataGrip3.SetData(CKardex.Kardex.start());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Remover(string eliminado)
        {
            try
            {
                if (CKardex.Kardex.RemoverSintoma(eliminado))
                    CargaSintoma();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Label GetLibro(string texto)
        {
            Label labellibro = new Label();
            labellibro.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            labellibro.ForeColor = Color.DarkRed;
            labellibro.Image = Properties.Resources.libro;
            labellibro.Margin = new Padding(3);
            labellibro.Name = "labellibro" + indexLabel;
            labellibro.Size = new Size(76, 93);
            labellibro.Text = texto;
            labellibro.TextAlign = ContentAlignment.MiddleCenter;
            labellibro.Tag = indexLabel;
            labellibro.Click += new EventHandler(this.labellibro_Click);
            indexLabel++;
            return labellibro;
        }

        private int indexLabel;
        private int seleccionado;

        private void labellibro_Click(object sender, EventArgs e)
        {
            seleccionado = (int)((Label)sender).Tag;
            txtDescripcion.Text = LineasNueva( Descripciones.ElementAt(seleccionado).Descripcion);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (seleccionado > -1)
            {
                Descripciones.RemoveAt(seleccionado);
                txtDescripcion.Clear();
                Utiles.SerializarXML<Libro>(Descripciones, "Libros" + Utiles.Util.Paciente.VIDENTIFICACION + ".xml");
                Descripciones = Utiles.DeSerializarXML<Libro>("Libros" + Utiles.Util.Paciente.VIDENTIFICACION + ".xml");
                MessageBox.Show("Se elimino la Descripción", "Descripción eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Primero Seleccione una Descripción", "No hay Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            seleccionado = -1;
        }

        private void bnguardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDescripcion.Text))
            {
                if (seleccionado == -1)
                    Descripciones.Add(new Libro() { Descripcion = txtDescripcion.Text });
                else
                    Descripciones.ElementAt(seleccionado).Descripcion = txtDescripcion.Text;
                Utiles.SerializarXML<Libro>(Descripciones, "Libros" + Utiles.Util.Paciente.VIDENTIFICACION + ".xml");
                Descripciones = Utiles.DeSerializarXML<Libro>("Libros" + Utiles.Util.Paciente.VIDENTIFICACION + ".xml");
                MessageBox.Show("Se guardo o modifico la Descripción", "Descripción guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Primero Escriba una Descripción", "No hay Descripción", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void cdsintoma_Click(object sender, EventArgs e)
        {
            FrmSintoma frd = new FrmSintoma();
            frd.sintomaChanged += new FrmSintoma.SintomaChanged(Refrescar);
            frd.ShowDialog();
        }

        private void btningresarsintoma_Click(object sender, EventArgs e)
        {
            try
            {
                SINTOMA sig = cdsintoma.Seleccion<SINTOMA>();
                if (sig != null)
                {
                    if (CKardex.Kardex.AgregarSintoma(sig))
                        CargaSintoma();
                }
                else
                    MessageBox.Show("Debes ingresar un sintoma", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaSintoma()
        {
            uclistasintoma.Clear();
            CKardex.Kardex.GetPacienteSintoma().ForEach(s => uclistasintoma.AddSource(s));
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            txtInfo.Visible = Modificar = false;
            txtdosis.Text = txtInfo.Text = "";
            cbRango.Text = cbViaAdministracion.Text = cbMedicamento.Text = "--- Seleccione ---";
            cbMedicamento.Enabled = bgpMedicamento.Visible = true;
        }

        private void btnModificarMedicamento_Click(object sender, EventArgs e)
        {
            if (PacienteMedicamentoSelected != null)
            {
                cbMedicamento.Text = PacienteMedicamentoSelected.MEDICAMENTO.MEDI_NOMBRE.First().VNOMBRE;
                cbMedicamento.Enabled = false;
                cbRango.Text = PacienteMedicamentoSelected.VRANGO;
                cbViaAdministracion.Text = PacienteMedicamentoSelected.VVIAADMINISTRACION;
                txtdosis.Text = Math.Round(PacienteMedicamentoSelected.DDOSIS, 2).ToString();
                txtnota.Text = PacienteMedicamentoSelected.VDESCRIPCION;
                Modificar = bgpMedicamento.Visible = true;
            }
        }

        private void btnEliminarMedicamento_Click(object sender, EventArgs e)
        {
            if (Index > -1 && DialogResult.Yes == MessageBox.Show("Seguro que desea eliminar este medicamento", "Eliminar el medicamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    if (CKardex.Kardex.EliminaMedicamento(PacienteMedicamentoSelected))
                        cuDataGrip3.Removeat(Index);
                    PacienteMedicamentoSelected = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Index = -1;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bgpMedicamento.Visible = false;
        }

        private void cbMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            m = CKardex.Kardex.GetMEDICAMENTO(cbMedicamento.Text, txtInfo, cbViaAdministracion, cbRango);
            txtInfo.Visible = true;
            txtnota.Clear();
            mediestado = (m != null);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (mediestado)
            {
                if (Validar())
                {
                    PACIENTE_MEDICAMENTO pm = new PACIENTE_MEDICAMENTO()
                    {
                        DDOSIS = Convert.ToDecimal(txtdosis.Text),
                        ICODIGO = m.ICODIGO,
                        MEDICAMENTO = m,
                        PACIENTE = CKardex.Kardex.GetMYPACIENTE(),
                        VDESCRIPCION = txtnota.Text,
                        VIDENTIFICACION = Utiles.Util.Paciente.VIDENTIFICACION,
                        VRANGO = cbRango.Text,
                        VVIAADMINISTRACION = cbViaAdministracion.Text
                    };
                    CMedi medi;
                    try
                    {
                        if (Modificar)
                        {
                            if ((medi = CKardex.Kardex.ModificaMedicamento(pm)) != null)
                                this.cuDataGrip3.Modificar(medi);
                        }
                        else
                        {
                            if ((medi = CKardex.Kardex.SetMedicamento(pm)) != null)
                                this.cuDataGrip3.SetMedi(medi);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            bgpMedicamento.Visible = false;
        }

        private void cuDataGrip3_SelectionChanged(object sender, EventArgs e)
        {
            Index = -1;
            PacienteMedicamentoSelected = null;
            if (cuDataGrip3.SelectedRows.Count > 0)
            {
                Index = cuDataGrip3.SelectedRows[0].Index;
                PacienteMedicamentoSelected = cuDataGrip3.GetMedi(Index);
                txtnota.Text = PacienteMedicamentoSelected.VDESCRIPCION;
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                this.cuDataGrip3.SetData(CKardex.Kardex.start());
            }
        }

        private bool Validar()
        {
            try
            {
                Convert.ToDouble(txtdosis.Text);
                medicombos.ToList().ForEach(
                    c => { if (c.Text == "--- Seleccione ---") throw new Exception(); }
                    );
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
