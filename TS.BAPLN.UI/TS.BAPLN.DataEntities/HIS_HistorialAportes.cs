//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TS.BAPLN.DataEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class HIS_HistorialAportes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_HistorialAportes()
        {
            this.LIS_AporteCuota = new HashSet<LIS_AporteCuota>();
        }
    
        public int Id { get; set; }
        public int Id_Donador { get; set; }
        public decimal Monto { get; set; }
        public bool Anulada { get; set; }
        public bool Aprobada { get; set; }
        public string UsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual LIS_Donador LIS_Donador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIS_AporteCuota> LIS_AporteCuota { get; set; }
    }
}
