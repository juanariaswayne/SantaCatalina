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
    
    public partial class FARM_DIARIO
    {
        public int id_cierre { get; set; }
        public Nullable<int> suministro_id { get; set; }
        public Nullable<int> paciente_id { get; set; }
        public Nullable<int> cantidad_aplicaciones { get; set; }
        public Nullable<int> motivo { get; set; }
        public Nullable<bool> cerrado { get; set; }
        public Nullable<int> usuario_carga { get; set; }
        public Nullable<System.DateTime> fecha_carga { get; set; }
        public Nullable<int> usuario_cierre { get; set; }
        public Nullable<System.DateTime> fecha_cierre { get; set; }
        public string producto_id { get; set; }
        public string Turno { get; set; }
        public string observacion { get; set; }
        public string tipo { get; set; }
        public Nullable<bool> urgencia { get; set; }
        public Nullable<int> medico_urgencia { get; set; }
    }
}