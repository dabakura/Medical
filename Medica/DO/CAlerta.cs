using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace DO
{
    public enum ALERTA
    {
        DosisBaja = 0,
        ContraSintoma = 1,
        DosisAlta = 2,
        ContraDiagnostico = 3,
        ContraMedicamento = 4
    }

    public class CAlerta
    {
        private ALERTA alerta;
        private String mensajeAlerta;
        private Color[] colors = new Color[] {  Color.Blue, Color.Yellow, Color.Orange, Color.Red, Color.Pink };

        public ALERTA Alerta
        {
            get { return alerta; }
            set { alerta = value; }
        }

        public String MensajeAlerta
        {
            get { return mensajeAlerta; }
            set { mensajeAlerta = value; }
        }

        public Color ColorAlerta
        {
            get { return colors[(int)Alerta]; }
        }
    }
}
