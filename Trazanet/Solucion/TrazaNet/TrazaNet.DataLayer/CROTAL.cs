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
    
    public partial class CROTAL
    {
        public int IDCROTAL { get; set; }
        public string CODCROTAL { get; set; }
        public Nullable<int> IDRED { get; set; }
        public Nullable<System.DateTime> FECINICIOCROTAL { get; set; }
        public Nullable<System.DateTime> FECFINCROTAL { get; set; }
    
        public virtual RED RED { get; set; }
    }
}
