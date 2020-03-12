using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazPlugin;
using BS;
using DO;
using System.Diagnostics;

namespace UI
{
    public partial class FrmExpedirnteImagen : FormBase, CVentanaPlugin.IVentana
    {

        public FrmExpedirnteImagen(Expediente e)
        {
            InitializeComponent();
            exp = e;
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
            Index = 0;
            MAX = exp.Images.Count;
            pbImagen.Image = exp.Images.ElementAt(Index);
        }

        private void pbRight_MouseEnter(object sender, EventArgs e)
        {
            this.pbRight.Image = Properties.Resources.right;
        }

        private void pbRight_MouseLeave(object sender, EventArgs e)
        {
            this.pbRight.Image = null;
        }

        private void pbLeft_MouseLeave(object sender, EventArgs e)
        {
            this.pbLeft.Image = null;
        }

        private void pbLeft_MouseEnter(object sender, EventArgs e)
        {
            this.pbLeft.Image = Properties.Resources.left;
        }

        private void pbRight_Click(object sender, EventArgs e)
        {
            Index++;
            Mover();
        }

        private void pbLeft_Click(object sender, EventArgs e)
        {
            Index--;
            Mover();
        }

        private void Mover()
        {
            if (Index == MAX)
                Index = 0;
            if (Index == -1)
                Index = (MAX - 1);
            pbImagen.Image = exp.Images.ElementAt(Index);
        }

        private Expediente exp;
        private int Index, MAX;

        private void pbImagen_Click(object sender, EventArgs e)
        {
            exp.Images.ElementAt(Index).Save("tempImage.png", ImageFormat.Png);
            Process.Start("tempImage.png");
        }
    }
}
