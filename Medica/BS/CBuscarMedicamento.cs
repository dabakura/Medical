using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DO;
using System.Transactions;
using System.Windows.Forms;

namespace BS
{
    public class CBuscarMedicamento
    {
        private static CBuscarMedicamento medicamento;

        public static CBuscarMedicamento Medicamento
        {
            get { return (medicamento != null) ? medicamento : medicamento = new CBuscarMedicamento(); }
            set { medicamento = value; }
        }
        
        public List<CMedicamento> getMediacamentoIndicacionSintoma(string indi)
        {
            try
            {
                List<MEDICAMENTO> pa = MantenimientoMedicamento.Mantenimiento.GetListMedicamento();
                pa = pa.FindAll(p => p.INDICACION_SINTOMA.Any(s => s.SINTOMA.VEFECTO.Equals(indi)));
                if (pa.Count>0)
                {
                    List<INDICACION_SINTOMA> sintomas = new List<INDICACION_SINTOMA>();
                    sintomas.Add(pa.First().INDICACION_SINTOMA.ToList().Find(s => s.SINTOMA.VEFECTO.ToLower().Equals(indi.ToLower())));
                    pa.ForEach(p => p.INDICACION_SINTOMA = sintomas);
                }
                return getMedicamentos(pa);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CMedicamento> getMediacamentoIndicacionDiagnosticoa(string indi)
        {
            try
            {
                List<MEDICAMENTO> pa = MantenimientoMedicamento.Mantenimiento.GetListMedicamento();
                pa = pa.FindAll(p => p.INDICACION_DIAGNOSTICO.Any(s => s.DIAGNOSTICO.VDIAGNOSTICO.Equals(indi)));
                if (pa.Count > 0)
                {
                    List<INDICACION_DIAGNOSTICO> sintomas = new List<INDICACION_DIAGNOSTICO>();
                    sintomas.Add(pa.First().INDICACION_DIAGNOSTICO.ToList().Find(s => s.DIAGNOSTICO.VDIAGNOSTICO.ToLower().Equals(indi.ToLower())));
                    pa.ForEach(p => p.INDICACION_DIAGNOSTICO = sintomas);
                }
                return getMedicamentos(pa);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CMedicamento> getMedicamentoNombre(string nombre)
        {
            try
            {
                List<MEDICAMENTO> pa = MantenimientoMedicamento.Mantenimiento.GetListMedicamento();
                pa = pa.FindAll(p => p.MEDI_NOMBRE.Any(s => s.VNOMBRE.Equals(nombre)));
                if (pa.Count > 0)
                {
                    List<MEDI_NOMBRE> sintomas = new List<MEDI_NOMBRE>();
                    sintomas.Add(pa.First().MEDI_NOMBRE.ToList().Find(s => s.VNOMBRE.ToLower().Equals(nombre.ToLower())));
                    pa.ForEach(p => p.MEDI_NOMBRE = sintomas);
                }
                return getMedicamentos(pa);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        private CMedicamento getMedicamento(MEDICAMENTO p)
        {
            return (new CMedicamento() {
                Codigo = p.ICODIGO+"",
                Nombre = p.MEDI_NOMBRE.First().VNOMBRE,
                IndicacionDiagnostico = (p.INDICACION_DIAGNOSTICO.Count>0)? p.INDICACION_DIAGNOSTICO.First().DIAGNOSTICO.VDIAGNOSTICO : "",
                IndicacionSintoma = (p.INDICACION_SINTOMA.Count > 0) ? p.INDICACION_SINTOMA.First().SINTOMA.VEFECTO : "",
            });
        }

        private List<CMedicamento> getMedicamentos(List<MEDICAMENTO> p)
        {
            List<CMedicamento> pa = new List<CMedicamento>();
            p.ForEach(pp => pa.Add(getMedicamento(pp)));
            return pa;
        }

        public MEDICAMENTO getMedicamento(CMedicamento m)
        {
            try
            {
                return Utiles.Util.GetMedicamento(m.Codigo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public AutoCompleteStringCollection getAutoCompleteString(string Tipo)
        {
            var source = new AutoCompleteStringCollection();
            switch (Tipo)
            {
                case "Indicación Diagnostico":
                    ((List<DIAGNOSTICO>)Utiles.Util.GetDiagnosticos()).ForEach((m) => source.Add(m.VDIAGNOSTICO));
                    break;
                case "Indicación Sintoma":
                    ((List<SINTOMA>)Utiles.Util.GetSintomas()).ForEach((m) => source.Add(m.VEFECTO));
                    break;
                default:
                    ((List<MEDICAMENTO>)Utiles.Util.GetMedicamentos()).ForEach((d) => { d.MEDI_NOMBRE.ToList().ForEach(m => source.Add(m.VNOMBRE)); });
                    break;
            }
            return source;
        }
    }
}
