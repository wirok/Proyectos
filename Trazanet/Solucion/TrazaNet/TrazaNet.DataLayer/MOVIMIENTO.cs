//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrazaNet.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class MOVIMIENTO
    {
        public MOVIMIENTO()
        {
            this.MOVIMIENTORED = new HashSet<MOVIMIENTORED>();
        }
    
        public int IDMOVIMIENTO { get; set; }
        public Nullable<int> IDTRANSPORTE { get; set; }
        public Nullable<int> IDSERVICIO { get; set; }
        public string RUTTALLER { get; set; }
        public int IDCENTRO { get; set; }
        public string TIPOMOVIMIENTO { get; set; }
        public string DOCTRASLADO { get; set; }
        public string DOCSERVICIOBUCEO { get; set; }
        public Nullable<System.DateTime> FECHAINICIOMOVIMIENTO { get; set; }
        public Nullable<System.DateTime> FECHAFINMOVIMIENTO { get; set; }
        public string COMENTARIOSMOVIMIENTO { get; set; }
        public Nullable<int> TOTALNETO { get; set; }
        public Nullable<int> TOTALIMPUESTOS { get; set; }
        public Nullable<int> TOTAL { get; set; }
        public string ESTADO { get; set; }
        public Nullable<System.DateTime> FECHACREACION { get; set; }
        public string CHOFERTRANSPORTE { get; set; }
    
        public virtual CENTROS CENTROS { get; set; }
        public virtual ICollection<MOVIMIENTORED> MOVIMIENTORED { get; set; }
        public virtual TALLER TALLER { get; set; }
        public virtual SERVICIOBUCEO SERVICIOBUCEO { get; set; }
        public virtual TRANSPORTE TRANSPORTE { get; set; }
    }
}
