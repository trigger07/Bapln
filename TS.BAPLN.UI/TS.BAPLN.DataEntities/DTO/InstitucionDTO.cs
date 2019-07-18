using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TS.BAPLN.DataEntities.DTO
{
    public class InstitucionDTO
    {
        [Display(Name="ID")]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage= "El campo Nombre es requerido")]
        public string Nombre { get; set; }

        [Display(Name = "Telefono")]
        [StringLength(8, ErrorMessage = "El largo máximo para el campo {0} es de {1} ")]
        public string Telefono { get; set; }

        [Display(Name = "Direccion")]
        [DataType(DataType.MultilineText)]
        public string Direccion { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "El email no tiene el formato correcto")]
        public string EmailContacto { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }

        public List<MateriaDTO> Materias { get; set; }

        public List<PeriodoDTO> Periodos { get; set; }

        public List<NivelDTO> Niveles { get; set; }

    }
}
