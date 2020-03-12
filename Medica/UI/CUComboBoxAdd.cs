using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;


namespace UI
{
    public partial class CUComboBoxAdd: UserControl
    {
        public CUComboBoxAdd()
        {
            InitializeComponent();
            list = new List<string>();
        }

        public SelectedIndexChanged SelectedIndex;

        public Font TextFont
        {
            get { return comboBox1.Font; }
            set
            {
                comboBox1.Font = value;
                button1.Size = new Size(comboBox1.Size.Height, comboBox1.Size.Height);
                this.Size = new Size(comboBox1.Size.Width + button1.Size.Width, comboBox1.Size.Height);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndex != null) 
                SelectedIndex.Invoke(comboBox1, e);
        }

        public List<string> Items
        {
            get
            {
                list.Clear();
                foreach (Object item in comboBox1.Items)
                {
                    list.Add(item.ToString());
                }
                return list;
            }
            set
            {
                comboBox1.Items.Clear();
                list = value;
                foreach (string item in value)
                {
                    comboBox1.Items.Add(item);
                }
                this.comboBox1.Refresh();
            }
        }

        //public void Diagnosticos(List<DIAGNOSTICO> d)
        //{
        //    list.Clear();
        //    Diagnosticos1 = d;
        //    foreach (DIAGNOSTICO item in d)
        //        list.Add(item.VDIAGNOSTICO);
        //    Items = list;
        //}

        //public DIAGNOSTICO Diagnostico
        //{
        //    get
        //    {
        //        DIAGNOSTICO d = null;
        //        int indice = comboBox1.SelectedIndex;
        //        if (indice > -1)
        //        {
        //            d = Diagnosticos1.ElementAt(indice);
        //        }
        //        return d;
        //    }
        //}

       public T Seleccion<T>()
        {
            try
            {
                return (T)(((List<T>)diagnosticos).ElementAt(comboBox1.SelectedIndex));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public String TextSelect
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value;
                if (String.IsNullOrEmpty(comboBox1.Text))
                    comboBox1.SelectedItem = value;
                        }
        }

        public String Texto
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }

        public void setLista<T>(List<T> l)
        {
            diagnosticos = l;
        }

        private List<string> list;
        private dynamic diagnosticos;
        public delegate void SelectedIndexChanged(object sender, EventArgs e);
    }
}
