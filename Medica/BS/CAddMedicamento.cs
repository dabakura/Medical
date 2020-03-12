using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BS
{
    public class CAddMedicamento
    {
        private static CAddMedicamento medicamento;

        public static CAddMedicamento Medicamento
        {
            get { return (medicamento != null) ? medicamento : medicamento = new CAddMedicamento(); }
            set { medicamento = value; }
        }

        public bool Guardar(MEDICAMENTO dato)
        {
            try
            {
                AñadirTrama();
                return CMedicamentos.Medicamento.Guardar(Medi);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Clean()
        {
            IndiDiag = null;
            IndiSint = null;
            Efectos = null;
            Dosis = null;
            ContraDiag = null;
            ContraMedi = null;
            Medi = null;
            ContraSint = null;
            Nombre = null;
            Vias = null;
        }

        public bool Modificar(MEDICAMENTO dato)
        {
            try
            {
                AñadirTrama();
                return CMedicamentos.Medicamento.Modificar(Medi);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AñadirTrama()
        {
            Medi.CONTRAINDICACION_DIAGNOSTICO = ContraDiag;
            Medi.CONTRAINDICACION_MEDICAMENTO = ContraMedi;
            Medi.CONTRAINDICACION_SINTOMA = ContraSint;
            Medi.INDICACION_DIAGNOSTICO = IndiDiag;
            Medi.INDICACION_SINTOMA = IndiSint;
            Medi.SINTOMA = Efectos;
        }

        public void EliminaVia(string eliminado)
        {
            Vias.RemoveAll(v => v.VNOMBRE.Equals(eliminado));
        }

        public void EliminaDosis(string rango)
        {
            Dosis.RemoveAll(d => d.VRANGO.Equals(rango));
        }

        public bool AgregarNombre(string nom)
        {
            bool estado;
            if (estado = !Nombre.Any(n => n.VNOMBRE.Equals(nom)))
                Nombre.Add(new MEDI_NOMBRE() { VNOMBRE = nom });
            return estado;
        }

        private List<MEDI_NOMBRE> nombre;

        public List<MEDI_NOMBRE> Nombre
        {
            get { return (nombre != null) ? nombre : nombre = new List<MEDI_NOMBRE>(); }
            set { nombre = value; }
        }

        public List<DOSIS> Dosis { get { return (dosis != null) ? dosis : dosis = new List<DOSIS>(); } set { dosis = value; } }
        public List<VIA_ADMINISTRACION> Vias { get { return (vias != null) ? vias : vias = new List<VIA_ADMINISTRACION>(); } set { vias = value; } }

        public MEDICAMENTO Medi { get { return (medi != null) ? medi : medi = new MEDICAMENTO(); } set { medi = value; } }

        public void AgregarDosis(DOSIS dd)
        {
            Dosis.Add(dd);
        }

        public void ModificarDosis(DOSIS dd)
        {
            Dosis.RemoveAll(d => d.VRANGO.Equals(dd.VRANGO));
            AgregarDosis(dd);
        }



        private List<DOSIS> dosis;
        private List<VIA_ADMINISTRACION> vias;
        private MEDICAMENTO medi;

        public bool AgregarVia(VIA_ADMINISTRACION via)
        {
            bool estado;
            try
            {
                if (estado = !Vias.Any((pdc) => { return pdc.IID == via.IID; }))
                    Vias.Add(via);
                return estado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<CONTRAINDICACION_DIAGNOSTICO> contraDiag;

        public List<CONTRAINDICACION_DIAGNOSTICO> ContraDiag
        {
            get { return (contraDiag != null) ? contraDiag : contraDiag = new List<CONTRAINDICACION_DIAGNOSTICO>(); }
            set { contraDiag = value; }
        }

        private List<CONTRAINDICACION_MEDICAMENTO> contraMedi;

        public List<CONTRAINDICACION_MEDICAMENTO> ContraMedi
        {
            get { return (contraMedi != null) ? contraMedi : contraMedi = new List<CONTRAINDICACION_MEDICAMENTO>(); }
            set { contraMedi = value; }
        }

        private List<CONTRAINDICACION_SINTOMA> contraSint;

        public List<CONTRAINDICACION_SINTOMA> ContraSint
        {
            get { return (contraSint != null) ? contraSint : contraSint = new List<CONTRAINDICACION_SINTOMA>(); }
            set { contraSint = value; }
        }
        private List<INDICACION_DIAGNOSTICO> indiDiag;

        public List<INDICACION_DIAGNOSTICO> IndiDiag
        {
            get { return (indiDiag != null) ? indiDiag : indiDiag = new List<INDICACION_DIAGNOSTICO>(); }
            set { indiDiag = value; }
        }

        private List<INDICACION_SINTOMA> indiSint;

        public List<INDICACION_SINTOMA> IndiSint
        {
            get { return (indiSint != null) ? indiSint : indiSint = new List<INDICACION_SINTOMA>(); }
            set { indiSint = value; }
        }

        private List<SINTOMA> efecto;

        public List<SINTOMA> Efectos
        {
            get { return (efecto != null) ? efecto : efecto = new List<SINTOMA>(); }
            set { efecto = value; }
        }

        public bool AgregarEfecto(SINTOMA s)
        {
            bool estado;
            try
            {
                if (estado = !Efectos.Any((pdc) => { return pdc.IID == s.IID; }))
                    estado = valorarEstadoEfeto(s);
                return estado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool valorarEstadoEfeto(SINTOMA s)
        {
            try
            {
                IndiSint.ForEach( ins => { if (ins.ISINTOMA == s.IID) {
                        MessageBox.Show("Un medicamento no puede generar un Efecto Adverso\ny estar indicado para tratar el mismo","Error logico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        throw new Exception();
                    } });
                Efectos.Add(s);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AgregarIndicaSintoma(INDICACION_SINTOMA indi)
        {
            bool estado;
            try
            {
                if (estado = !IndiSint.Any((pdc) => { return pdc.SINTOMA.IID == indi.SINTOMA.IID; }))
                    estado = valorarEstadoIndicaSintoma(indi);
                return estado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool valorarEstadoIndicaSintoma(INDICACION_SINTOMA indi)
        {
            try
            {
                Efectos.ForEach(ins => {
                    if (ins.IID == indi.SINTOMA.IID)
                    {
                        MessageBox.Show("Un medicamento no puede ser indicado para tratar un sintoma\ny al mismo tiempo provocar un Efecto Adverso con ese sintoma", "Error logico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception();
                    }
                });
                ContraSint.ForEach(ins => {
                    if (ins.SINTOMA.IID == indi.SINTOMA.IID)
                    {
                        MessageBox.Show("Un medicamento no puede estar Contraindicado e Indicado\nal mismo tiempo para un mismo Sintoma", "Error logico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception();
                    }
                });
                IndiSint.Add(indi);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AgregarContraSintoma(CONTRAINDICACION_SINTOMA contra)
        {
            bool estado;
            try
            {
                if (estado = !ContraSint.Any((pdc) => { return pdc.SINTOMA.IID == contra.SINTOMA.IID; }))
                    estado = valorarEstadoContraSintoma(contra);
                return estado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool valorarEstadoContraSintoma(CONTRAINDICACION_SINTOMA indi)
        {
            try
            {
                IndiSint.ForEach(ins => {
                    if (ins.SINTOMA.IID == indi.SINTOMA.IID)
                    {
                        MessageBox.Show("Un medicamento no puede estar Contraindicado e Indicado\nal mismo tiempo para un mismo Sintoma", "Error logico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception();
                    }
                });
                ContraSint.Add(indi);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AgregarIndicaDiagnostico(INDICACION_DIAGNOSTICO contra)
        {
            bool estado;
            try
            {
                if (estado = !IndiDiag.Any((pdc) => { return pdc.DIAGNOSTICO.IID == contra.DIAGNOSTICO.IID; }))
                    estado = valorarEstadoIndicaDiagnostico(contra);
                return estado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool valorarEstadoIndicaDiagnostico(INDICACION_DIAGNOSTICO indi)
        {
            try
            {
                ContraDiag.ForEach(ins => {
                    if (ins.DIAGNOSTICO.IID == indi.DIAGNOSTICO.IID)
                    {
                        MessageBox.Show("Un medicamento no puede estar Contraindicado e Indicado\nal mismo tiempo para un mismo Diagnostico", "Error logico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception();
                    }
                });
                IndiDiag.Add(indi);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AgregarContraDiagnostico(CONTRAINDICACION_DIAGNOSTICO contra)
        {
            bool estado;
            try
            {
                if (estado = !ContraDiag.Any((pdc) => { return pdc.DIAGNOSTICO.IID == contra.DIAGNOSTICO.IID; }))
                    estado = valorarEstadoContraDiagnostico(contra);
                return estado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool valorarEstadoContraDiagnostico(CONTRAINDICACION_DIAGNOSTICO indi)
        {
            try
            {
                IndiDiag.ForEach(ins => {
                    if (ins.DIAGNOSTICO.IID == indi.DIAGNOSTICO.IID)
                    {
                        MessageBox.Show("Un medicamento no puede estar Contraindicado e Indicado\nal mismo tiempo para un mismo Diagnostico", "Error logico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception();
                    }
                });
                ContraDiag.Add(indi);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AgregarContraMedicamento(CONTRAINDICACION_MEDICAMENTO contra)
        {
            bool estado;
            try
            {
                if (estado = !ContraMedi.Any((pdc) => { return pdc.MEDICAMENTO1.ICODIGO == contra.MEDICAMENTO1.ICODIGO; }))
                    ContraMedi.Add(contra);
                return estado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EliminaMedicamento(string eliminado)
        {
            ContraMedi.RemoveAll(n => n.MEDICAMENTO1.MEDI_NOMBRE.First().VNOMBRE.Equals(eliminado));
        }

        public void EliminaSintoma(string eliminado)
        {
            IndiSint.RemoveAll(n => n.SINTOMA.VEFECTO.Equals(eliminado));
        }

        public void EliminaContraSintoma(string eliminado)
        {
            try
            {
                Efectos.ForEach( e => {
                    if (e.VEFECTO.Equals(eliminado))
                        throw new Exception();
                });
                ContraSint.RemoveAll(n => n.SINTOMA.VEFECTO.Equals(eliminado));
            }
            catch (Exception)
            {
                MessageBox.Show("Para eliminar esta contra indicacion debes eliminar el efecto Adverso que la ingreso","Esta contraindicacion no se puede eliminar aqui",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void EliminaEfecto(string eliminado)
        {
            Efectos.RemoveAll(n => n.VEFECTO.Equals(eliminado));
        }

        public void EliminaContraDiagnostico(string eliminado)
        {
            ContraDiag.RemoveAll(n => n.DIAGNOSTICO.VDIAGNOSTICO.Equals(eliminado));
        }

        public void EliminaDiagnostico(string eliminado)
        {
            IndiDiag.RemoveAll(n => n.DIAGNOSTICO.VDIAGNOSTICO.Equals(eliminado));
        }

        public void EliminaNombre(string eliminado)
        {
            Nombre.RemoveAll(n => n.VNOMBRE.Equals(eliminado));
        }
    }
}
