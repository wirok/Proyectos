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
    
    public partial class JAULA
    {
        public JAULA()
        {
            this.MOVIMIENTORED = new HashSet<MOVIMIENTORED>();
        }
    
        public int IDJAULA { get; set; }
        public string CODJAULA { get; set; }
        public Nullable<int> IDMODULO { get; set; }
        public Nullable<bool> CABECERA { get; set; }
        public int POSICIONFILA { get; set; }
        public int POSICIONCOLUMNA { get; set; }
    
        public virtual MODULOS MODULOS { get; set; }
        public virtual ICollection<MOVIMIENTORED> MOVIMIENTORED { get; set; }
    }
}