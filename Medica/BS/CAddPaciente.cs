using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BS
{
    public class CAddPaciente
    {
        private static CAddPaciente paciente;
        private List<PADECIMIENTO> padecimientos;

        public List<PADECIMIENTO> Padecimientos
        {
            get { return (padecimientos != null) ? padecimientos : padecimientos = new List<PADECIMIENTO>(); }
            set { padecimientos = value; }
        }


        public static CAddPaciente Paciente
        {
            get { return (paciente != null) ? paciente : paciente = new CAddPaciente(); }
            set { paciente = value; }
        }

        public bool AgregarPadecimiento(PADECIMIENTO p)
        {
            bool estado;
            if (estado = !Padecimientos.Any((pdc) => { return pdc.IIDDIAGNOSTICO == p.IIDDIAGNOSTICO; }))
                Padecimientos.Add(p);
            return estado;
        }

        public void RemoverPadecimiento(string d)
        {
            Padecimientos.RemoveAll((pdc) => { return (pdc.DIAGNOSTICO.VDIAGNOSTICO == d); });
        }

        private void EstablecerIDPadecimiento(String id)
        {
            Padecimientos.ForEach((pdc) => { pdc.IIDPACIENTE = id; });
        }

        public bool Guardar(PACIENTE dato)
        {
            try
            {
                AñadirTrama(dato);
                return CPacientes.Paciente.Guardar(dato);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int GetEdad(DateTime nacimiento)
        {
            TimeSpan a = DateTime.Today.Subtract(nacimiento);
            double b = (a.Days / 365.25);
            return Convert.ToInt32(b);
        }

        public bool Modificar(PACIENTE paciente)
        {
            try
            {
                AñadirTrama(paciente);
                return CPacientes.Paciente.Modificar(paciente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AñadirTrama(PACIENTE paciente)
        {
            paciente.IEDAD = GetEdad(paciente.DATOSPERSONALES.DTFECHANACIMIENTO);
            EstablecerIDPadecimiento(paciente.DATOSPERSONALES.VCEDULA);
            paciente.PADECIMIENTO = Padecimientos;
        }

        public void Clean()
        {
            Padecimientos = null;
        }
    }
}
