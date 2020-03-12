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
using BS;

namespace UI
{
    public partial class CUTemperatura : UserControl
    {
        public CUTemperatura()
        {
            InitializeComponent();
            CUTemperatura_Load();
        }

        private void bunifuCircleProgressbar1_Resize(object sender, EventArgs e)
        {
            CentrarLabel();
        }

        private void CentrarLabel()
        {
            int m = pbTemperatura.Size.Width;
            lbText.Location = new Point(((int)(m - 128) / 2), ((int)(m - 42) / 2));
        }

        public bool TextIngreso { get { return txtTemperatura.Visible; }
            set
            {
                trackBar1.Visible = txtTemperatura.Visible = value;
                trackBar1.Value = pbTemperatura.Value;
            }
        }

        private void bunifuCircleProgressbar1_Click(object sender, EventArgs e)
        {
            TextIngreso = Ingresar;
            Ingresar = !Ingresar;
            if (Ingresar)
            {
                FijarTemperatura();
            }
        }

        private void SalvarTemperatura(double d)
        {
            if (DialogResult.Yes == MessageBox.Show("Guardar la nueva Temperatura", "Temperatura", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                CargaTemperatura(d);
                if (salvalTemperatura != null)
                    salvalTemperatura.Invoke(new SIGNOS_VITALES() { DTEMPERATURA = Convert.ToDecimal(d), DTFECHA = DateTime.Now });
                invocador(Miestado(d));
            }
                
        }

        private void CargaTemperatura(double d)
        {
            ControlValue(d);
            if (GetTemperaturas().Count > 14)
                GetTemperaturas().RemoveAt(0);
            GetTemperaturas().Add(new SIGNOS_VITALES() { DTEMPERATURA = Convert.ToDecimal(d), DTFECHA = DateTime.Now});
        }

        private void ControlValue(double d)
        {
            pbTemperatura.Value = (int)d;
            lbText.Text = Math.Round(d, 1) + "°C";
            labelbarra.Height = ((int)(d * 2));
            labelbarra.Location = new Point(labelbarra.Location.X, 44 + (100 - ((int)(d * 2))));
        }

        private void FijarTemperatura()
        {
            try
            {
                double d = Convert.ToDouble(txtTemperatura.Text);
                if (d>0 && d<51)
                {
                    SalvarTemperatura(d);
                    txtTemperatura.Clear();
                }
            }
            catch (Exception){ txtTemperatura.Clear(); }
        }
        
        public Utiles.EventoEstado Miestado(double d)
        {
            if (d > 37.7)
                return Utiles.EventoEstado.Alto;
            else if (d < 36.3)
                return Utiles.EventoEstado.Bajo;
            return Utiles.EventoEstado.Normal;
        }

        private void Colorea(Utiles.EventoEstado index)
        {
            labelbarra.BackColor = lbText.ForeColor = pbTemperatura.ProgressColor = Utiles.EventoColor(index);
            pictureBoxTer.Image = images[(int)index];
            bunifuDataViz1.colorSet = new List<Color>() { Utiles.EventoColor(index) };
        }
        private void invocador(Utiles.EventoEstado index)
        {
            Colorea(index);
            CargarSignos();
            if (temperatura != null)
                temperatura.Invoke(index);
        }

        private void CUTemperatura_Load()
        {
            Ingresar = true;
            CentrarLabel();
            bunifuDataViz1.colorSet = new List<Color>() { Color.DeepSkyBlue };
            images = new Image[] { Properties.Resources.termometro4, Properties.Resources.termometro3, Properties.Resources.termometro2};
            timer1.Start();
        }

        
        private void CargarSignos()
        {
            Bunifu.DataViz.Canvas data = new Bunifu.DataViz.Canvas();
            Bunifu.DataViz.DataPoint point = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_area);
            if (GetTemperaturas().Count>0)
            {
                foreach (SIGNOS_VITALES s in GetTemperaturas())
                {
                    point.addxy("new Date("+s.DTFECHA.Year + "," + s.DTFECHA.Month + "," + s.DTFECHA.Day + "," + s.DTFECHA.Hour + "," + s.DTFECHA.Minute + "," + s.DTFECHA.Second + ")", ((Int32)s.DTEMPERATURA).ToString());
                }
            }
            data.addData(point);
            bunifuDataViz1.Render(data);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtTemperatura.Text = trackBar1.Value + "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarSignos();
            timer1.Stop();
        }

        private List<SIGNOS_VITALES> Start(List<SIGNOS_VITALES> vi)
        {
            List<SIGNOS_VITALES> v = new List<SIGNOS_VITALES>();
            if (vi != null && vi.Count > 0)
            {
                vi.Reverse();
                vi.ForEach( s => 
                {
                    if (s.DTEMPERATURA != null)
                    {
                        if (v.Count < 15)
                            v.Add(s);
                        else
                            return;
                    }
                });
                vi.Reverse();
            }
            v.Reverse();
            if (v.Count>0)
            {
                double d = Convert.ToDouble(v.Last().DTEMPERATURA);
                ControlValue(d);
                Colorea(Miestado(d));
            }
            
            return v;
        }

        private Random r = new Random();
        private bool Ingresar;
        public SalvalTemperatura salvalTemperatura;
        public delegate void SalvalTemperatura(SIGNOS_VITALES temperatura);
        public TemperaturaEstado temperatura;
        public delegate void TemperaturaEstado(Utiles.EventoEstado estado);
        private Image[] images;
        private List<SIGNOS_VITALES> signos;
        public List<SIGNOS_VITALES> GetTemperaturas()
        {
            return (signos != null) ? signos : signos = new List<SIGNOS_VITALES>();
        }

        public void SetTemperaturas(List<SIGNOS_VITALES> value)
        {
            signos = Start(value);
            CargarSignos();
        }
        
    }
}
