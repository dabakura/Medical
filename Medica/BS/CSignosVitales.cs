using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DAL;

namespace BS
{
    public class CSignosVitales : ICrud<SIGNOS_VITALES>
    {
        private static CSignosVitales signosvitales;

        public static CSignosVitales SignosVitales
        {
            get { return (signosvitales != null) ? signosvitales : signosvitales = new CSignosVitales(); }
            set { signosvitales = value; }
        }

        public List<SIGNOS_VITALES> GetListSignosVitales(string id)
        {
            try
            {
                try
                {
                    List<SIGNOS_VITALES> lista;
                    using (TransactionScope scope = new TransactionScope())
                    {
                        lista = MantenimientoSignosVitales.Mantenimiento.GetListSignosVitales(id);
                        scope.Complete();
                    }
                    return lista;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Guardar(SIGNOS_VITALES dato)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    estado = MantenimientoSignosVitales.Mantenimiento.Guardar(dato);
                    scope.Complete();
                }
                return estado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Eliminar(SIGNOS_VITALES dato)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(SIGNOS_VITALES dato)
        {
            throw new NotImplementedException();
        }

        public void ModificarPresionEstado(int tipo, string id)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    MantenimientoSignosVitales.Mantenimiento.ModificarPresionEstado(tipo,id);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ModificarTemperaturaEstado(int tipo, string id)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    MantenimientoSignosVitales.Mantenimiento.ModificarTemperaturaEstado(tipo, id);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ModificarPulsoEstado(int tipo, string id)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    MantenimientoSignosVitales.Mantenimiento.ModificarPulsoEstado(tipo, id);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ModificarSaturcionEstado(int tipo, string id)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    MantenimientoSignosVitales.Mantenimiento.ModificarSaturcionEstado(tipo, id);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
