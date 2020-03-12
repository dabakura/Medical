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

        internal class ControlPresion : ISolucion
        {

            public void CargaPulso(int d)
            {
                ControlValue(d);
                if (c.GetPresiones().Count > 14)
                    c.GetPresiones().RemoveAt(0);
                c.GetPresiones().Add(new SIGNOS_VITALES() { IPRESION = d, DTFECHA = DateTime.Now });
            }

            public void CargarSignos()
            {
                Bunifu.DataViz.Canvas data = new Bunifu.DataViz.Canvas();
                Bunifu.DataViz.DataPoint point = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_area);
                if (c.GetPresiones().Count > 0)
                {
                    foreach (SIGNOS_VITALES s in c.GetPresiones())
                    {
                        point.addxy("new Date(" + s.DTFECHA.Year + "," + s.DTFECHA.Month + "," + s.DTFECHA.Day + "," + s.DTFECHA.Hour + "," + s.DTFECHA.Minute + "," + s.DTFECHA.Second + ")", s.IPRESION.ToString());
                    }
                }
                data.addData(point);
                c.bunifuDataViz1.Render(data);
            }

            public void ControlValue(int d)
            {
                c.pbTemperatura.Value = d;
                c.lbText.Text = d + ".Mg";
            }

            public void invocador(Utiles.EventoEstado index)
            {
                c.Colorea(index);
                CargarSignos();
                if (c.presion != null)
                    c.presion.Invoke(index);
            }
            
            public Utiles.EventoEstado Miestado(int d)
            {
                if (d > 119)
                    return Utiles.EventoEstado.Alto;
                else if (d < 90)
                    return Utiles.EventoEstado.Bajo;
                return Utiles.EventoEstado.Normal;
            }

            public void SalvaPulso(int d)
            {
                if (DialogResult.Yes == MessageBox.Show("Guardar la nueva Presion", "Presion Arterial", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    CargaPulso(d);
                    if (c.salvarPulso != null)
                        c.salvarPulso.Invoke(new SIGNOS_VITALES() { IPRESION = d, DTFECHA = DateTime.Now });
                    invocador(Miestado(d));
                }
            }

            public List<SIGNOS_VITALES> Start(List<SIGNOS_VITALES> vi)
            {
                List<SIGNOS_VITALES> v = new List<SIGNOS_VITALES>();
                if (vi != null && vi.Count > 0)
                {
                    vi.Reverse();
                    vi.ForEach(s =>
                    {
                        if (s.IPRESION != null)
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
                    int d = Convert.ToInt32(v.Last().IPRESION);
                    ControlValue(d);
                    c.Colorea(Miestado(d));
                }

                return v;
            }

            public void Reset()
            {
                int d = ((c.GetPresiones().Count > 0) ? Convert.ToInt32(c.GetPresiones().Last().IPRESION) : 0);
                ControlValue(d);
                c.Colorea(Miestado(d));
                CargarSignos();
            }

            private CUPulsoLatido c;

            public ControlPresion(CUPulsoLatido c)
            {
                this.c = c;
            }
        }

    }
}
