//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Principal
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_Menus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Menus()
        {
            this.TBL_PerfilesPermisos = new HashSet<TBL_PerfilesPermisos>();
        }
    
        public int Id_Menu { get; set; }
        public Nullable<int> Id_MenuPadre { get; set; }
        public string DescripcionMenu { get; set; }
        public int PosicionMenu { get; set; }
        public bool HabilitadoMenu { get; set; }
        public string UrlMenu { get; set; }
        public bool FormularioAsociado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_PerfilesPermisos> TBL_PerfilesPermisos { get; set; }
    }
}
