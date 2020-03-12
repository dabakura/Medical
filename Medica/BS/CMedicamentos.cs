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
   
    public class CMedicamentos : ICrud<MEDICAMENTO>
    {
        private static CMedicamentos medicamento;

        public static CMedicamentos Medicamento
        {
            get { return (medicamento != null) ? medicamento : medicamento = new CMedicamentos(); }
            set { medicamento = value; }
        }

        public bool Guardar(MEDICAMENTO dato)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoMedicamento.Mantenimiento.Guardar(dato);
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
        
        public bool Eliminar(MEDICAMENTO dato)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoMedicamento.Mantenimiento.Eliminar(dato);
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

        public bool Modificar(MEDICAMENTO dato)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoMedicamento.Mantenimiento.Modificar(dato);
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
