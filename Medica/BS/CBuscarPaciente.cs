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
    public class CBuscarPaciente
    {
        private static CBuscarPaciente paciente;

        public static CBuscarPaciente Paciente
        {
            get { return (paciente != null) ? paciente : paciente = new CBuscarPaciente(); }
            set { paciente = value; }
        }
        
        public List<CPaciente> getPacienteCedula(string cedula)
        {
            try
            {
                List<CPaciente> pa = new List<CPaciente>();
                using (TransactionScope scope = new TransactionScope())
                {
                    PACIENTE p = Utiles.Util.GetPaciente(cedula);
                    if (p != null)
                        pa.Add(getPaciente(p));
                }
                return pa;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CPaciente> getPacienteNombre(string nombre)
        {
            try
            {
                List<PACIENTE> pa = MantenimientoPaciente.Mantenimiento.GetListPacientes();
                return getPacientes(pa.FindAll(p => p.DATOSPERSONALES.VNOMBRE.ToLower().Equals(nombre.ToLower())));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CPaciente> getPacienteApellido(string apellido)
        {
            try
            {
                List<PACIENTE> pa = MantenimientoPaciente.Mantenimiento.GetListPacientes();
                return getPacientes(pa.FindAll(p => p.DATOSPERSONALES.VPRIMERAPELLIDO.ToLower().Equals(apellido.ToLower())));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CPaciente> getPacienteDiagnostico(string diagnostico)
        {
            try
            {
                List<PACIENTE> pa = MantenimientoPaciente.Mantenimiento.GetListPacientes();
                return getPacientes(pa.FindAll(p => p.DIAGNOSTICO.VDIAGNOSTICO.ToLower().Equals(diagnostico.ToLower())));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private CPaciente getPaciente(PACIENTE p)
        {
            return (new CPaciente() {
                Cedula = p.VIDENTIFICACION,
                Nombre = p.DATOSPERSONALES.VNOMBRE,
                Apellido_1 = p.DATOSPERSONALES.VPRIMERAPELLIDO,
                Apellido_2 = p.DATOSPERSONALES.VSEGUNDOPELLIDO,
                Diagnostico = p.DIAGNOSTICO.VDIAGNOSTICO
            });
        }

        public List<CPaciente> getPacientes(List<PACIENTE> p)
        {
            List<CPaciente> pa = new List<CPaciente>();
            p.ForEach(pp => pa.Add(getPaciente(pp)));
            return pa;
        }

        public PACIENTE getPaciente(CPaciente paciente)
        {
            try
            {
                return Utiles.Util.GetPaciente(paciente.Cedula);
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
                case "Nombre":
                    ((List<PACIENTE>)Utiles.Util.GetPacientes()).ForEach((m) => { if ( !source.Contains(m.DATOSPERSONALES.VNOMBRE)) source.Add(m.DATOSPERSONALES.VNOMBRE); });
                    break;
                case "Apellido":
                    ((List<PACIENTE>)Utiles.Util.GetPacientes()).ForEach((m) => { if (!source.Contains(m.DATOSPERSONALES.VPRIMERAPELLIDO)) source.Add(m.DATOSPERSONALES.VPRIMERAPELLIDO); });
                    break;
                case "Diagnostico":
                    ((List<DIAGNOSTICO>)Utiles.Util.GetDiagnosticos()).ForEach((m) => source.Add(m.VDIAGNOSTICO));
                    break;
                default:
                    ((List<PACIENTE>)Utiles.Util.GetPacientes()).ForEach((m) => source.Add(m.VIDENTIFICACION));
                    break;
            }
            return source;
        }
    }
}
