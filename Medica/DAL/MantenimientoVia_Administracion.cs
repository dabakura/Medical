using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;

namespace DAL
{
    public class MantenimientoVia_Administracion : ICrud<VIA_ADMINISTRACION>
    {
        private static MantenimientoVia_Administracion mantenimiento;

        public static MantenimientoVia_Administracion Mantenimiento { get { return (mantenimiento != null) ? mantenimiento : mantenimiento = new MantenimientoVia_Administracion(); } set { mantenimiento = value; } }

        public List<VIA_ADMINISTRACION> GetListVia_Administracion()
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    return GetVIA_ADMINISTRACIONES(DB.VIA_ADMINISTRACION.ToList());
                }
            }
            catch (Exception)
            {
                throw;
            }
            throw new NotImplementedException();
        }

        public VIA_ADMINISTRACION GetVia_Administracion(string id)
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
                            var query = (from p in DB.VIA_ADMINISTRACION where p.IID == Iid select p).First();
                            return GetVIA_ADMINISTRACION(query);
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
                            var query = (from p in DB.VIA_ADMINISTRACION where p.VNOMBRE == id select p).First();
                            return GetVIA_ADMINISTRACION(query);
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
            throw new NotImplementedException();
        }

        public bool Eliminar(VIA_ADMINISTRACION dato)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(VIA_ADMINISTRACION dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    DB.VIA_ADMINISTRACION.Add(dato);
                    DB.SaveChanges();
                    return true;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(VIA_ADMINISTRACION dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    VIA_ADMINISTRACION via = DB.VIA_ADMINISTRACION.First(pp => pp.IID.Equals(dato.IID));
                    via.VNOMBRE = dato.VNOMBRE;
                    via.VDESCRIPCION = dato.VDESCRIPCION;
                    DB.SaveChanges();
                    return true;   
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<VIA_ADMINISTRACION> GetVIA_ADMINISTRACIONES(ICollection<VIA_ADMINISTRACION> v)
        {
            List<VIA_ADMINISTRACION> list = new List<VIA_ADMINISTRACION>();
            v.ToList().ForEach(vv => list.Add(GetVIA_ADMINISTRACION(vv)));
            return list;
        }

        public static VIA_ADMINISTRACION GetVIA_ADMINISTRACION(VIA_ADMINISTRACION vv)
        {
            return new VIA_ADMINISTRACION()
            {
                IID = vv.IID,
                VDESCRIPCION = vv.VDESCRIPCION,
                VNOMBRE = vv.VNOMBRE
            };
        }
    }
}
