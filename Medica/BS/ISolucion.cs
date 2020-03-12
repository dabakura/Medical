using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BS
{
    public interface ISolucion
    {
        void SalvaPulso(int d);

        void CargaPulso(int d);

        void ControlValue(int d);

        Utiles.EventoEstado Miestado(int d);

        void invocador(Utiles.EventoEstado index);

        void CargarSignos();

        void Reset();

        List<SIGNOS_VITALES> Start(List<SIGNOS_VITALES> vi);
    }
}
