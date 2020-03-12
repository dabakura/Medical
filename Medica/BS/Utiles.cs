using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazPlugin;
using System.Xml.Serialization;
using System.IO;
using DAL;
using System.Transactions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;

namespace BS
{
    public class Utiles : IUtiles
    {
        private static Utiles util;

        public static Utiles Util { get { return (util != null) ? util : util = new Utiles(); } set { util = value; } }

        private USUARIO user;

        public dynamic User
        {
            get { return user; }
            set { user = value; }
        }

        private PACIENTE paciente;

        public PACIENTE Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        public dynamic GetEmpleado(string id)
        {
            try
            {
                USUARIO p;
                using (TransactionScope scope = new TransactionScope())
                {
                    p = MantenimientoUsuario.Mantenimiento.GetUsuario(id);
                    scope.Complete();
                }
                return p;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public dynamic GetEmpleados()
        {
            try
            {
                List<USUARIO> p;
                using (TransactionScope scope = new TransactionScope())
                {
                    p = MantenimientoUsuario.Mantenimiento.GetUsuarios();
                    scope.Complete();
                }
                return p;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public dynamic GetMedicamento(string id)
        {
            try
            {
                MEDICAMENTO p;
                using (TransactionScope scope = new TransactionScope())
                {
                    p = MantenimientoMedicamento.Mantenimiento.GetMedicamento(id);
                    scope.Complete();
                }
                return p;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public dynamic GetPaciente(string id)
        {
            try
            {
                PACIENTE p;
                using (TransactionScope scope = new TransactionScope())
                {
                    p = MantenimientoPaciente.Mantenimiento.GetPaciente(id);
                    scope.Complete();
                }
                return p;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public dynamic GetMedicamentos()
        {
            try
            {
                List<MEDICAMENTO> p;
                using (TransactionScope scope = new TransactionScope())
                {
                    p = MantenimientoMedicamento.Mantenimiento.GetListMedicamento();
                    scope.Complete();
                }
                return p;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public dynamic GetPacientes()
        {
            try
            {
                List<PACIENTE> p;
                using (TransactionScope scope = new TransactionScope())
                {
                    p = MantenimientoPaciente.Mantenimiento.GetListPacientes();
                    scope.Complete();
                }
                return p;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public dynamic GetDiagnostico(string id)
        {
            try
            {
                DIAGNOSTICO d;
                using (TransactionScope scope = new TransactionScope())
                {
                    d = MantenimientoDiagnostico.Mantenimiento.GetDiagnostico(id);
                    scope.Complete();
                }
                return d;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public dynamic GetDiagnosticos()
        {
            try
            {
                List<DIAGNOSTICO> d;
                using (TransactionScope scope = new TransactionScope())
                {
                    d = MantenimientoDiagnostico.Mantenimiento.GetListDiagnosticos();
                    scope.Complete();
                }
                return d;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public dynamic GetVias_Administracion()
        {
            try
            {
                List<VIA_ADMINISTRACION> d;
                using (TransactionScope scope = new TransactionScope())
                {
                    d = MantenimientoVia_Administracion.Mantenimiento.GetListVia_Administracion();
                    scope.Complete();
                }
                return d;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public dynamic GetVia_Administracion(string id)
        {
            try
            {
                VIA_ADMINISTRACION d;
                using (TransactionScope scope = new TransactionScope())
                {
                    d = MantenimientoVia_Administracion.Mantenimiento.GetVia_Administracion(id);
                    scope.Complete();
                }
                return d;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public dynamic GetSintomas()
        {
            try
            {
                List<SINTOMA> d;
                using (TransactionScope scope = new TransactionScope())
                {
                    d = MantenimientoSintoma.Mantenimiento.GetListSintomas();
                    scope.Complete();
                }
                return d;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public dynamic GetSintoma(string id)
        {
            try
            {
                SINTOMA d;
                using (TransactionScope scope = new TransactionScope())
                {
                    d = MantenimientoSintoma.Mantenimiento.GetSintoma(id);
                    scope.Complete();
                }
                return d;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void SerializarXML<T>(object list, string nombre)
        {
            try
            {
                XmlSerializer formato = new XmlSerializer(typeof(List<T>));
                Stream stream = new FileStream(nombre, FileMode.Create, FileAccess.Write, FileShare.None);
                formato.Serialize(stream, (List<T>)list);
                stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ocurrido al guardar la Lista\n" + e.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static List<T> DeSerializarXML<T>(string nombre)
        {
            if (File.Exists(nombre))
            {
                try
                {
                    XmlSerializer formato = new XmlSerializer(typeof(List<T>));
                    Stream stream = new FileStream(nombre, FileMode.Open, FileAccess.Read, FileShare.None);
                    List<T> list = (List<T>)formato.Deserialize(stream);
                    stream.Close();
                    return list;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error ocurrido al Abrir la Lista\n" + e.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }

        public static void SerializarBINARY<T>(object list, string nombre)
        {
            try
            {
                BinaryFormatter formato = new BinaryFormatter();
                Stream stream = new FileStream(nombre, FileMode.Create, FileAccess.Write, FileShare.None);
                formato.Serialize(stream, (List<T>)list);
                stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ocurrido al guardar la Lista\n" + e.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static List<T> DeSerializarBINARY<T>(string nombre)
        {
            if (File.Exists(nombre))
            {
                try
                {
                    BinaryFormatter formato = new BinaryFormatter();
                    Stream stream = new FileStream(nombre, FileMode.Open, FileAccess.Read, FileShare.None);
                    List<T> list = (List<T>)formato.Deserialize(stream);
                    stream.Close();
                    return list;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error ocurrido al Abrir la Lista\n" + e.Message, "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }


        public enum Rol
        {
            Administrador = 1,
            Medico = 2,
            Enfermera = 3,
            Farmaceutico = 4,
            Otros = 5,
            Ninguno = 6
        }

        public string GetRol(Rol r)
        {
            switch (r)
            {
                case Rol.Administrador:
                    return "Administrador";
                case Rol.Medico:
                    return "Medico";
                case Rol.Enfermera:
                    return "Enfermera";
                case Rol.Farmaceutico:
                    return "Farmaceutico";
                case Rol.Ninguno:
                    return "Ninguno";
                default:
                    return "Otros";
            }
        }

        public Rol GetRol(string r)
        {
            if (String.IsNullOrEmpty(r)) return Rol.Ninguno;
            switch (r)
            {
                case "Administrador":
                    return Rol.Administrador;
                case "Medico":
                    return Rol.Medico;
                case "Enfermera":
                    return Rol.Enfermera;
                case "Farmaceutico":
                    return Rol.Farmaceutico;
                default:
                    return Rol.Otros;
            }
        }

        public Rol GetRol()
        {
            return (user!=null) ? GetRol(user.VROL) : Rol.Ninguno;
        }

        public enum EventoEstado
        {
            Alto = 0,
            Normal = 1,
            Bajo = 2
        }
        
        public static Color EventoColor(EventoEstado e)
        {
            switch (e)
            {
                case EventoEstado.Alto:
                    return Color.Red;
                case EventoEstado.Normal:
                    return Color.SpringGreen;
                case EventoEstado.Bajo:
                    return Color.DeepSkyBlue;
                default:
                    return Color.DeepSkyBlue;
            }
        }
    }
}
