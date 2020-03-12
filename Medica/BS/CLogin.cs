using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Transactions;

namespace BS
{
    public class CLogin
    {
        private static CLogin login;

        public static CLogin Login
        {
            get { return (login != null) ? login : login = new CLogin(); }
            set { login = value; }
        }

        public bool Logearce(string user, string pass)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    USUARIO u = MantenimientoUsuario.Mantenimiento.Autitenficar(user, pass);
                    if (estado = (u != null))
                        Utiles.Util.User = u;
                }
                return estado;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
