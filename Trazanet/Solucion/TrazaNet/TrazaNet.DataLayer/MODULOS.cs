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
    
    public partial class MODULOS
    {
        public MODULOS()
        {
            this.JAULA = new HashSet<JAULA>();
        }
    
        public int IDMODULO { get; set; }
        public string CODMODULO { get; set; }
        public Nullable<int> IDCENTRO { get; set; }
        public string TIPOMODULO { get; set; }
        public int CANTFILAS { get; set; }
        public int CANTCOLUMNAS { get; set; }
    
        public virtual CENTROS CENTROS { get; set; }
        public virtual ICollection<JAULA> JAULA { get; set; }
    }
}
