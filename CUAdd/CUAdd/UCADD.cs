using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUAdd
{
    public delegate void DeleteChanged(string eliminado);

    public partial class UCADD : UserControl
    {
        public UCADD()
        {
            InitializeComponent();
        }
        public void AddSource(string d)
        {
            this.cuadd.AddSource(d);
        }

        public DeleteChanged GetDelete
        {
            get { return this.cuadd.Delete; }
            set { this.cuadd.Delete += value; }
        }

        public void Clear()
        {
            this.cuadd.Clear();
        }
    }
}
