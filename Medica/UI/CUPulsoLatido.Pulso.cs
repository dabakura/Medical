using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BS;
using DAL;
using System.Windows.Forms;

namespace UI
{
    partial class CUPulsoLatido
    {
        internal class ControlPulso : ISolucion
        {

            public void CargaPulso(int d)
            {
                ControlValue(d);
                if (c.GetPulsos().Count > 14)
                    c.GetPulsos().RemoveAt(0);
                c.GetPulsos().Add(new SIGNOS_VITALES() { IPULSO = d, DTFECHA = DateTime.Now });
            }

            public void CargarSignos()
            {
                Bunifu.DataViz.Canvas data = new Bunifu.DataViz.Canvas();
                Bunifu.DataViz.DataPoint point = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_area);
                if (c.GetPulsos().Count > 0)
                {
                    foreach (SIGNOS_VITALES s in c.GetPulsos())
                    {
                        point.addxy("new Date(" + s.DTFECHA.Year + "," + s.DTFECHA.Month + "," + s.DTFECHA.Day + "," + s.DTFECHA.Hour + "," + s.DTFECHA.Minute + "," + s.DTFECHA.Second + ")", s.IPULSO.ToString());
                    }
                }
                data.addData(point);
                c.bunifuDataViz1.Render(data);
            }

            public void ControlValue(int d)
            {
                c.pbTemperatura.Value = d;
                c.lbText.Text = d + ".Bm";
            }
            
            public void invocador(Utiles.EventoEstado index)
            {
                c.Colorea(index);
                CargarSignos();
                if (c.pulso != null)
                    c.pulso.Invoke(index);
            }

            public Utiles.EventoEstado Miestado(int d)
            {
                if (d > 110)
                    return Utiles.EventoEstado.Alto;
                else if (d < 60)
                    return Utiles.EventoEstado.Bajo;
                return Utiles.EventoEstado.Normal;
            }

            public void SalvaPulso(int d)
            {
                if (DialogResult.Yes == MessageBox.Show("Guardar el nuevo Pulso", "Frecuencia Cardiaca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    CargaPulso(d);
                    if (c.salvarPulso != null)
                        c.salvarPulso.Invoke(new SIGNOS_VITALES() { IPULSO = d, DTFECHA = DateTime.Now });
                    invocador(Miestado(d));
                }
            }

            public void Reset()
            {
                int d = ((c.GetPulsos().Count > 0) ? Convert.ToInt32(c.GetPulsos().Last().IPULSO) : 0);
                ControlValue(d);
                c.Colorea(Miestado(d));
                CargarSignos();
            }

            public List<SIGNOS_VITALES> Start(List<SIGNOS_VITALES> vi)
            {
                List<SIGNOS_VITALES> v = new List<SIGNOS_VITALES>();
                if (vi != null && vi.Count > 0)
                {
                    vi.Reverse();
                    vi.ForEach(s =>
                    {
                        if (s.IPULSO != null)
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
                    int d = Convert.ToInt32(v.Last().IPULSO);
                    ControlValue(d);
                    c.Colorea(Miestado(d));
                }

                return v;
            }

            private CUPulsoLatido c;

            public ControlPulso(CUPulsoLatido c)
            {
                this.c = c;
            }
        }

    }
}
