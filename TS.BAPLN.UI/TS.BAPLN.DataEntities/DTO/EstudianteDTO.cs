using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.BAPLN.DataEntities.DTO
{
    public class EstudianteDTO
    {
        [Display(Name="ID")]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage= "El campo Nombre es requerido")]
        public string Nombre { get; set; }

        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "El campo Primer Apellido es requerido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }

        [Display(Name = "Carné")]
        public string Carne { get; set; }

        [Display(Name = "Cédula")]
        public string Cedula { get; set; }

        [Display(Name = "Madre")]
        public string Padre { get; set; }

        [Display(Name = "Padre")]
        public string Madre { get; set; }

        [Display(Name = "Telefono Local")]
        [StringLength(8, ErrorMessage = "El largo máximo para el campo {0} es de {1} ")]
        public string TelefonoLocal { get; set; }

        [Display(Name = "Telefono Movil")]
        [StringLength(8, ErrorMessage="El largo máximo para el campo {0} es de {1} ")]
        public string TelefonoMovil { get; set; }

        [Display(Name = "Fotografía")]
        public string Fotografia { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "El email no tiene el formato correcto")]
        public string Email { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Required(ErrorMessage = "El campo Fecha de Nacimiento es requerido")]
        public Nullable<System.DateTime> Fecha_Nacimiento { get; set; }

        [Display(Name = "Nacionalidad")]
        [Required(ErrorMessage = "El campo Nacionalidad es requerido")]
        public int Id_Nacionalidad { get; set; }

        [Display(Name = "Nacionalidad")]
        public string Nacionalidad { get; set; }

        [Display(Name = "Activo")]
        public bool Activo { get; set; }

        [Display(Name = "Nacionalidad")]
        [Required(ErrorMessage = "El campo Nacionalidad es requerido")]
        public List<NacionalidadDTO> Nacionalidades;

        [Display(Name = "IdInstitucion:")]
        public int IdInstitucion { get; set; }
    }
}
