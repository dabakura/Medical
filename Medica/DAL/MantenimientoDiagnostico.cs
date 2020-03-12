using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;


namespace DAL
{
    public class MantenimientoDiagnostico : ICrud<DIAGNOSTICO>
    {
        private static MantenimientoDiagnostico mantenimiento;

        public static MantenimientoDiagnostico Mantenimiento { get { return (mantenimiento != null) ? mantenimiento : mantenimiento = new MantenimientoDiagnostico(); } set { mantenimiento = value; } }

        public List<DIAGNOSTICO> GetListDiagnosticos()
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    return GetDIAGNOSTICOS(DB.DIAGNOSTICO.ToList());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public DIAGNOSTICO GetDiagnostico(string id)
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
                            var query = (from p in DB.DIAGNOSTICO where p.IID == Iid select p).First();
                            return GetDIAGNOSTICO(query, true);
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
                            var query = (from p in DB.DIAGNOSTICO where p.VDIAGNOSTICO == id select p).First();
                            return GetDIAGNOSTICO(query,true);
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

        public bool Eliminar(DIAGNOSTICO dato)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(DIAGNOSTICO dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    ICollection<SINTOMA> s = new HashSet<SINTOMA>();
                    foreach (SINTOMA ss in dato.SINTOMA)
                    {
                        SINTOMA sin = DB.SINTOMA.First(sss => sss.IID == ss.IID);
                        s.Add(sin);
                    }
                    dato.SINTOMA = s;
                    DB.DIAGNOSTICO.Add(dato);
                    DB.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(DIAGNOSTICO dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    DIAGNOSTICO d = DB.DIAGNOSTICO.First(dd => dd.IID == dato.IID);
                    d.SINTOMA.Clear();
                    DB.SaveChanges();
                    ICollection<SINTOMA> s = new HashSet<SINTOMA>();
                    foreach (SINTOMA ss in dato.SINTOMA)
                    {
                        SINTOMA sin = DB.SINTOMA.First(sss => sss.IID == ss.IID);
                        s.Add(sin);
                    }
                    d.SINTOMA = s;
                    d.TDESCRIPCION = dato.TDESCRIPCION;
                    d.VDIAGNOSTICO = dato.VDIAGNOSTICO;
                    DB.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<DIAGNOSTICO> GetDIAGNOSTICOS(List<DIAGNOSTICO> listDiagnosticos)
        {
            List<DIAGNOSTICO> list = new List<DIAGNOSTICO>();
            listDiagnosticos.ForEach(s => { list.Add(GetDIAGNOSTICO(s,true)); });
            return list;
        }

        public static DIAGNOSTICO GetDIAGNOSTICO(DIAGNOSTICO d,bool b)
        {
            DIAGNOSTICO dia = new DIAGNOSTICO()
            {
                IID = d.IID,
                VDIAGNOSTICO = d.VDIAGNOSTICO,
                TDESCRIPCION = d.TDESCRIPCION,
                SINTOMA = ((b) ? MantenimientoSintoma.GetSINTOMAS(d.SINTOMA.ToList()) : null)
            };
            return dia;
        }
        
    }
}
