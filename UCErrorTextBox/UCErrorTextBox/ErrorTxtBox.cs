using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCErrorTextBox
{
    public partial class ErrorTxtBox : TextBox
    {
        public ErrorTxtBox()
        {
            InitializeComponent();
        }

        public Boolean Validar
        {
            get;
            set;
        }

        public Boolean AutoClear
        {
            get;
            set;
        }

        public Boolean ValidarContraseñas
        {
            get;
            set;
        }
        public Boolean ValidarDouble
        {
            get;
            set;
        }
        public Boolean ValidarInt32
        {
            get;
            set;
        }


        private void ErrorTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidarInt32)
            {
                if (!Char.IsControl(e.KeyChar))
                    if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
            }
            else if (ValidarDouble)
            {
                if (!Char.IsControl(e.KeyChar))
                    if (  (e.KeyChar != '.' && e.KeyChar != ',') && !Char.IsDigit(e.KeyChar)) e.Handled = true;
            }
        }
    }
}
