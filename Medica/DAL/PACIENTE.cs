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
    
    public partial class PACIENTE
    {
        public PACIENTE()
        {
            this.PACIENTE_SINTOMA = new HashSet<PACIENTE_SINTOMA>();
            this.PADECIMIENTO = new HashSet<PADECIMIENTO>();
            this.SIGNOS_VITALES = new HashSet<SIGNOS_VITALES>();
            this.PACIENTE_MEDICAMENTO = new HashSet<PACIENTE_MEDICAMENTO>();
        }
    
        public string VIDENTIFICACION { get; set; }
        public int IDIAGNOSTICO { get; set; }
        public int IEDAD { get; set; }
        public decimal DTALLA { get; set; }
        public decimal DPESO { get; set; }
    
        public virtual DATOSPERSONALES DATOSPERSONALES { get; set; }
        public virtual DIAGNOSTICO DIAGNOSTICO { get; set; }
        public virtual ICollection<PACIENTE_SINTOMA> PACIENTE_SINTOMA { get; set; }
        public virtual ICollection<PADECIMIENTO> PADECIMIENTO { get; set; }
        public virtual ICollection<SIGNOS_VITALES> SIGNOS_VITALES { get; set; }
        public virtual ICollection<PACIENTE_MEDICAMENTO> PACIENTE_MEDICAMENTO { get; set; }
    }
}
