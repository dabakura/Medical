using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;
using DAL;

namespace BS
{
    public class CInicio
    {
        public static List<CPaciente> GetCPacientes()
        {
            List<PACIENTE> lista = MantenimientoPaciente.Mantenimiento.GetListPacientes();
            return CBuscarPaciente.Paciente.getPacientes(lista);
        }

        public static void Seleccion(CPaciente p)
        {
            Utiles.Util.Paciente = CBuscarPaciente.Paciente.getPaciente(p);
        }
    }
}
