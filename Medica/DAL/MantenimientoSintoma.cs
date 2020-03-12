using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;

namespace DAL
{
    public class MantenimientoSintoma : ICrud<SINTOMA>
    {
        private static MantenimientoSintoma mantenimiento;

        public static MantenimientoSintoma Mantenimiento { get { return (mantenimiento != null) ? mantenimiento : mantenimiento = new MantenimientoSintoma(); } set { mantenimiento = value; } }

        public List<SINTOMA> GetListSintomas()
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    return GetSINTOMAS(DB.SINTOMA.ToList());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public SINTOMA GetSintoma(string id)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    try
                    {
                        int Iid = Convert.ToInt32(id);
                        try
                        {
                            var query = (from p in DB.SINTOMA where p.IID == Iid select p).First();
                            return GetSINTOMA(query);
                        }
                        catch (InvalidOperationException)
                        {
                            return null;
                        }
                    }
                    catch (FormatException)
                    {
                        try
                        {
                            var query = (from p in DB.SINTOMA where p.VEFECTO == id select p).First();
                            return query;
                        }
                        catch (InvalidOperationException)
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Eliminar(SINTOMA dato)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(SINTOMA dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    DB.SINTOMA.Add(dato);
                    DB.SaveChanges();
                    return true;
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(SINTOMA dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    SINTOMA sintoma = DB.SINTOMA.First(pp => pp.IID.Equals(dato.IID));
                    sintoma.VEFECTO = dato.VEFECTO;
                    sintoma.VDESCRIPCION = dato.VDESCRIPCION;
                    DB.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<SINTOMA> GetSINTOMAS(ICollection<SINTOMA> s)
        {
            List<SINTOMA> sin = new List<SINTOMA>();
            s.ToList().ForEach(ss => sin.Add(GetSINTOMA(ss)));
            return sin;
        }

        public static SINTOMA GetSINTOMA(SINTOMA ss)
        {
            return new SINTOMA()
            {
                IID = ss.IID,
                VDESCRIPCION = ss.VDESCRIPCION,
                VEFECTO = ss.VEFECTO
            };
        }
    }
}
