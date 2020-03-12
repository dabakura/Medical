using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MantenimientoUsuario : ICrud<DIAGNOSTICO>
    {

        private static MantenimientoUsuario mantenimiento;

        public static MantenimientoUsuario Mantenimiento
        {
            get { return (mantenimiento != null) ? mantenimiento : mantenimiento = new MantenimientoUsuario(); }
            set { mantenimiento = value; }
        }

        public USUARIO Autitenficar(string user, string pass)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    try
                    {
                        var query = (from p in DB.USUARIO where (p.USUARIO1 == user && p.PASSWORD == pass) select p).First();
                        return GetUSUARIO(query);
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

        public USUARIO GetUsuario(string id)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    try
                    {
                        var query = (from p in DB.USUARIO where p.IDDATOSPERSONALES == id select p).First();
                        return GetUSUARIO(query);
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

        public List<USUARIO> GetUsuarios()
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    try
                    {
                        List<USUARIO> list = new List<USUARIO>();
                        DB.USUARIO.ToList().ForEach(u => list.Add(GetUSUARIO(u)));
                        return list;
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

        public bool Eliminar(DIAGNOSTICO dato)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(DIAGNOSTICO dato)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(DIAGNOSTICO dato)
        {
            throw new NotImplementedException();
        }

        private DATOSPERSONALES GetDATOSPERSONALES(DATOSPERSONALES p)
        {
            return new DATOSPERSONALES()
            {
                DTFECHANACIMIENTO = p.DTFECHANACIMIENTO,
                VCEDULA = p.VCEDULA,
                VGENERO = p.VGENERO,
                VNOMBRE = p.VNOMBRE,
                VPRIMERAPELLIDO = p.VPRIMERAPELLIDO,
                VSEGUNDOPELLIDO = p.VSEGUNDOPELLIDO
            };
        }

        private USUARIO GetUSUARIO(USUARIO p)
        {
            return new USUARIO()
            {
                DATOSPERSONALES = GetDATOSPERSONALES(p.DATOSPERSONALES),
                IDDATOSPERSONALES = p.IDDATOSPERSONALES,
                PASSWORD = p.PASSWORD,
                USUARIO1 = p.USUARIO1,
                VROL = p.VROL
            };
        }
    }
}
