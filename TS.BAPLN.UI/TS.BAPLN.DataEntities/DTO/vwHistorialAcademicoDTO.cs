using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.BAPLN.DataEntities.DTO
{
    public class vwHistorialAcademicoDTO
    {
        
            [Display(Name = "ID")]
            public int Id { get; set; }

            [Display(Name = "Carne:")]
            public string Carne { get; set; }

            [Display(Name = "Id Estudiante")]
            public int Id_Estudiante { get; set; }

            [Display(Name = "Nombre Estudiante")]
            public string Nombre_Estudiante { get; set; }

            [Display(Name = "Id Institucion")]
            public int Id_Institucion { get; set; }

            [Display(Name = "Institucion")]
            public string DesInstitucion { get; set; }

            [Display(Name = "Id Curso Lectivo")]
            public int Id_CursoLectivo { get; set; }

            [Display(Name = "Curso Lectivo")]
            public string DesCursoLectivo { get; set; }

            [Display(Name = "Id Nivel")]
            public int Id_Nivel { get; set; }

            [Display(Name = "Nivel")]
            public string DesNivel { get; set; }


            [Display(Name = "Id Periodo")]
            public int Id_Periodo { get; set; }

            [Display(Name = "Periodo")]
            public string DesPeriodo { get; set; }

            [Display(Name = "Id Materia")]
            public int Id_Materia { get; set; }

            [Display(Name = "Materia")]
            public string Des_Materia { get; set; }

            [Display(Name = "Calificacion")]
            public int Calificacion { get; set; }


        }
}
