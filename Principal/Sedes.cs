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
    
    public partial class Sedes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sedes()
        {
            this.Habitaciones = new HashSet<Habitaciones>();
            this.MED_SectorMails = new HashSet<MED_SectorMails>();
        }
    
        public int sede_id { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> empresa_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Habitaciones> Habitaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MED_SectorMails> MED_SectorMails { get; set; }
    }
}
