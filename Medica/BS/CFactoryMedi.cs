using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO;
using DAL;

namespace BS
{
    public class CFactoryMedi
    {
        private static MEDICAMENTO m;
        private static PACIENTE p;
        private static decimal dosis;
        

        public static bool InspecionarExistencia(List<PACIENTE_MEDICAMENTO> pms, PACIENTE_MEDICAMENTO pm)
        {
            int codigo = pm.MEDICAMENTO.ICODIGO;
            return !pms.Exists(ppp => (ppp.MEDICAMENTO.ICODIGO == codigo));
        }

        public static bool InspecionarLimitacion(List<PACIENTE_MEDICAMENTO> pms, PACIENTE_MEDICAMENTO pm)
        {
            int codigo = pm.MEDICAMENTO.ICODIGO;
            String mensaje = "";
            bool estado = pms.Exists(ppp => ppp.MEDICAMENTO.CONTRAINDICACION_MEDICAMENTO.Any(pp => { if (pp.IIDMEDICAMENTO == codigo) { mensaje = ppp.MEDICAMENTO.MEDI_NOMBRE.First().VNOMBRE; return true; } return false; }));
            if (estado)
                MessageBox.Show("Este medicamento no se puede mesclar con: "+mensaje,"Este medicamento esta contraindicado",MessageBoxButtons.OK,MessageBoxIcon.Error);
            return !estado;
        }

        public static CMedi CrearFilaMedicamento(PACIENTE_MEDICAMENTO pm,bool b)
        {
            CMedi cm = new CMedi(pm);
            m = pm.MEDICAMENTO;
            p = pm.PACIENTE;
            dosis = pm.DDOSIS;
            try
            {
                AlertasDiagnosticos(cm,b);
                AlertasSintomas(cm,b);
                AlertasDosis(cm,b);
                return cm;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static void AlertasDosis(CMedi cm,bool b)
        {
            if (dosis > m.DOSIS.First(d => d.VRANGO == cm.RANGO).DMAX)
            {
                if (b || (DialogResult.Yes == MessageBox.Show("La dosis indicada supera el maximo estipulado\nDosis comun = Mayor a "+ m.DOSIS.First(d => d.VRANGO == cm.RANGO).DMIN+" Menor a "+ m.DOSIS.First(d => d.VRANGO == cm.RANGO).DMAX+
                    "\nSeguro que desea recetarle el medicamento con esta dosis", "La dosis es muy alta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
                {
                    cm.SetAlerta(new CAlerta() { Alerta = ALERTA.DosisAlta, MensajeAlerta = "La dosis de este medicamento supera lo normal\nDosis comun = Mayor a " + m.DOSIS.First(d => d.VRANGO == cm.RANGO).DMIN + " Menor a " + m.DOSIS.First(d => d.VRANGO == cm.RANGO).DMAX });
                }
                else throw new Exception();
            } else if (dosis < m.DOSIS.First(d => d.VRANGO == cm.RANGO).DMIN)
            {
                if (b || (DialogResult.Yes == MessageBox.Show("La dosis indicada es inferior a el minino estipulado\nDosis comun = Mayor a " + m.DOSIS.First(d => d.VRANGO == cm.RANGO).DMIN + " Menor a " + m.DOSIS.First(d => d.VRANGO == cm.RANGO).DMAX +
                    "\nSeguro que desea recetarle el medicamento con esta dosis", "La dosis es muy baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
                {
                    cm.SetAlerta(new CAlerta() { Alerta = ALERTA.DosisBaja, MensajeAlerta = "La dosis de este medicamento es inferior a lo normal\nDosis comun = Mayor a " + m.DOSIS.First(d => d.VRANGO == cm.RANGO).DMIN + " Menor a " + m.DOSIS.First(d => d.VRANGO == cm.RANGO).DMAX });
                }
                else throw new Exception();
            }
        }

        private static void AlertasDiagnosticos(CMedi cm, bool b)
        {
            List<string> dAfectados = new List<string>();
            p.PADECIMIENTO.ToList().ForEach(pa => { if (m.CONTRAINDICACION_DIAGNOSTICO.Any(c => ((c.IIDIAGNOSTICO == pa.IIDDIAGNOSTICO) && (pa.BESTADO)))) dAfectados.Add(pa.DIAGNOSTICO.VDIAGNOSTICO); });
            if (m.CONTRAINDICACION_DIAGNOSTICO.Any(c => p.DIAGNOSTICO.IID == c.IIDIAGNOSTICO))
                dAfectados.Add(p.DIAGNOSTICO.VDIAGNOSTICO);
            if (dAfectados.Count > 0)
            {
                String mensaje = "";
                dAfectados.ForEach(a => mensaje += "\n" + a + "\n");
                if (b || (DialogResult.Yes == MessageBox.Show("Su paciente tiene los siguientes diagnosticos:" + mensaje +
                    "Para los cuales esta contraindicado este Medicamento\nSeguro que desea recetarle el medicamento", "Este Medicamento esta Contraindicado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
                {
                    cm.SetAlerta(new CAlerta() { Alerta = ALERTA.ContraDiagnostico, MensajeAlerta = "Este medicamento esta contraindicado\npara los diagnosticos" + mensaje });
                }
                else throw new Exception();
            }
        }

        private static void AlertasSintomas(CMedi cm, bool b)
        {
            List<string> dAfectados = new List<string>();
            p.PACIENTE_SINTOMA.ToList().ForEach(pa => { if (m.CONTRAINDICACION_SINTOMA.Any(c => ((c.IIDSINTOMA == pa.IIDSINTOMA) && (pa.BESTADO)))) dAfectados.Add(pa.SINTOMA.VEFECTO); });
            if (dAfectados.Count > 0)
            {
                String mensaje = "";
                dAfectados.ForEach(a => mensaje += "\n" + a + "\n");
                if (b || (DialogResult.Yes == MessageBox.Show("Su paciente tiene los siguientes sintomas:" + mensaje +
                    "Para los cuales esta contraindicado este Medicamento\nSeguro que desea recetarle el medicamento", "Este Medicamento esta Contraindicado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
                {
                    cm.SetAlerta(new CAlerta() { Alerta = ALERTA.ContraSintoma, MensajeAlerta = "Este medicamento esta contraindicado\npara los sintomas" + mensaje });
                }
                else throw new Exception();
            }
        }
    }
}
