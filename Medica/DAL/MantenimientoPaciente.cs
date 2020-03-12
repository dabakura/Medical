using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace DAL
{
    public class MantenimientoPaciente : ICrud<PACIENTE>
    {
        private static MantenimientoPaciente mantenimiento;

        public static MantenimientoPaciente Mantenimiento { get { return (mantenimiento != null) ? mantenimiento : mantenimiento = new MantenimientoPaciente(); } set { mantenimiento = value; } }

        public List<PACIENTE> GetListPacientes()
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    List<PACIENTE> list = DB.PACIENTE.ToList();
                    list.ForEach(p =>  p = GetPACIENTE(p,true));
                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public PACIENTE GetPaciente(string id)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    try
                    {
                        var query = (from p in DB.PACIENTE where p.VIDENTIFICACION == id select  p).First();
                        return GetPACIENTE(query,true);
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

        public bool Eliminar(PACIENTE dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    try
                    {
                        var pac = from p in DB.PADECIMIENTO where p.IIDPACIENTE == dato.VIDENTIFICACION select p;
                        foreach (PADECIMIENTO item in pac)
                        {
                            DB.PADECIMIENTO.Remove(item);
                            DB.SaveChanges();
                        }
                    }
                    catch (DbUpdateException) { }
                    try
                    {
                        var pac = from p in DB.PACIENTE_SINTOMA where p.VIDENTIFICACION == dato.VIDENTIFICACION select p;
                        foreach (PACIENTE_SINTOMA item in pac)
                        {
                            DB.PACIENTE_SINTOMA.Remove(item);
                            DB.SaveChanges();
                        }
                    }
                    catch (DbUpdateException) { }
                    try
                    {
                        var pac = from p in DB.PACIENTE_MEDICAMENTO where p.VIDENTIFICACION == dato.VIDENTIFICACION select p;
                        foreach (PACIENTE_MEDICAMENTO item in pac)
                        {
                            DB.PACIENTE_MEDICAMENTO.Remove(item);
                            DB.SaveChanges();
                        }
                    }
                    catch (DbUpdateException) { }
                    try
                    {
                        var pac = from p in DB.SIGNOS_VITALES where p.IIDPACIENTE == dato.VIDENTIFICACION select p;
                        foreach (SIGNOS_VITALES item in pac)
                        {
                            DB.SIGNOS_VITALES.Remove(item);
                            DB.SaveChanges();
                        }
                    }
                    catch (DbUpdateException) { }
                    DB.PACIENTE.Remove(DB.PACIENTE.First(pp => pp.VIDENTIFICACION == dato.VIDENTIFICACION));
                    DB.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Guardar(PACIENTE dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    try
                    {
                        DB.DATOSPERSONALES.Add(dato.DATOSPERSONALES);
                        DB.SaveChanges();
                    }
                    catch (DbUpdateException)
                    {
                        DB.DATOSPERSONALES.Remove(dato.DATOSPERSONALES);
                    }
                    DB.PACIENTE.Add(GetPACIENTE(dato,false));
                    DB.SaveChanges();
                    dato.PADECIMIENTO.ToList().ForEach((pdc) =>
                    {
                        DB.PADECIMIENTO.Add(GetPADECIMIENTO(pdc,false));
                        DB.SaveChanges();
                    });
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Modificar(PACIENTE dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    try
                    {
                        var pac = from p in DB.PADECIMIENTO where p.IIDPACIENTE == dato.VIDENTIFICACION select p;
                        foreach (PADECIMIENTO item in pac)
                        {
                            DB.PADECIMIENTO.Remove(item);
                            DB.SaveChanges();
                        }
                    }
                    catch (DbUpdateException) { }

                    DATOSPERSONALES datap = DB.DATOSPERSONALES.First(pp => pp.VCEDULA.Equals(dato.VIDENTIFICACION));
                    datap.VCEDULA = dato.DATOSPERSONALES.VCEDULA;
                    datap.VGENERO = dato.DATOSPERSONALES.VGENERO;
                    datap.DTFECHANACIMIENTO = dato.DATOSPERSONALES.DTFECHANACIMIENTO;
                    datap.VNOMBRE = dato.DATOSPERSONALES.VNOMBRE;
                    datap.VPRIMERAPELLIDO = dato.DATOSPERSONALES.VPRIMERAPELLIDO;
                    datap.VSEGUNDOPELLIDO = dato.DATOSPERSONALES.VSEGUNDOPELLIDO;
                    DB.SaveChanges();
                    PACIENTE paciente = DB.PACIENTE.First(pp => pp.VIDENTIFICACION.Equals(dato.VIDENTIFICACION));
                    paciente.IEDAD = dato.IEDAD;
                    paciente.DPESO = dato.DPESO;
                    paciente.DTALLA = dato.DTALLA;
                    paciente.IDIAGNOSTICO = dato.IDIAGNOSTICO;
                    DB.SaveChanges();
                    dato.PADECIMIENTO.ToList<PADECIMIENTO>().ForEach((pdc) =>
                    {
                        DB.PADECIMIENTO.Add(GetPADECIMIENTO(pdc, false));
                        DB.SaveChanges();
                    });
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool GuardarSintoma(List<PACIENTE_SINTOMA> dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    if (dato.Count > 0)
                    {
                        string paci = dato.First().VIDENTIFICACION;
                        var pas = DB.PACIENTE_SINTOMA.Where(pa => pa.VIDENTIFICACION == paci);
                        foreach(PACIENTE_SINTOMA ps in pas)
                        {
                            DB.PACIENTE_SINTOMA.Remove(ps);
                            DB.SaveChanges();
                        }
                        dato.ForEach(d => DB.PACIENTE_SINTOMA.Add(GetPACIENTESINTOMA(d,false)));
                        DB.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool GuardarMedicamento(List<PACIENTE_MEDICAMENTO> dato)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    if (dato.Count > 0)
                    {
                        string paci = dato.First().VIDENTIFICACION;
                        var pas = DB.PACIENTE_MEDICAMENTO.Where(pa => pa.VIDENTIFICACION == paci);
                        foreach (PACIENTE_MEDICAMENTO ps in pas)
                        {
                            DB.PACIENTE_MEDICAMENTO.Remove(ps);
                            DB.SaveChanges();
                        }
                        dato.ForEach(d => DB.PACIENTE_MEDICAMENTO.Add(GetPACIENTEMEDICAMENTO(d, false)));
                        DB.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<PADECIMIENTO> GetPADECIMIENTOS(List<PADECIMIENTO> p)
        {
            List<PADECIMIENTO> po = new List<PADECIMIENTO>();
            p.ForEach(pa => po.Add(GetPADECIMIENTO(pa,true)));
            return po;
        }

        private PADECIMIENTO GetPADECIMIENTO(PADECIMIENTO p,bool b)
        {
            return new PADECIMIENTO()
            {
                BESTADO = p.BESTADO,
                DTFECHAFINALIZACION = p.DTFECHAFINALIZACION,
                IIDPACIENTE = p.IIDPACIENTE,
                IIDDIAGNOSTICO = p.IIDDIAGNOSTICO,
                DTFECHAINICIO = p.DTFECHAINICIO,
                IID = p.IID,
                DIAGNOSTICO = ((b) ? MantenimientoDiagnostico.GetDIAGNOSTICO(p.DIAGNOSTICO,false) : null)
            };
        }

        public List<PACIENTE_MEDICAMENTO> GetPACIENTE_MEDICAMENTOS(string id)
        {
            try
            {
                using (MedicalEntities DB = new MedicalEntities())
                {
                    var pas = DB.PACIENTE_MEDICAMENTO.Where(pa => pa.VIDENTIFICACION == id);
                    return GetPACIENTEMEDICAMENTOS(pas.ToList());
                }
            }
            catch (Exception)
            {
                throw;
            }
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

        public PACIENTE GetPACIENTE(PACIENTE p,bool b)
        {
            return new PACIENTE()
            {
                DPESO = p.DPESO,
                DATOSPERSONALES = ((b) ? GetDATOSPERSONALES(p.DATOSPERSONALES) : null),
                PADECIMIENTO = ((b) ? GetPADECIMIENTOS(p.PADECIMIENTO.ToList()) : null),
                DIAGNOSTICO = ((b) ? MantenimientoDiagnostico.GetDIAGNOSTICO(p.DIAGNOSTICO, false) : null),
                SIGNOS_VITALES = ((b) ? MantenimientoSignosVitales.Mantenimiento.GetListSignosVitales(p.VIDENTIFICACION) : null),
                PACIENTE_SINTOMA = ((b) ? GetPACIENTESINTOMAS(p.PACIENTE_SINTOMA.ToList()) : null),
                PACIENTE_MEDICAMENTO = ((b) ? GetPACIENTEMEDICAMENTOS(p.PACIENTE_MEDICAMENTO.ToList()) : null),
                DTALLA = p.DTALLA,
                IDIAGNOSTICO = p.IDIAGNOSTICO,
                IEDAD = p.IEDAD,
                VIDENTIFICACION = p.VIDENTIFICACION
            };
        }

        private List<PACIENTE_MEDICAMENTO> GetPACIENTEMEDICAMENTOS(List<PACIENTE_MEDICAMENTO> list)
        {
            List<PACIENTE_MEDICAMENTO> sin = new List<PACIENTE_MEDICAMENTO>();
            list.ForEach(l => sin.Add(GetPACIENTEMEDICAMENTO(l,true)));
            return sin;
        }

        private PACIENTE_MEDICAMENTO GetPACIENTEMEDICAMENTO(PACIENTE_MEDICAMENTO l,bool b)
        {
            return new PACIENTE_MEDICAMENTO() {
                DDOSIS = l.DDOSIS,
                ICODIGO = l.ICODIGO,
                VIDENTIFICACION = l.VIDENTIFICACION,
                VDESCRIPCION = l.VDESCRIPCION,
                VRANGO = l.VRANGO,
                VVIAADMINISTRACION = l.VVIAADMINISTRACION,
                MEDICAMENTO = ((b) ?MantenimientoMedicamento.GetMEDICAMENTO(l.MEDICAMENTO, b) : null)
            };
        }

        private List<PACIENTE_SINTOMA> GetPACIENTESINTOMAS(List<PACIENTE_SINTOMA> list)
        {
            List<PACIENTE_SINTOMA> sin = new List<PACIENTE_SINTOMA>();
            list.ForEach(l => sin.Add(GetPACIENTESINTOMA(l,true)));
            return sin;
        }

        private PACIENTE_SINTOMA GetPACIENTESINTOMA(PACIENTE_SINTOMA l, bool b)
        {
            return new PACIENTE_SINTOMA() {
                BESTADO = l.BESTADO,
                IIDSINTOMA = l.IIDSINTOMA,
                VIDENTIFICACION = l.VIDENTIFICACION,
                SINTOMA = ((b) ? MantenimientoSintoma.GetSINTOMA(l.SINTOMA) : null)
            };
        }
    }
}
