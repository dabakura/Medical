using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using DAL;

namespace BS
{
    public class CKardex
    {
        private static CKardex kardex;

        public static CKardex Kardex { get { return (kardex != null) ? kardex : kardex = new CKardex(); } set { kardex = value; } }

        private List<PACIENTE_SINTOMA> sintomas;
        
        public List<MEDICAMENTO> medicamentos;

        private List<PACIENTE_MEDICAMENTO> pacienteMedicamento;

        public List<PACIENTE_MEDICAMENTO> PacienteMedicamento
        {
            get { return (pacienteMedicamento != null) ? pacienteMedicamento : pacienteMedicamento = new List<PACIENTE_MEDICAMENTO>(); }
            set { pacienteMedicamento = value; }
        }

        public List<CMedi> start()
        {
            List<CMedi> list = new List<CMedi>();
            PacienteMedicamento.Clear();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    MantenimientoPaciente.Mantenimiento.GetPACIENTE_MEDICAMENTOS(Utiles.Util.Paciente.VIDENTIFICACION).ForEach(ps => {
                        ps.PACIENTE = GetMYPACIENTE();
                        PacienteMedicamento.Add(ps);
                        list.Add(CFactoryMedi.CrearFilaMedicamento(ps, true));
                    });
                    scope.Complete();
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<MEDICAMENTO> Medicamentos
        {
            get { return (medicamentos != null) ? medicamentos : medicamentos = (List<MEDICAMENTO>)Utiles.Util.GetMedicamentos(); }
            set { medicamentos = value; }
        }

        public List<PACIENTE_SINTOMA> Sintomas
        {
            get { return (sintomas != null) ? sintomas : sintomas = new List<PACIENTE_SINTOMA>(); }
            set { sintomas = value; }
        }

        public bool AgregarSintoma(SINTOMA sig)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    if (!Sintomas.Exists(s => (s.IIDSINTOMA == sig.IID && s.BESTADO)))
                    {
                        if (!Sintomas.Exists(s => (s.IIDSINTOMA == sig.IID && !s.BESTADO)))
                            Sintomas.Add(new PACIENTE_SINTOMA() { BESTADO = true, IIDSINTOMA = sig.IID, VIDENTIFICACION = Utiles.Util.Paciente.VIDENTIFICACION, SINTOMA = sig, PACIENTE = GetMYPACIENTE() });
                        else
                            Sintomas.Find(s => (s.IIDSINTOMA == sig.IID && !s.BESTADO)).BESTADO = true;
                        estado = MantenimientoPaciente.Mantenimiento.GuardarSintoma(Sintomas);
                    }
                    scope.Complete();
                }
                return estado;
            }
            catch (DbUpdateException)
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<String> GetPacienteSintoma()
        {
            List<String> lista = new List<string>();
            Sintomas.ForEach( s => { if (s.BESTADO) { lista.Add(s.SINTOMA.VEFECTO); } });
            return lista;
        }

