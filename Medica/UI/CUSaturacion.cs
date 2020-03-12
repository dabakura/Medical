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
    public partial class CUSaturacion : UserControl
    {
        public CUSaturacion()
        {
            InitializeComponent();
            CUSaturacion_Load();
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

        public bool TextIngreso
        {
            get { return txtTemperatura.Visible; }
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
                FijarSaturacion();
            }
        }

        private void SalvaSaturacion(int d)
        {
            if (DialogResult.Yes == MessageBox.Show("Guardar la nueva Temperatura", "Temperatura", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                CargaSaturacion(d);
                if (salvarSaturacion != null)
                    salvarSaturacion.Invoke(new SIGNOS_VITALES() { ISATURACION = d, DTFECHA = DateTime.Now });
                invocador(Miestado(d));

            }

        }

        private void CargaSaturacion(int d)
        {
            ControlValue(d);
            if (GetSaturaciones().Count > 14)
                GetSaturaciones().RemoveAt(0);
            GetSaturaciones().Add(new SIGNOS_VITALES() { ISATURACION = d, DTFECHA = DateTime.Now });
        }

        private void ControlValue(int d)
        {
            pbTemperatura.Value = d;
            lbText.Text = d + ".Sp";
            labelbarra.Height = d;
            labelbarra.Location = new Point(labelbarra.Location.X, 34 + (150 - d));
        }

        private void FijarSaturacion()
        {
            try
            {
                int d = Convert.ToInt32(txtTemperatura.Text);
                if (d > 0 && d < 151)
                {
                    SalvaSaturacion(d);
                    txtTemperatura.Clear();
                }
            }
            catch (Exception) { txtTemperatura.Clear(); }
        }
        
        public Utiles.EventoEstado Miestado(int d)
        {
            if (d > 110)
                return Utiles.EventoEstado.Alto;
            else if (d < 90)
                return Utiles.EventoEstado.Bajo;
            return Utiles.EventoEstado.Normal;
        }

        private void Colorea(Utiles.EventoEstado index)
        {
            lbText.ForeColor = pbTemperatura.ProgressColor = Utiles.EventoColor(index);
            labelbarra.BackgroundImage = images[(int)index];
            bunifuDataViz1.colorSet = new List<Color>() { Utiles.EventoColor(index) };
        }

        private void invocador(Utiles.EventoEstado index)
        {
            Colorea(index);
            CargarSignos();
            if (saturarion != null)
                saturarion.Invoke(index);
        }

        private void CUSaturacion_Load()
        {
            Ingresar = true;
            CentrarLabel();
            bunifuDataViz1.colorSet = new List<Color>() { Color.DeepSkyBlue };
            images = new Image[] { Properties.Resources.red, Properties.Resources.green, Properties.Resources.blue };
            timer1.Start();
        }


        private void CargarSignos()
        {
            Bunifu.DataViz.Canvas data = new Bunifu.DataViz.Canvas();
            Bunifu.DataViz.DataPoint point = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_area);
            if (GetSaturaciones().Count > 0)
            {
                foreach (SIGNOS_VITALES s in GetSaturaciones())
                {
                    point.addxy("new Date(" + s.DTFECHA.Year + "," + s.DTFECHA.Month + "," + s.DTFECHA.Day + "," + s.DTFECHA.Hour + "," + s.DTFECHA.Minute + "," + s.DTFECHA.Second + ")", s.ISATURACION.ToString());
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
                vi.ForEach(s =>
                {
                    if (s.ISATURACION != null)
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
            if (v.Count > 0)
            {
                int d = Convert.ToInt32(v.Last().ISATURACION);
                ControlValue(d);
                Colorea(Miestado(d));
            }

            return v;
        }

        private Random r = new Random();
        private bool Ingresar;
        public SalvarSaturacion salvarSaturacion;
        public delegate void SalvarSaturacion(SIGNOS_VITALES saturacion);
        public SaturacionEstado saturarion;
        public delegate void SaturacionEstado(Utiles.EventoEstado estado);
        private Image[] images;
        private List<SIGNOS_VITALES> saturacion;

        public List<SIGNOS_VITALES> GetSaturaciones() {
            return (saturacion != null) ? saturacion : saturacion = new List<SIGNOS_VITALES>();
        }

        public void SetSaturaciones(List<SIGNOS_VITALES> value)
        {
            saturacion = Start(value);
            CargarSignos();
        }
       

    }
}
