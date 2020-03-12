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
    public class CVia_Administracion : ICrud<VIA_ADMINISTRACION>
    {
        private static CVia_Administracion via;

        public static CVia_Administracion Via { get { return (via != null) ? via : via = new CVia_Administracion(); } set { via = value; } }

        public bool Guardar(VIA_ADMINISTRACION via)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoVia_Administracion.Mantenimiento.Guardar(via);
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

        public bool Modificar(VIA_ADMINISTRACION via)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoVia_Administracion.Mantenimiento.Modificar(via);
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

        public bool Eliminar(VIA_ADMINISTRACION via)
        {
            throw new NotImplementedException();
        }

        public AutoCompleteStringCollection getAutoCompleteString()
        {
            var source = new AutoCompleteStringCollection();
            ((List<VIA_ADMINISTRACION>)Utiles.Util.GetVias_Administracion()).ForEach((d) => { source.Add(d.VNOMBRE); });
            return source;
        }
    }
}
