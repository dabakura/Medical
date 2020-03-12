using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazPlugin;
using BS;
using DAL;

namespace UI
{
    public partial class FrmSignosVitales : FormBase, CVentanaPlugin.IVentana
    {
        public FrmSignosVitales()
        {
            InitializeComponent();
        }

        public Panel Panel { get { return pnBody; } set { throw new NotImplementedException(); } }

        public IUtiles Util { get { return Utiles.Util; } set { throw new NotImplementedException(); } }

        public CVentanaPlugin.IVentana Ventana { get { return CWindows.Ventana; } set { throw new NotImplementedException(); } }

        public Image Icono { get { throw new NotImplementedException(); } }

        public void CambiarVentana(CVentanaPlugin.IVentana ventana)
        {
            Ventana.CambiarVentana(ventana);
        }

        public void load()
        {
            try
            {
                List<SIGNOS_VITALES> lista = CSignosVitales.SignosVitales.GetListSignosVitales(Utiles.Util.Paciente.VIDENTIFICACION);
                cuTemperatura1.SetTemperaturas(lista);
                cuSaturacion1.SetSaturaciones(lista);
                cuPulsoLatido1.SetPulsos(lista);
                cuPulsoLatido1.SetPresiones(lista);
                cuPulsoLatido1.Resett();
                cuTemperatura1.salvalTemperatura += new CUTemperatura.SalvalTemperatura(GuardarCambios);
                cuTemperatura1.temperatura += new CUTemperatura.TemperaturaEstado(EstadoTemeratura);
                cuPulsoLatido1.salvarPulso += new CUPulsoLatido.SalvarPulso(GuardarCambios);
                cuPulsoLatido1.pulso += new CUPulsoLatido.PulsoEstado(EstadoPulso);
                cuPulsoLatido1.salvarPresion += new CUPulsoLatido.SalvarPresion(GuardarCambios);
                cuPulsoLatido1.presion += new CUPulsoLatido.PresionEstado(EstadoPresion);
                cuSaturacion1.salvarSaturacion += new CUSaturacion.SalvarSaturacion(GuardarCambios);
                cuSaturacion1.saturarion += new CUSaturacion.SaturacionEstado(EstadoSaturacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void EstadoTemeratura(Utiles.EventoEstado estado)
        {
            try
            {
                CSignosVitales.SignosVitales.ModificarTemperaturaEstado(((int)estado), Utiles.Util.Paciente.VIDENTIFICACION);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void EstadoPulso(Utiles.EventoEstado estado)
        {
            try
            {
                CSignosVitales.SignosVitales.ModificarPulsoEstado(((int)estado), Utiles.Util.Paciente.VIDENTIFICACION);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void EstadoSaturacion(Utiles.EventoEstado estado)
        {
            try
            {
                CSignosVitales.SignosVitales.ModificarSaturcionEstado(((int)estado), Utiles.Util.Paciente.VIDENTIFICACION);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void EstadoPresion(Utiles.EventoEstado estado)
        {
            try
            {
                CSignosVitales.SignosVitales.ModificarPresionEstado(((int)estado), Utiles.Util.Paciente.VIDENTIFICACION);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void GuardarCambios(SIGNOS_VITALES signovital)
        {
            try
            {
                signovital.IIDPACIENTE = Utiles.Util.Paciente.VIDENTIFICACION;
                CSignosVitales.SignosVitales.Guardar(signovital);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error desconocido",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        
    }
}
