using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MantenimientoSignosVitales : ICrud<SIGNOS_VITALES>
    {
        private static MantenimientoSignosVitales mantenimiento;

        public static MantenimientoSignosVitales Mantenimiento { get { return (mantenimiento != null) ? mantenimiento : mantenimiento = new MantenimientoSignosVitales(); } set { mantenimiento = value; } }

        public List<SIGNOS_VITALES> GetListSignosVitales(string id)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    try
                    {
                        List<SIGNOS_VITALES> lista = new List<SIGNOS_VITALES>();
                        var sig = from s in DB.SIGNOS_VITALES where s.IIDPACIENTE == id select s;
                        foreach (SIGNOS_VITALES item in sig)
                        {
                            lista.Add(GetSIGNOS_VITALES(item));
                        }
                        return lista;
                    }
                    catch (InvalidOperationException)
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public SIGNOS_VITALES GetSIGNOS_VITALES(SIGNOS_VITALES sig)
        {
            return new SIGNOS_VITALES() { DTEMPERATURA = sig.DTEMPERATURA,
                DTFECHA = sig.DTFECHA,
                IIDPACIENTE = sig.IIDPACIENTE,
                IPRESION = sig.IPRESION,
                IPULSO = sig.IPULSO,
                ISATURACION = sig.ISATURACION,
                PACIENTE = MantenimientoPaciente.Mantenimiento.GetPACIENTE(sig.PACIENTE, false) };
        }

        public bool Eliminar(SIGNOS_VITALES dato)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(SIGNOS_VITALES dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    DB.SIGNOS_VITALES.Add(dato);
                    DB.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(SIGNOS_VITALES dato)
        {
            throw new NotImplementedException();
        }

        public void ModificarPresionEstado(int tipo,string id)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    switch (tipo)
                    {
                        case 0:
                            DB.EstadoPresionAlta(id);
                            break;
                        case 1:
                            DB.EstadoPresionNormal(id);
                            break;
                        case 2:
                            DB.EstadoPresionBaja(id);
                            break;
                    }
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
                using (MedicalEntities DB = new MedicalEntities())
                {
                    switch (tipo)
                    {
                        case 0:
                            DB.EstadoTemperaturaAlta(id);
                            break;
                        case 1:
                            DB.EstadoTemperaturaNormal(id);
                            break;
                        case 2:
                            DB.EstadoTemperaturaBaja(id);
                            break;
                    }
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
                using (MedicalEntities DB = new MedicalEntities())
                {
                    switch (tipo)
                    {
                        case 0:
                            DB.EstadoPulsoAlta(id);
                            break;
                        case 1:
                            DB.EstadoPulsoNormal(id);
                            break;
                        case 2:
                            DB.EstadoPulsoBaja(id);
                            break;
                    }
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
                using (MedicalEntities DB = new MedicalEntities())
                {
                    switch (tipo)
                    {
                        case 0:
                            DB.EstadoSaturacionAlta(id);
                            break;
                        case 1:
                            DB.EstadoSaturacionNormal(id);
                            break;
                        case 2:
                            DB.EstadoSaturacionBaja(id);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        

    }
}
