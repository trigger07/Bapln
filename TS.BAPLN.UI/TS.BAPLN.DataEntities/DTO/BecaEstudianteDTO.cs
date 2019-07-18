using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.BAPLN.DataEntities.DTO
{
    public class BecaEstudianteDTO
    {
        [Display(Name = "ID:")]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Fecha Inicial:")]
        [Required(ErrorMessage = "El campo Fecha Inicial es requerido")]
        public Nullable<System.DateTime> FechaInicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Fecha Final:")]
        [Required(ErrorMessage = "El campo Fecha Final es requerido")]
        public Nullable<System.DateTime> FechaFinal { get; set; }

        [Display(Name = "Estudiante:")]
        [Required(ErrorMessage = "El campo Estudiante es requerido")]
        public int Id_Estudiante { get; set; }

        [Display(Name = "Estudiante:")]
        [Required(ErrorMessage = "El campo Estudiante es requerido")]
        public string Estudiante { get; set; }

        [Display(Name = "Estudiante:")]
        public List<EstudianteDTO> estudianteList;

        [Display(Name = "Beca:")]
        public int Id_Beca { get; set; }

        [Display(Name = "Tipo de Beca:")]
        public string Beca { get; set; }

        [Display(Name = "Tipo de Beca:")]
        [Required(ErrorMessage = "El campo Tipo de Beca es requerido")]
        public List<BecaDTO> Becas;

        [Display(Name = "Estado:")]
        public bool Activa { get; set; }

        [Display(Name = "Monto Total:")]
        public Nullable<decimal> MontoTotal { get; set; }

        [Display(Name = "Monto Cuota:")]
        public Nullable<decimal> MontoCuota { get; set; }

        [Display(Name = "Cantidad Cuotas:")]
        public Nullable<short> CantidadCuotas { get; set; }
    }
}
