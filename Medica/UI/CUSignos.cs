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
    public partial class CUSignos : UserControl
    {
        public CUSignos()
        {
            InitializeComponent();
            TITULOS = new String[] { "TEMPERATURA   ", "SATURACION   ", "PRESION ARTERIAL   ", "PULSO CARDIACO   " };
        }

        private void CUSignos_Load(object sender, EventArgs e)
        {
            reloj.Start();
        }

        private void reloj_Tick(object sender, EventArgs e)
        { 
            int i = 0;
            foreach (String s in TITULOS)
            {
                char l = s.First();
                List<char> lis = s.ToList();
                lis.RemoveAt(0);
                lis.Add(l);
                TITULOS[i] = new String(lis.ToArray());
                i++;
            }
            lbTemperatura.Text = TITULOS[0];
            lbpresion.Text = TITULOS[2];
            lbsaturacion.Text = TITULOS[1];
            lbpulso.Text = TITULOS[3];
        }
        
        private List<SIGNOS_VITALES> signos;

        public List<SIGNOS_VITALES> GetSignos()
        {
            return (signos != null) ? signos : signos = new List<SIGNOS_VITALES>();
        }

        public void SetSignos(List<SIGNOS_VITALES> value)
        {
            signos = Start(value);
            CargarSignos();
        }

        private void CargarSignos()
        {
            double t = Convert.ToDouble( GetSignos().ElementAt(0).DTEMPERATURA );
            pbTemperatura.Value = cpbTemperatura.Value = (int)t;
            lbTemp.Text = Math.Round(t, 1)+"°C";
            lbTemp.ForeColor = lbTemperatura.BackColor = cpbTemperatura.ForeColor = cpbTemperatura.ProgressColor = pbTemperatura.BarraColor = TemperaturaColor(t);
            int t2 = Convert.ToInt32(GetSignos().ElementAt(1).IPRESION);
            pbPresion.Value = cpbPresion.Value = t2;
            lbpre.Text = t2+".Mg";
            lbpre.ForeColor = lbpresion.BackColor = cpbPresion.ForeColor = cpbPresion.ProgressColor = pbPresion.BarraColor = PresionColor(t2);
            int t3 = Convert.ToInt32(GetSignos().ElementAt(3).ISATURACION);
            pbStauracion.Value = cpbStauracion.Value = t3;
            lbsatu.Text = t3 + ".Sp";
            lbsatu.ForeColor = lbsaturacion.BackColor = cpbStauracion.ForeColor = cpbStauracion.ProgressColor = pbStauracion.BarraColor = SaturacionColor(t3);
            int t4 = Convert.ToInt32(GetSignos().ElementAt(2).IPULSO);
            pbPulso.Value = cpbPulso.Value = t4;
            lbpul.Text = t4 + ".Bm";
            lbpul.ForeColor = lbpulso.BackColor = cpbPulso.ForeColor = cpbPulso.ProgressColor = pbPulso.BarraColor = PulsoColor(t4);
        }

        private Color TemperaturaColor(double d)
        {
            if (d > 37.7)
                return Utiles.EventoColor(Utiles.EventoEstado.Alto);
            else if (d < 36.3)
                return Utiles.EventoColor(Utiles.EventoEstado.Bajo);
            return Utiles.EventoColor(Utiles.EventoEstado.Normal);
        }

        private Color PresionColor(int d)
        {
            if (d > 119)
                return Utiles.EventoColor(Utiles.EventoEstado.Alto);
            else if (d < 90)
                return Utiles.EventoColor(Utiles.EventoEstado.Bajo);
            return Utiles.EventoColor(Utiles.EventoEstado.Normal);
        }

        private Color SaturacionColor(int d)
        {
            if (d > 110)
                return Utiles.EventoColor(Utiles.EventoEstado.Alto);
            else if (d < 90)
                return Utiles.EventoColor(Utiles.EventoEstado.Bajo);
            return Utiles.EventoColor(Utiles.EventoEstado.Normal);
        }

        private Color PulsoColor(int d)
        {
            if (d > 110)
                return Utiles.EventoColor(Utiles.EventoEstado.Alto);
            else if (d < 60)
                return Utiles.EventoColor(Utiles.EventoEstado.Bajo);
            return Utiles.EventoColor(Utiles.EventoEstado.Normal);
        }

        private List<SIGNOS_VITALES> Start(List<SIGNOS_VITALES> value)
        {
            List<SIGNOS_VITALES> lista = new List<SIGNOS_VITALES>();
            try
            {
                var l = (from t in value where t.DTEMPERATURA != null select t).Last();
                lista.Add(l);
            }
            catch (Exception)
            {
                lista.Add(new SIGNOS_VITALES() { DTEMPERATURA = 0, IPRESION = 0, IPULSO = 0, ISATURACION = 0 });
            }
            try
            {
                var l2 = (from t in value where t.IPRESION != null select t).Last();
                lista.Add(l2);
            }
            catch (Exception)
            {
                lista.Add(new SIGNOS_VITALES() { DTEMPERATURA = 0, IPRESION = 0, IPULSO = 0, ISATURACION = 0 });
            }
            try
            {
                var l3 = (from t in value where t.IPULSO != null select t).Last();
                lista.Add(l3);
            }
            catch (Exception)
            {
                lista.Add(new SIGNOS_VITALES() { DTEMPERATURA = 0, IPRESION = 0, IPULSO = 0, ISATURACION = 0 });
            }
            try
            {
                var l4 = (from t in value where t.ISATURACION != null select t).Last();
                lista.Add(l4);
            }
            catch (Exception)
            {
                lista.Add(new SIGNOS_VITALES() { DTEMPERATURA = 0, IPRESION = 0, IPULSO = 0, ISATURACION = 0 });
            }
            return lista;
        }

        private String[] TITULOS;
    }
}
