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
    
    public partial class PRO_Historial_Colocacion_Via_Periferica
    {
        public int colocacionViaPeriferica_id { get; set; }
        public Nullable<int> paciente_id { get; set; }
        public Nullable<int> procedimiento_id { get; set; }
        public string abocathNumero_id { get; set; }
        public Nullable<bool> parcheTegaderm { get; set; }
        public Nullable<bool> infusion { get; set; }
        public Nullable<bool> via { get; set; }
        public string observacion { get; set; }
        public Nullable<int> usuario_id { get; set; }
        public Nullable<System.DateTime> fechaAltaSistema { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public string motivoBaja { get; set; }
    }
}
