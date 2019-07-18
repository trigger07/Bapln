using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.BAPLN.DataEntities.DTO
{
    public class HistorialAcademicoDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Código Materia:")]
        public int Id_Materia { get; set; }

        [Display(Name = "Código Periodo")]
        public int Id_Periodo { get; set; }

        [Display(Name = "Código Nivel")]
        public int Id_Nivel { get; set; }

        [Display(Name = "Curso Lectivo")]
        public int Id_Curso { get; set; }

        [Display(Name = "Nota")]
        public short Nota { get; set; }

        [Display(Name =  "Estudiante")]
        public int Id_Estudiante { get; set; }

        [Display(Name = "Institucion")]
        public int Id_Institucion { get; set; }
    }
}

