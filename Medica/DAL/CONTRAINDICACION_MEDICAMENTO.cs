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
    
    public partial class CONTRAINDICACION_MEDICAMENTO
    {
        public int ICODIGO { get; set; }
        public int IIDMEDICAMENTO { get; set; }
        public string VDESCRIPCION { get; set; }
    
        public virtual MEDICAMENTO MEDICAMENTO { get; set; }
        public virtual MEDICAMENTO MEDICAMENTO1 { get; set; }
    }
}
