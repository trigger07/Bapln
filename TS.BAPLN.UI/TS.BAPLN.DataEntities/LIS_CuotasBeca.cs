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
    
    public partial class LIS_CuotasBeca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIS_CuotasBeca()
        {
            this.LIS_AporteCuota = new HashSet<LIS_AporteCuota>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Id_BecaEstudiante { get; set; }
        public Nullable<int> Id_Donador { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public bool Pendiente { get; set; }
        public bool Activa { get; set; }
        public bool Anulada { get; set; }
        public string Usuario { get; set; }
        public string Fecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIS_AporteCuota> LIS_AporteCuota { get; set; }
        public virtual LIS_BecaEstudiante LIS_BecaEstudiante { get; set; }
        public virtual LIS_Donador LIS_Donador { get; set; }
    }
}
