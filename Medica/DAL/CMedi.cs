using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DO;

namespace DAL
{
    public class CMedi
    {
        private PACIENTE_MEDICAMENTO pm;
        private string VIDENTIFICACION;
        private int ICODIGO;
        private MEDICAMENTO MEDICAMENTO;
        private PACIENTE PACIENTE;
        private List<CAlerta> alertas;
        private string VDESCRIPCION;
        private Color color;
        private int index;

        public string NOMBRE_MEDICAMENTO { get; set; } 
        public decimal DOSIS { get; set; }
        public string RANGO { get; set; }
        public string VIA_ADMINISTRACION { get; set; }
        public bool Dosis_Alta { get; set; }
        public bool Dosis_Baja { get; set; }
        public bool Cont_Sintoma { get; set; }
        public bool Cont_Diagnostico { get; set; }
        
        

        public CMedi(PACIENTE_MEDICAMENTO pm)
        {
            this.pm = pm;
            this.VIDENTIFICACION = pm.VIDENTIFICACION;
            this.ICODIGO = pm.ICODIGO;
            this.DOSIS = pm.DDOSIS;
            this.VDESCRIPCION = pm.VDESCRIPCION;
            this.VIA_ADMINISTRACION = pm.VVIAADMINISTRACION;
            this.MEDICAMENTO = pm.MEDICAMENTO;
            this.PACIENTE = pm.PACIENTE;
            this.NOMBRE_MEDICAMENTO = MEDICAMENTO.MEDI_NOMBRE.First().VNOMBRE;
            this.RANGO = pm.VRANGO;
            this.Dosis_Alta = false;
            this.Dosis_Baja = false;
            this.Cont_Sintoma = false;
            this.Cont_Diagnostico = false;
            this.color = Color.White;
            this.index = -1;
        }

        public PACIENTE_MEDICAMENTO GetPacienteMedicamento()
        {
            return pm;
        }

        public string GetPacienteIdentificacion()
        {
            return VIDENTIFICACION;
        }

        public string GetDescripcion()
        {
            return VDESCRIPCION;
        }

        public int GetMedicamentoCodigo()
        {
            return ICODIGO;
        }

        public PACIENTE GetPaciente()
        {
            return PACIENTE;
        }

        public MEDICAMENTO GetMedicamento()
        {
            return MEDICAMENTO;
        }

        public List<CAlerta> Alertas()
        {
            return (alertas!=null)?alertas:alertas= new List<CAlerta>();
        }

        public void SetAlerta( CAlerta a)
        {
            switch (a.Alerta)
            {
                case ALERTA.DosisBaja:
                    Dosis_Alta = !(Dosis_Baja = true);
                    break;
                case ALERTA.ContraSintoma:
                    Cont_Sintoma = true;
                    break;
                case ALERTA.DosisAlta:
                    Dosis_Baja = !(Dosis_Alta = true);
                    break;
                case ALERTA.ContraDiagnostico:
                    Cont_Diagnostico = true;
                    break;
            }
            Alertas().Add(a);
            ColorAlerta(a);
        }

        private void ColorAlerta(CAlerta a){
            if (index<(int)a.Alerta)
            {
                index = (int)a.Alerta;
                color = a.ColorAlerta;
            }
        }

        public Color GetColor()
        {
            return color;
        }

        public string GetMensajeAlta()
        {
            if (Dosis_Alta)
            {
                return Alertas().Find(a => a.Alerta == ALERTA.DosisAlta).MensajeAlerta; 
            }
            return "";
        }

        public string GetMensajeBaja()
        {
            if (Dosis_Baja)
            {
                return Alertas().Find(a => a.Alerta == ALERTA.DosisBaja).MensajeAlerta;
            }
            return "";
        }

        public string GetMensajeSintoma()
        {
            if (Cont_Sintoma)
            {
                return Alertas().Find(a => a.Alerta == ALERTA.ContraSintoma).MensajeAlerta;
            }
            return "";
        }

        public string GetMensajeDiagnostico()
        {
            if (Cont_Diagnostico)
            {
                return Alertas().Find(a => a.Alerta == ALERTA.ContraDiagnostico).MensajeAlerta;
            }
            return "";
        }
        
    }
}
