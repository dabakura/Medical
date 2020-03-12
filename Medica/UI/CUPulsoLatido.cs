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
    public partial class CUPulsoLatido : UserControl
    {
        public CUPulsoLatido()
        {
            InitializeComponent();
            CUPulsoLatido_Load();
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
                FijarPulso();
            }
        }
        
        private void FijarPulso()
        {
            try
            {
                int d = Convert.ToInt32(txtTemperatura.Text);
                if (d > 0 && d < Valor())
                {
                    GetSolucion().SalvaPulso(d);
                    txtTemperatura.Clear();
                }
            }
            catch (Exception) { txtTemperatura.Clear(); }
        }
        

        private void Colorea(Utiles.EventoEstado index)
        {
            lbText.ForeColor = pbTemperatura.ProgressColor = Utiles.EventoColor(index);
            iconcorazon = images[(int)index];
            timer2.Interval = frecuencia[(int)index];
            switchbutton.OnColor = Utiles.EventoColor(index);
            bunifuDataViz1.colorSet = new List<Color>() { Utiles.EventoColor(index) };
        }
        
        private void CUPulsoLatido_Load()
        {
            estado = switchbutton.Value;
            Solucions = new ISolucion[] { new ControlPulso(this), new ControlPresion(this) };
            Ingresar = true;
            CentrarLabel();
            bunifuDataViz1.colorSet = new List<Color>() { Color.DeepSkyBlue };
            frecuencia = new int[] { 100, 400, 700 };
            images = new Image[][] { new Image[] { Properties.Resources.corared, Properties.Resources.corazonred }, new Image[] { Properties.Resources.coragreen, Properties.Resources.corazongreen }, new Image[] { Properties.Resources.corablue, Properties.Resources.corazonblue } };
            iconcorazon = images[2];
            timer1.Start();
            timer2.Start();
        }
        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtTemperatura.Text = trackBar1.Value + "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetSolucion().CargarSignos();
            timer1.Stop();
        }
        

        private ISolucion GetSolucion()
        {
            return ((switchbutton.Value)?Solucions[0]:Solucions[1]);
        }

        private int Valor()
        {
            return ((switchbutton.Value) ? 130 : 180);
        }

        public List<SIGNOS_VITALES> GetPulsos()
        {
            return (pulsos != null) ? pulsos : pulsos = new List<SIGNOS_VITALES>();
        }

        public void SetPulsos(List<SIGNOS_VITALES> value)
        {
            pulsos = Solucions[0].Start(value);
            Solucions[0].CargarSignos();
        }

        public List<SIGNOS_VITALES> GetPresiones()
        {
            return (presiones != null) ? presiones : presiones = new List<SIGNOS_VITALES>();
        }

        public void SetPresiones(List<SIGNOS_VITALES> value)
        {
            presiones = Solucions[1].Start(value);
            Solucions[1].CargarSignos();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pbcorazon.Image = ((corazon)? iconcorazon[0] : iconcorazon[1]);
            corazon = !corazon;
        }

        public void Resett()
        {
            GetSolucion().Reset();
        }

        private void switchbutton_OnValueChange(object sender, EventArgs e)
        {
            if (estado != switchbutton.Value)
            {
                estado = switchbutton.Value;
                GetSolucion().Reset();
                lbfrecuencia.Text = (switchbutton.Value) ? "Historial de Frecuencia Cardiaca" : "Historial de Presion Arterial";
                trackBar1.Maximum = pbTemperatura.MaxValue = Valor();
            }
        }


        private bool Ingresar;
        public SalvarPulso salvarPulso;
        public delegate void SalvarPulso(SIGNOS_VITALES pulso);
        public PulsoEstado pulso;
        public delegate void PulsoEstado(Utiles.EventoEstado estado);
        public SalvarPresion salvarPresion;
        public delegate void SalvarPresion(SIGNOS_VITALES pulso);
        public PresionEstado presion;
        public delegate void PresionEstado(Utiles.EventoEstado estado);
        private Image[][] images;
        private List<SIGNOS_VITALES> pulsos;
        private List<SIGNOS_VITALES> presiones;
        private bool corazon;
        private Image[] iconcorazon;
        private int[] frecuencia;
        private ISolucion[] Solucions;
        private bool estado;
    }
}
