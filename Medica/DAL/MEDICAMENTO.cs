//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MEDICAMENTO
    {
        public MEDICAMENTO()
        {
            this.CONTRAINDICACION_DIAGNOSTICO = new HashSet<CONTRAINDICACION_DIAGNOSTICO>();
            this.CONTRAINDICACION_MEDICAMENTO = new HashSet<CONTRAINDICACION_MEDICAMENTO>();
            this.CONTRAINDICACION_MEDICAMENTO1 = new HashSet<CONTRAINDICACION_MEDICAMENTO>();
            this.CONTRAINDICACION_SINTOMA = new HashSet<CONTRAINDICACION_SINTOMA>();
            this.DOSIS = new HashSet<DOSIS>();
            this.INDICACION_DIAGNOSTICO = new HashSet<INDICACION_DIAGNOSTICO>();
            this.INDICACION_SINTOMA = new HashSet<INDICACION_SINTOMA>();
            this.MEDI_NOMBRE = new HashSet<MEDI_NOMBRE>();
            this.SINTOMA = new HashSet<SINTOMA>();
            this.VIA_ADMINISTRACION = new HashSet<VIA_ADMINISTRACION>();
            this.PACIENTE_MEDICAMENTO = new HashSet<PACIENTE_MEDICAMENTO>();
        }
    
        public int ICODIGO { get; set; }
        public string VESTEROQUIMICA { get; set; }
        public string VCOMPOSIION { get; set; }
        public string VDESCRIPCION { get; set; }
        public bool BESTADO { get; set; }
    
        public virtual ICollection<CONTRAINDICACION_DIAGNOSTICO> CONTRAINDICACION_DIAGNOSTICO { get; set; }
        public virtual ICollection<CONTRAINDICACION_MEDICAMENTO> CONTRAINDICACION_MEDICAMENTO { get; set; }
        public virtual ICollection<CONTRAINDICACION_MEDICAMENTO> CONTRAINDICACION_MEDICAMENTO1 { get; set; }
        public virtual ICollection<CONTRAINDICACION_SINTOMA> CONTRAINDICACION_SINTOMA { get; set; }
        public virtual ICollection<DOSIS> DOSIS { get; set; }
        public virtual ICollection<INDICACION_DIAGNOSTICO> INDICACION_DIAGNOSTICO { get; set; }
        public virtual ICollection<INDICACION_SINTOMA> INDICACION_SINTOMA { get; set; }
        public virtual ICollection<MEDI_NOMBRE> MEDI_NOMBRE { get; set; }
        public virtual ICollection<SINTOMA> SINTOMA { get; set; }
        public virtual ICollection<VIA_ADMINISTRACION> VIA_ADMINISTRACION { get; set; }
        public virtual ICollection<PACIENTE_MEDICAMENTO> PACIENTE_MEDICAMENTO { get; set; }
    }
}