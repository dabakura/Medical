using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CUGenero : UserControl
    {
        public CUGenero()
        {
            InitializeComponent();
            estado = true;
        }
        private Boolean estado;
        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            estado = !estado;
            CambiaGenero();
        }

        private void CambiaGenero()
        {
            if (estado)
            {
                bunifuSwitch1.BackColor = bunifuSwitch1.Textcolor = bunifuSwitch1.Onoffcolor;
                label1.Text = "Masculino";
                label1.BackColor = bunifuSwitch1.Oncolor;
                bunifuSwitch1.Dock = DockStyle.Right;
                label1.Dock = DockStyle.Fill;
            }
            else
            {
                bunifuSwitch1.BackColor = bunifuSwitch1.Textcolor = bunifuSwitch1.Oncolor;
                label1.Text = "Femenino";
                label1.BackColor = bunifuSwitch1.Onoffcolor;
                bunifuSwitch1.Dock = DockStyle.Left;
                label1.Dock = DockStyle.Fill;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            bunifuSwitch1.Value = !bunifuSwitch1.Value;
            bunifuSwitch1_Click(sender, e);
        }

        public bool Genero
        {
            get { return estado; }
            set { estado = value; CambiaGenero(); }
        }


        public Color OnColor
        {
            get { return bunifuSwitch1.Oncolor; }
            set {
                label1.BackColor = value;
                bunifuSwitch1.Oncolor = value; }
        }

        public Color OffColor
        {
            get { return bunifuSwitch1.Onoffcolor; }
            set
            {
                this.BackColor = value;
                bunifuSwitch1.ForeColor = value;
                bunifuSwitch1.BackColor = value;
                bunifuSwitch1.Onoffcolor = value;
            }
        }

        public Color TextColor
        {
            get { return label1.ForeColor; }
            set { label1.ForeColor = value; }
        }
    }
}
