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
    
    public partial class MED_ListaEspera
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MED_ListaEspera()
        {
            this.MED_ListaEsperaModulo = new HashSet<MED_ListaEsperaModulo>();
            this.MED_PuntajeAdicionalListaEspera = new HashSet<MED_PuntajeAdicionalListaEspera>();
            this.MED_CultivosListaEspera = new HashSet<MED_CultivosListaEspera>();
        }
    
        public int espera_id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<short> edad { get; set; }
        public string genero { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public Nullable<int> tipoDocumento_id { get; set; }
        public Nullable<int> numeroDocumento { get; set; }
        public Nullable<int> diagnostico_id { get; set; }
        public Nullable<System.DateTime> fechaIngreso { get; set; }
        public string obraSocial_id { get; set; }
        public string nroAfiliado { get; set; }
        public Nullable<System.DateTime> fechaEgreso { get; set; }
        public Nullable<int> motivoEgreso_id { get; set; }
        public Nullable<int> usuario_id { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<int> deriva { get; set; }
        public string obs { get; set; }
        public string cultivo { get; set; }
        public Nullable<System.DateTime> fechaHisopado { get; set; }
        public Nullable<bool> esReingreso { get; set; }
        public Nullable<bool> vieneRecomendado { get; set; }
        public string QuienRecomienda { get; set; }
        public Nullable<int> habitacion_id { get; set; }
        public Nullable<System.DateTime> fechaVtoHisopado { get; set; }
        public Nullable<int> sedeSugerida { get; set; }
        public Nullable<bool> camaDada { get; set; }
        public Nullable<bool> confirmaCama { get; set; }
        public string responsable { get; set; }
        public string vinculo { get; set; }
        public string telefonos { get; set; }
        public Nullable<System.DateTime> fechaConfirmacionCama { get; set; }
    
        public virtual MED_Diagnosticos MED_Diagnosticos { get; set; }
        public virtual MotivoEgreso MotivoEgreso { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MED_ListaEsperaModulo> MED_ListaEsperaModulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MED_PuntajeAdicionalListaEspera> MED_PuntajeAdicionalListaEspera { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MED_CultivosListaEspera> MED_CultivosListaEspera { get; set; }
    }
}
