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
    
    public partial class PertenenciasPaciente
    {
        public int id { get; set; }
        public Nullable<int> paciente_id { get; set; }
        public string NombrePaciente { get; set; }
        public Nullable<System.DateTime> fecha_alta { get; set; }
        public Nullable<int> motivoAlta_id { get; set; }
        public string supervisorEnf { get; set; }
        public string gobernante { get; set; }
        public Nullable<int> cantBolsas { get; set; }
        public string obsSede { get; set; }
        public Nullable<System.DateTime> fechaDeposito { get; set; }
        public Nullable<System.DateTime> fechaLegales { get; set; }
        public Nullable<System.DateTime> fechaRetiro { get; set; }
        public Nullable<int> respRetiro { get; set; }
        public string obsRetiro { get; set; }
        public Nullable<int> cantLlamados { get; set; }
        public Nullable<System.DateTime> fechaLimite { get; set; }
        public Nullable<int> estado_id { get; set; }
        public string mailsAlertas { get; set; }
        public string Sede { get; set; }
    }
}
