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
    public partial class CUCarpeta : UserControl
    {
        public CUCarpeta()
        {
            InitializeComponent();
        }

        public Color CardColorBack
        {
            get { return this.bunifuCards1.BackColor; }
            set { this.bunifuCards1.BackColor = value; }
        }

        public Color CardColor
        {
            get { return this.bunifuCards1.color; }
            set { this.bunifuCards1.color = value; }
        }

        public Color ButtonColor
        {
            get { return this.bunifuTileButton1.color; }
            set { this.bunifuTileButton1.color = value; }
        }

        public Color ButtonForeColor
        {
            get { return this.bunifuTileButton1.ForeColor; }
            set { this.bunifuTileButton1.ForeColor = value; }
        }

        public Color ButtonColorActive
        {
            get { return this.bunifuTileButton1.colorActive; }
            set { this.bunifuTileButton1.colorActive = value; }
        }

        public string LabelText
        {
            get { return this.bunifuTileButton1.LabelText; }
            set { this.bunifuTileButton1.LabelText = value; }
        }

        public Image ImageIco
        {
            get { return this.bunifuTileButton1.Image; }
            set { this.bunifuTileButton1.Image = value; }
        }

        private void bunifuCards1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
