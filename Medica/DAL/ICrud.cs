using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICrud<T>
    {
        bool Guardar(T dato);
        bool Eliminar(T dato);
        bool Modificar(T dato);
    }
}
