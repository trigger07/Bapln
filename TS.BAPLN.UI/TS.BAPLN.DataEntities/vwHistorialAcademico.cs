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
    
    public partial class vwHistorialAcademico
    {
        public int Consecutivo { get; set; }
        public string CarnetEstudiante { get; set; }
        public int IdEstudiante { get; set; }
        public string NombreEstudiante { get; set; }
        public int idInstitucion { get; set; }
        public string DesInstitucion { get; set; }
        public int IdCursoLectivo { get; set; }
        public string CursoLectivo { get; set; }
        public int IdNivel { get; set; }
        public string DesNivel { get; set; }
        public int IdPeriodo { get; set; }
        public string DesPeriodo { get; set; }
        public int Materia { get; set; }
        public string DesMateria { get; set; }
        public short Calificacion { get; set; }
    }
}