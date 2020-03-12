using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Transactions;
using System.Data.Entity.Infrastructure;

namespace BS
{
   
    public class CPacientes : ICrud<PACIENTE>
    {
        private static CPacientes paciente;

        public static CPacientes Paciente
        {
            get { return (paciente != null) ? paciente : paciente = new CPacientes(); }
            set { paciente = value; }
        }

        public bool Guardar(PACIENTE dato)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoPaciente.Mantenimiento.Guardar(dato);
                    scope.Complete();
                }
                return estado;
            }
            catch (DbUpdateException)
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        public bool Eliminar(PACIENTE dato)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoPaciente.Mantenimiento.Eliminar(dato);
                    scope.Complete();
                    if (Utiles.Util.Paciente != null && Utiles.Util.Paciente.VIDENTIFICACION.Equals(dato.VIDENTIFICACION))
                    {
                        Utiles.Util.Paciente = null;
                    }
                }
                return estado;
            }
            catch (DbUpdateException)
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(PACIENTE dato)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoPaciente.Mantenimiento.Modificar(dato);
                    scope.Complete();
                }
                return estado;
            }
            catch (DbUpdateException)
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
