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
    
    public partial class TRANSPORTE
    {
        public TRANSPORTE()
        {
            this.MOVIMIENTO = new HashSet<MOVIMIENTO>();
        }
    
        public int IDTRANSPORTE { get; set; }
        public string PATENTETRANSPORTE { get; set; }
        public Nullable<bool> TRASPORTEPROPIO { get; set; }
        public string EMPRESATRANSPORTE { get; set; }
    
        public virtual ICollection<MOVIMIENTO> MOVIMIENTO { get; set; }
    }
}
