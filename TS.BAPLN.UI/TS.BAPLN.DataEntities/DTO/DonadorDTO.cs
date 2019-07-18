using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.BAPLN.DataEntities.DTO
{
    public class DonadorDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string Nombre { get; set; }

        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "El campo Primer Apellido es requerido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "El email no tiene el formato correcto")]
        public string Email { get; set; }

        [Display(Name = "Telefono Local")]
        [StringLength(8, ErrorMessage = "El largo máximo para el campo {0} es de {1} ")]
        public string TelefonoLocal { get; set; }

        [Display(Name = "Telefono Movil")]
        [StringLength(8, ErrorMessage = "El largo máximo para el campo {0} es de {1} ")]
        public string TelefonoMovil { get; set; }

        [Display(Name = "Periodicidad")]
        [Required(ErrorMessage = "El campo Periodicidad es requerido")]
        public int Id_Periodicidad { get; set; }

        [Display(Name = "Periodicidad")]
        public string Periodicidad { get; set; }

        [Display(Name = "Monto de Aporte")]
        [Required(ErrorMessage = "El campo Monto de Aporte es requerido")]
        public decimal MontoAporte { get; set; }

        [Display(Name = "Nacionalidad")]
        [Required(ErrorMessage = "El campo Nacionalidad es requerido")]
        public int Id_Nacionalidad { get; set; }

        [Display(Name = "Nacionalidad")]
        public string Nacionalidad { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Required(ErrorMessage = "El campo Fecha de Nacimiento es requerido")]
        public Nullable<System.DateTime> FechaNacimiento { get; set; }

        [Display(Name = "Activo")]
        public bool Activo { get; set; }

        [Display(Name = "Nacionalidad")]
        [Required(ErrorMessage = "El campo Nacionalidad es requerido")]
        public List<NacionalidadDTO> Nacionalidades;

        [Display(Name = "Periodicidad")]
        [Required(ErrorMessage = "El campo Periodicidad es requerido")]
        public List<PeriodicidadDTO> Periodicidades;
    }
}