        public bool RemoverSintoma(string eliminado)
        {
            try
            {
                bool estado = false;
                using (TransactionScope scope = new TransactionScope())
                {
                    if (Sintomas.Exists(s => (s.SINTOMA.VEFECTO.Equals(eliminado) && s.BESTADO)))
                    {
                        Sintomas.Find(s => (s.SINTOMA.VEFECTO.Equals(eliminado) && s.BESTADO)).BESTADO = false;
                        estado = MantenimientoPaciente.Mantenimiento.GuardarSintoma(Sintomas);
                    }
                    scope.Complete();
                }
                return estado;
            }
            catch (DbUpdateException)
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public AutoCompleteStringCollection getAutoCompleteString(ComboBox c)
        {
            c.Items.Clear();
            var source = new AutoCompleteStringCollection();
            Medicamentos = null;
            Medicamentos.ForEach((d) => { d.MEDI_NOMBRE.ToList().ForEach(dd => { source.Add(dd.VNOMBRE);c.Items.Add(dd.VNOMBRE); }); });
            return source;
        }

        public MEDICAMENTO GetMEDICAMENTO(String nombre,TextBox info,ComboBox via,ComboBox rango)
        {
            try
            {
                MEDICAMENTO m = Medicamentos.First(mm => mm.MEDI_NOMBRE.Any(n => n.VNOMBRE == nombre));
                info.Clear();
                if (m!=null)
                {
                    m.DOSIS.ToList().ForEach(
                    d => { info.AppendText ("Rango: \t\t" + d.VRANGO + String.Format(Environment.NewLine) + "Dosis: \t\t" + d.DDOSIS + String.Format(Environment.NewLine) + "Dosis Minima: \t" + d.DMIN + String.Format(Environment.NewLine) + "Dosis Maxima: \t" + d.DMAX + String.Format(Environment.NewLine) + String.Format(Environment.NewLine)); }
                    );
                    info.AppendText("\nDescripcion:" + String.Format(Environment.NewLine) + m.VDESCRIPCION);
                    via.DataSource = null;
                    via.AutoCompleteCustomSource = getAutoCompleteString(m.VIA_ADMINISTRACION,via);
                    rango.DataSource = null;
                    rango.AutoCompleteCustomSource = getAutoCompleteString(m.DOSIS,rango);
                }
                return m;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private AutoCompleteStringCollection getAutoCompleteString(ICollection<VIA_ADMINISTRACION> v, ComboBox c)
        {
            c.Items.Clear();
            var source = new AutoCompleteStringCollection();
            v.ToList().ForEach(dd => { source.Add(dd.VNOMBRE); c.Items.Add(dd.VNOMBRE); });
            return source;
        }

        private AutoCompleteStringCollection getAutoCompleteString(ICollection<DOSIS> v, ComboBox c)
        {
            c.Items.Clear();
            var source = new AutoCompleteStringCollection();
            v.ToList().ForEach(dd => { source.Add(dd.VRANGO); c.Items.Add(dd.VRANGO); });
            return source;
        }

        public CMedi SetMedicamento(PACIENTE_MEDICAMENTO pm)
        {
            try
            {
                if (CFactoryMedi.InspecionarExistencia(PacienteMedicamento, pm))
                {
                    if (CFactoryMedi.InspecionarLimitacion(PacienteMedicamento, pm))
                    {
                        CMedi medi = CFactoryMedi.CrearFilaMedicamento(pm, false);
                        if (medi != null)
                        {
                            PacienteMedicamento.Add(pm);
                            AccionMedicamento();
                        }
                        return medi;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public CMedi ModificaMedicamento(PACIENTE_MEDICAMENTO pm)
        {
            try
            {
                if (!CFactoryMedi.InspecionarExistencia(PacienteMedicamento, pm))
                {
                    if (CFactoryMedi.InspecionarLimitacion(PacienteMedicamento, pm))
                    {
                        CMedi medi = CFactoryMedi.CrearFilaMedicamento(pm, false);
                        if (medi != null)
                        {
                            int i = PacienteMedicamento.IndexOf(PacienteMedicamento.Find(p => p.ICODIGO == pm.ICODIGO));
                            PacienteMedicamento.RemoveAt(i);
                            PacienteMedicamento.Insert(i, pm);
                            AccionMedicamento();
                        }
                        return medi;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AccionMedicamento()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    MantenimientoPaciente.Mantenimiento.GuardarMedicamento(PacienteMedicamento);
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminaMedicamento(PACIENTE_MEDICAMENTO pm)
        {
            try
            {
                if (!CFactoryMedi.InspecionarExistencia(PacienteMedicamento, pm))
                {
                    PacienteMedicamento.Remove(PacienteMedicamento.Find(p => p.ICODIGO == pm.ICODIGO));
                    AccionMedicamento();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PACIENTE GetMYPACIENTE()
        {
            if (Utiles.Util.Paciente != null)
            {
                return (PACIENTE) Utiles.Util.GetPaciente(Utiles.Util.Paciente.VIDENTIFICACION);
            }
            return null;
        }
    }
}
