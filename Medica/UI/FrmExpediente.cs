using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BS;
using InterfazPlugin;
using DO;

namespace UI
{
    public partial class FrmExpediente : FormBase, CVentanaPlugin.IVentana
    {
        public FrmExpediente()
        {
            InitializeComponent();
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
            Lista = Utiles.DeSerializarBINARY<Expediente>("Expediente.bak");
            if (Lista != null)
            {
                try
                {
                    expediente = Lista.Find(e => e.ID.Equals(Utiles.Util.Paciente.VIDENTIFICACION));
                }
                catch (Exception)
                {
                    expediente = null;
                }
            }
        }

        private Expediente expediente;
        private List<Expediente> Lista;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (expediente != null && expediente.Images.Count>0)
            {
                CambiarVentana(new FrmExpedirnteImagen(expediente));
            }
            else
                MessageBox.Show("No hay registros para este Paciente","No hay Imagenes disponibles",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void panelExp_DragEnter(object sender, DragEventArgs e)
        {
            string data = ((string[])e.Data.GetData("FileName", true))[0];
            if (formatos.Any(f => data.ToLower().EndsWith(f)))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panelExp_DragDrop(object sender, DragEventArgs e)
        {
            Image imagen;
            string data = ((string[])e.Data.GetData("FileName", true))[0];
            if (formatos.Any(f => data.ToLower().EndsWith(f)))
            {
                imagen = Image.FromFile(data);
                panelExp.BackgroundImage = imagen;
                if (DialogResult.Yes == MessageBox.Show("Desea Guardar esta Imagen en el Expediente","Salvar",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    if (expediente == null)
                    {
                        expediente = new Expediente() { ID = Utiles.Util.Paciente.VIDENTIFICACION };
                        expediente.Images.Add(imagen);
                        if (Lista == null)
                            Lista = new List<Expediente> { expediente };
                        else
                            Lista.Add(expediente);
                    }
                    else
                        expediente.Images.Add(imagen);
                    Utiles.SerializarBINARY<Expediente>(Lista, "Expediente.bak");
                }
            }
        }

        private String[] formatos = new String[] { "jpg", "jpeg", "png", "gif", "bmp", "dib", "jpe", "jfif" };

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (expediente != null && expediente.Images.Count>0)
            {
                if (DialogResult.Yes == MessageBox.Show("Seguro Desea Borrar Todas Las Imagenes En El Expediente", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    expediente.Images.Clear();
                    Utiles.SerializarBINARY<Expediente>(Lista, "Expediente.bak");
                }
            }
            else
                MessageBox.Show("Este Paciente no tiene registros Guardados","No hay Registros",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
