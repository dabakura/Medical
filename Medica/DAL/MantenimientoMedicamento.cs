using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;

namespace DAL
{
    public class MantenimientoMedicamento : ICrud<MEDICAMENTO>
    {
        private static MantenimientoMedicamento mantenimiento;

        public static MantenimientoMedicamento Mantenimiento { get { return (mantenimiento != null) ? mantenimiento : mantenimiento = new MantenimientoMedicamento(); } set { mantenimiento = value; } }

        public List<MEDICAMENTO> GetListMedicamento()
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    return GetMEDICAMENTOS(DB.MEDICAMENTO.ToList().FindAll(m => m.BESTADO),true);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public MEDICAMENTO GetMedicamento(string id)
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
                            var query = (from p in DB.MEDICAMENTO where (p.ICODIGO == Iid && p.BESTADO == true) select p).First();
                            return GetMEDICAMENTO(query, true);
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
                            var query = (from p in DB.MEDICAMENTO where (p.MEDI_NOMBRE.ToList().Any(nn => nn.VNOMBRE.Equals(id)) && p.BESTADO == true) select p).First();
                            return GetMEDICAMENTO(query, true);
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

        public bool Eliminar(MEDICAMENTO dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    var query10 = (from p in DB.MEDICAMENTO where p.ICODIGO == dato.ICODIGO select p).First();
                    query10.BESTADO = false;
                    DB.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Guardar(MEDICAMENTO dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    MEDICAMENTO m = DB.MEDICAMENTO.Add(GetMEDICAMENTO(dato, false));
                    DB.SaveChanges();
                    dato.MEDI_NOMBRE.ToList().ForEach(nom => nom.ICODIGO = m.ICODIGO);
                    GetNOMBRES(dato.MEDI_NOMBRE).ToList().ForEach(nom => DB.MEDI_NOMBRE.Add(nom));
                    DB.SaveChanges();
                    dato.DOSIS.ToList().ForEach(nom => nom.ICODIGO = m.ICODIGO);
                    GetDOSISS(dato.DOSIS).ToList().ForEach(d => DB.DOSIS.Add(d));
                    DB.SaveChanges();
                    dato.VIA_ADMINISTRACION.ToList().ForEach( v => m.VIA_ADMINISTRACION.Add((from vv in DB.VIA_ADMINISTRACION where vv.IID == v.IID select vv).First()));
                    DB.SaveChanges();
                    dato.SINTOMA.ToList().ForEach(v => m.SINTOMA.Add((from vv in DB.SINTOMA where vv.IID == v.IID select vv).First()));
                    DB.SaveChanges();
                    dato.INDICACION_DIAGNOSTICO.ToList().ForEach(d => d.ICODIGO = m.ICODIGO);
                    GetINDICACION_DIAGNOSTICOS(dato.INDICACION_DIAGNOSTICO,false).ToList().ForEach(d => DB.INDICACION_DIAGNOSTICO.Add(d));
                    DB.SaveChanges();
                    dato.INDICACION_SINTOMA.ToList().ForEach(d => d.ICODIGO = m.ICODIGO);
                    GetINDICACION_SINTOMAS(dato.INDICACION_SINTOMA, false).ToList().ForEach(d => DB.INDICACION_SINTOMA.Add(d));
                    DB.SaveChanges();
                    dato.CONTRAINDICACION_MEDICAMENTO.ToList().ForEach(d => d.ICODIGO = m.ICODIGO);
                    GetCONTRAINDICACION_MEDICAMENTOS(dato.CONTRAINDICACION_MEDICAMENTO, false).ToList().ForEach(d => DB.CONTRAINDICACION_MEDICAMENTO.Add(d));
                    DB.SaveChanges();
                    dato.CONTRAINDICACION_DIAGNOSTICO.ToList().ForEach(d => d.ICODIGO = m.ICODIGO);
                    GetCONTRAINDICACION_DIAGNOSTICOS(dato.CONTRAINDICACION_DIAGNOSTICO, false).ToList().ForEach(d => DB.CONTRAINDICACION_DIAGNOSTICO.Add(d));
                    DB.SaveChanges();
                    dato.CONTRAINDICACION_SINTOMA.ToList().ForEach(d => d.ICODIGO = m.ICODIGO);
                    GetCONTRAINDICACION_SINTOMAS(dato.CONTRAINDICACION_SINTOMA, false).ToList().ForEach(d => DB.CONTRAINDICACION_SINTOMA.Add(d));
                    DB.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(MEDICAMENTO dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    MEDICAMENTO m = Buscar(dato);
                    dato.MEDI_NOMBRE.ToList().ForEach(nom => nom.ICODIGO = m.ICODIGO);
                    GetNOMBRES(dato.MEDI_NOMBRE).ToList().ForEach(nom => DB.MEDI_NOMBRE.Add(nom));
                    DB.SaveChanges();
                    dato.DOSIS.ToList().ForEach(nom => nom.ICODIGO = m.ICODIGO);
                    GetDOSISS(dato.DOSIS).ToList().ForEach(d => DB.DOSIS.Add(d));
                    DB.SaveChanges();
                    var query1 = (from d in DB.MEDICAMENTO where d.ICODIGO == dato.ICODIGO select d).First();
                    dato.VIA_ADMINISTRACION.ToList().ForEach(v => query1.VIA_ADMINISTRACION.Add((from vv in DB.VIA_ADMINISTRACION where vv.IID == v.IID select vv).First()));
                    DB.SaveChanges();
                    dato.SINTOMA.ToList().ForEach(v => query1.SINTOMA.Add((from vv in DB.SINTOMA where vv.IID == v.IID select vv).First()));
                    DB.SaveChanges();
                    dato.INDICACION_DIAGNOSTICO.ToList().ForEach(d => d.ICODIGO = m.ICODIGO);
                    GetINDICACION_DIAGNOSTICOS(dato.INDICACION_DIAGNOSTICO, false).ToList().ForEach(d => DB.INDICACION_DIAGNOSTICO.Add(d));
                    DB.SaveChanges();
                    dato.INDICACION_SINTOMA.ToList().ForEach(d => d.ICODIGO = m.ICODIGO);
                    GetINDICACION_SINTOMAS(dato.INDICACION_SINTOMA, false).ToList().ForEach(d => DB.INDICACION_SINTOMA.Add(d));
                    DB.SaveChanges();
                    dato.CONTRAINDICACION_MEDICAMENTO.ToList().ForEach(d => d.ICODIGO = m.ICODIGO);
                    GetCONTRAINDICACION_MEDICAMENTOS(dato.CONTRAINDICACION_MEDICAMENTO, false).ToList().ForEach(d => DB.CONTRAINDICACION_MEDICAMENTO.Add(d));
                    DB.SaveChanges();
                    dato.CONTRAINDICACION_DIAGNOSTICO.ToList().ForEach(d => d.ICODIGO = m.ICODIGO);
                    GetCONTRAINDICACION_DIAGNOSTICOS(dato.CONTRAINDICACION_DIAGNOSTICO, false).ToList().ForEach(d => DB.CONTRAINDICACION_DIAGNOSTICO.Add(d));
                    DB.SaveChanges();
                    dato.CONTRAINDICACION_SINTOMA.ToList().ForEach(d => d.ICODIGO = m.ICODIGO);
                    GetCONTRAINDICACION_SINTOMAS(dato.CONTRAINDICACION_SINTOMA, false).ToList().ForEach(d => DB.CONTRAINDICACION_SINTOMA.Add(d));
                    DB.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Elimina(MEDICAMENTO dato)
        {
            try
            {
                MedicalEntities DB = new MedicalEntities();
                (from d in DB.MEDICAMENTO where d.ICODIGO == dato.ICODIGO select d).First().CONTRAINDICACION_DIAGNOSTICO.Clear();
                DB.SaveChanges();
                (from d in DB.MEDICAMENTO where d.ICODIGO == dato.ICODIGO select d).First().CONTRAINDICACION_MEDICAMENTO.Clear();
                DB.SaveChanges();
                (from d in DB.MEDICAMENTO where d.ICODIGO == dato.ICODIGO select d).First().CONTRAINDICACION_MEDICAMENTO1.Clear();
                DB.SaveChanges();
                (from d in DB.MEDICAMENTO where d.ICODIGO == dato.ICODIGO select d).First().CONTRAINDICACION_SINTOMA.Clear();
                DB.SaveChanges();
                (from d in DB.MEDICAMENTO where d.ICODIGO == dato.ICODIGO select d).First().INDICACION_DIAGNOSTICO.Clear();
                DB.SaveChanges();
                (from d in DB.MEDICAMENTO where d.ICODIGO == dato.ICODIGO select d).First().INDICACION_SINTOMA.Clear();
                DB.SaveChanges();
                (from d in DB.MEDICAMENTO where d.ICODIGO == dato.ICODIGO select d).First().MEDI_NOMBRE.Clear();
                DB.SaveChanges();
                (from d in DB.MEDICAMENTO where d.ICODIGO == dato.ICODIGO select d).First().SINTOMA.Clear();
                DB.SaveChanges();
                (from d in DB.MEDICAMENTO where d.ICODIGO == dato.ICODIGO select d).First().VIA_ADMINISTRACION.Clear();
                DB.SaveChanges();
                (from d in DB.MEDICAMENTO where d.ICODIGO == dato.ICODIGO select d).First().DOSIS.Clear();
                DB.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private MEDICAMENTO Buscar(MEDICAMENTO dato)
        {
            try
            {
                MedicalEntities DB = new MedicalEntities();
                MEDICAMENTO m = DB.MEDICAMENTO.First(mm => mm.ICODIGO == dato.ICODIGO);
                Elimina(m);
                m.CONTRAINDICACION_DIAGNOSTICO = new List<CONTRAINDICACION_DIAGNOSTICO>();
                m.CONTRAINDICACION_MEDICAMENTO = new List<CONTRAINDICACION_MEDICAMENTO>();
                m.CONTRAINDICACION_MEDICAMENTO1 = new List<CONTRAINDICACION_MEDICAMENTO>();
                m.CONTRAINDICACION_SINTOMA = new List<CONTRAINDICACION_SINTOMA>();
                m.INDICACION_DIAGNOSTICO = new List<INDICACION_DIAGNOSTICO>();
                m.INDICACION_SINTOMA = new List<INDICACION_SINTOMA>();
                m.MEDI_NOMBRE = new List<MEDI_NOMBRE>();
                m.SINTOMA = new List<SINTOMA>();
                m.DOSIS = new List<DOSIS>();
                m.VIA_ADMINISTRACION = new List<VIA_ADMINISTRACION>();
                m.VCOMPOSIION = dato.VCOMPOSIION;
                m.VDESCRIPCION = dato.VDESCRIPCION;
                m.VESTEROQUIMICA = dato.VESTEROQUIMICA;
                DB.SaveChanges();
                return m;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<MEDICAMENTO> GetMEDICAMENTOS(List<MEDICAMENTO> m, bool b)
        {
            List<MEDICAMENTO> mm = new List<MEDICAMENTO>();
            m.ToList().ForEach( me => mm.Add(GetMEDICAMENTO(me,b)));
            return mm;
        }

        public static MEDICAMENTO GetMEDICAMENTO(MEDICAMENTO p,bool b)
        {
            return new MEDICAMENTO()
            {
                BESTADO = p.BESTADO,
                VCOMPOSIION  = p.VCOMPOSIION,
                ICODIGO = p.ICODIGO,
                VESTEROQUIMICA = p.VESTEROQUIMICA,
                VDESCRIPCION = p.VDESCRIPCION,
                VIA_ADMINISTRACION = ((b) ? MantenimientoVia_Administracion.GetVIA_ADMINISTRACIONES(p.VIA_ADMINISTRACION) : new List<VIA_ADMINISTRACION>()),
                SINTOMA = ((b) ? MantenimientoSintoma.GetSINTOMAS(p.SINTOMA) : new List<SINTOMA>()),
                MEDI_NOMBRE = ((b)?GetNOMBRES(p.MEDI_NOMBRE):new List<MEDI_NOMBRE>()),
                DOSIS = ((b) ? GetDOSISS(p.DOSIS) : new List<DOSIS>()),
                INDICACION_SINTOMA = ((b) ? GetINDICACION_SINTOMAS(p.INDICACION_SINTOMA,b) : new List<INDICACION_SINTOMA>()),
                INDICACION_DIAGNOSTICO = ((b) ? GetINDICACION_DIAGNOSTICOS(p.INDICACION_DIAGNOSTICO,b) : new List<INDICACION_DIAGNOSTICO>()),
                CONTRAINDICACION_DIAGNOSTICO = ((b) ? GetCONTRAINDICACION_DIAGNOSTICOS(p.CONTRAINDICACION_DIAGNOSTICO,b) : new List<CONTRAINDICACION_DIAGNOSTICO>()),
                CONTRAINDICACION_SINTOMA = ((b) ? GetCONTRAINDICACION_SINTOMAS(p.CONTRAINDICACION_SINTOMA,b) : new List<CONTRAINDICACION_SINTOMA>()),
                CONTRAINDICACION_MEDICAMENTO = ((b) ? GetCONTRAINDICACION_MEDICAMENTOS(p.CONTRAINDICACION_MEDICAMENTO,b) : new List<CONTRAINDICACION_MEDICAMENTO>())
            };
        }

        public static MEDICAMENTO GetMEDICAMENTOCONTRA(MEDICAMENTO p)
        {
            return new MEDICAMENTO()
            {
                BESTADO = p.BESTADO,
                VCOMPOSIION = p.VCOMPOSIION,
                ICODIGO = p.ICODIGO,
                VESTEROQUIMICA = p.VESTEROQUIMICA,
                VDESCRIPCION = p.VDESCRIPCION,
                VIA_ADMINISTRACION = MantenimientoVia_Administracion.GetVIA_ADMINISTRACIONES(p.VIA_ADMINISTRACION),
                SINTOMA = MantenimientoSintoma.GetSINTOMAS(p.SINTOMA),
                MEDI_NOMBRE = GetNOMBRES(p.MEDI_NOMBRE),
                DOSIS = new List<DOSIS>(),
                INDICACION_SINTOMA = new List<INDICACION_SINTOMA>(),
                INDICACION_DIAGNOSTICO = new List<INDICACION_DIAGNOSTICO>(),
                CONTRAINDICACION_DIAGNOSTICO = new List<CONTRAINDICACION_DIAGNOSTICO>(),
                CONTRAINDICACION_SINTOMA = new List<CONTRAINDICACION_SINTOMA>(),
                CONTRAINDICACION_MEDICAMENTO = new List<CONTRAINDICACION_MEDICAMENTO>()
            };
        }

        public static List<CONTRAINDICACION_MEDICAMENTO> GetCONTRAINDICACION_MEDICAMENTOS(ICollection<CONTRAINDICACION_MEDICAMENTO> ii, bool b)
        {
            List<CONTRAINDICACION_MEDICAMENTO> list = new List<CONTRAINDICACION_MEDICAMENTO>();
            ii.ToList().ForEach(i => list.Add(GetCONTRAINDICACION_MEDICAMENTO(i,b)));
            return list;
        }

        public static CONTRAINDICACION_MEDICAMENTO GetCONTRAINDICACION_MEDICAMENTO(CONTRAINDICACION_MEDICAMENTO m, bool b)
        {
            return new CONTRAINDICACION_MEDICAMENTO()
            {
               ICODIGO = m.ICODIGO,
               IIDMEDICAMENTO = m.IIDMEDICAMENTO,
               MEDICAMENTO1 = (b)? GetMEDICAMENTOCONTRA(m.MEDICAMENTO1):null,
               VDESCRIPCION = m.VDESCRIPCION
            };
        }

        public static List<CONTRAINDICACION_SINTOMA> GetCONTRAINDICACION_SINTOMAS(ICollection<CONTRAINDICACION_SINTOMA> ii, bool b)
        {
            List<CONTRAINDICACION_SINTOMA> list = new List<CONTRAINDICACION_SINTOMA>();
            ii.ToList().ForEach(i => list.Add(GetCONTRAINDICACION_SINTOMA(i,b)));
            return list;
        }

        public static CONTRAINDICACION_SINTOMA GetCONTRAINDICACION_SINTOMA(CONTRAINDICACION_SINTOMA i, bool b)
        {
            return new CONTRAINDICACION_SINTOMA()
            {
                ICODIGO = i.ICODIGO,
                IIDSINTOMA = i.IIDSINTOMA,
                VDESCRIPCION = i.VDESCRIPCION,
                SINTOMA = (b)?MantenimientoSintoma.GetSINTOMA(i.SINTOMA):null
            };
        }

        public static List<CONTRAINDICACION_DIAGNOSTICO> GetCONTRAINDICACION_DIAGNOSTICOS(ICollection<CONTRAINDICACION_DIAGNOSTICO> id, bool b)
        {
            List<CONTRAINDICACION_DIAGNOSTICO> list = new List<CONTRAINDICACION_DIAGNOSTICO>();
            id.ToList().ForEach(i => list.Add(GetCONTRAINDICACION_DIAGNOSTICO(i,b)));
            return list;
        }

        public static CONTRAINDICACION_DIAGNOSTICO GetCONTRAINDICACION_DIAGNOSTICO(CONTRAINDICACION_DIAGNOSTICO i, bool b)
        {
            return new CONTRAINDICACION_DIAGNOSTICO()
            {
                VDESCRIPCION = i.VDESCRIPCION,
                ICODIGO = i.ICODIGO,
                IIDIAGNOSTICO = i.IIDIAGNOSTICO,
                DIAGNOSTICO = (b)? MantenimientoDiagnostico.GetDIAGNOSTICO(i.DIAGNOSTICO, b): null
            };
        }

        public static List<INDICACION_DIAGNOSTICO> GetINDICACION_DIAGNOSTICOS(ICollection<INDICACION_DIAGNOSTICO> id, bool b)
        {
            List<INDICACION_DIAGNOSTICO> list = new List<INDICACION_DIAGNOSTICO>();
            id.ToList().ForEach(i => list.Add(GetINDICACION_DIAGNOSTICO(i,b)));
            return list;
        }

        public static INDICACION_DIAGNOSTICO GetINDICACION_DIAGNOSTICO(INDICACION_DIAGNOSTICO i, bool b)
        {
            return new INDICACION_DIAGNOSTICO()
            {
                VDESCRIPCION = i.VDESCRIPCION,
                ICODIGO = i.ICODIGO,
                IIDIAGNOSTICO = i.IIDIAGNOSTICO,
                DIAGNOSTICO = (b)? MantenimientoDiagnostico.GetDIAGNOSTICO(i.DIAGNOSTICO,b): null
            };
        }

        public static List<INDICACION_SINTOMA> GetINDICACION_SINTOMAS(ICollection<INDICACION_SINTOMA> ii, bool b)
        {
            List<INDICACION_SINTOMA> list = new List<INDICACION_SINTOMA>();
            ii.ToList().ForEach(i => list.Add(GetINDICACION_SINTOMA(i,b)));
            return list;
        }

        public static INDICACION_SINTOMA GetINDICACION_SINTOMA(INDICACION_SINTOMA i, bool b)
        {
            return new INDICACION_SINTOMA() {
                ICODIGO = i.ICODIGO,
                ISINTOMA = i.ISINTOMA,
                VDESCRIPCION = i.VDESCRIPCION,
                SINTOMA = (b) ?MantenimientoSintoma.GetSINTOMA(i.SINTOMA): null
            };
        }

        public static List<DOSIS> GetDOSISS(ICollection<DOSIS> dd)
        {
            List<DOSIS> list = new List<DOSIS>();
            dd.ToList().ForEach(d => list.Add(GetDOSIS(d)));
            return list;
        }

        public static DOSIS GetDOSIS(DOSIS d)
        {
            return new DOSIS() { DDOSIS = d.DDOSIS, DMAX = d.DMAX, DMIN = d.DMIN, ICODIGO = d.ICODIGO, VRANGO = d.VRANGO};
        }

        public static List<MEDI_NOMBRE> GetNOMBRES(ICollection<MEDI_NOMBRE> n)
        {

            List<MEDI_NOMBRE> list = new List<MEDI_NOMBRE>();
            n.ToList().ForEach(nn => list.Add(new MEDI_NOMBRE() { ICODIGO = nn.ICODIGO, VNOMBRE = nn.VNOMBRE}));
            return list;
        }
    }
}
