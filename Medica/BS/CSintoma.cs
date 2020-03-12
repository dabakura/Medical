using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using DAL;
using System.Data.Entity.Infrastructure;

namespace BS
{
    public class CSintoma : ICrud<SINTOMA>
    {
        private static CSintoma sintoma;

        public static CSintoma Sintoma { get { return (sintoma != null) ? sintoma : sintoma = new CSintoma(); } set { sintoma = value; } }

        public bool Guardar(SINTOMA sintoma)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoSintoma.Mantenimiento.Guardar(sintoma);
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

        public bool Modificar(SINTOMA sintoma)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoSintoma.Mantenimiento.Modificar(sintoma);
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

        public bool Eliminar(SINTOMA sintoma)
        {
            throw new NotImplementedException();
        }

        public AutoCompleteStringCollection getAutoCompleteString()
        {
            var source = new AutoCompleteStringCollection();
            ((List<SINTOMA>)Utiles.Util.GetSintomas()).ForEach((d) => { source.Add(d.VEFECTO); });
            return source;
        }
    }
}
