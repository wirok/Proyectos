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
    
    public partial class DENIERRED
    {
        public DENIERRED()
        {
            this.TIPORED = new HashSet<TIPORED>();
        }
    
        public int IDDENIERRED { get; set; }
        public string NOMDENIER { get; set; }
        public string DESCDENIER { get; set; }
    
        public virtual ICollection<TIPORED> TIPORED { get; set; }
    }
}
