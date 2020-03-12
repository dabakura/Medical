using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Transactions;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace BS
{
    public class CDiagnoctico : ICrud<DIAGNOSTICO>
    {
        private static CDiagnoctico diagnoctico;

        public static CDiagnoctico Diagnoctico { get { return (diagnoctico != null) ? diagnoctico : diagnoctico = new CDiagnoctico(); } set { diagnoctico = value; } }

        public  bool Guardar(DIAGNOSTICO diagnostico)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoDiagnostico.Mantenimiento.Guardar(diagnostico);
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

        public  bool Modificar(DIAGNOSTICO diagnostico)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoDiagnostico.Mantenimiento.Modificar(diagnostico);
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

        public  bool Eliminar(DIAGNOSTICO diagnostico)
        {
            throw new NotImplementedException();
        }

        public List<string> getNombresDiagnosticos()
        {
            List<string> lista = new List<string>();
            ((List<DIAGNOSTICO>)Utiles.Util.GetDiagnosticos()).ForEach((d) => { lista.Add(d.VDIAGNOSTICO); });
            return lista;
        }

        public AutoCompleteStringCollection getAutoCompleteString()
        {
            var source = new AutoCompleteStringCollection();
            ((List<DIAGNOSTICO>)Utiles.Util.GetDiagnosticos()).ForEach((d) => { source.Add(d.VDIAGNOSTICO); });
            return source;
        }

        private List<SINTOMA> sintomas;

        public List<SINTOMA> Sigtomas
        {
            get { return (sintomas != null) ? sintomas : sintomas = new List<SINTOMA>(); }
            set { sintomas = value; }
        }

        public void RemoverPadecimiento(string o)
        {
            Sigtomas.RemoveAll(s => s.VEFECTO.Equals(o));
        }

        public bool AgregarSintoma(SINTOMA sig)
        {
            bool estado;
            if (estado = !Sigtomas.Any(s => s.IID == sig.IID))
                Sigtomas.Add(sig);
            return estado;
        }
    }
}
