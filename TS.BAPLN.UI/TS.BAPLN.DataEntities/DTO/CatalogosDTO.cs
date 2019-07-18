using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.BAPLN.DataEntities.DTO
{
    public class CatalogosDTO
    {
        [Display(Name = "Materias")]
        public List<MateriaDTO> Materias {get; set;}

        [Display(Name = "Periodos")]
        public List<PeriodoDTO> Periodos { get; set; }

        [Display(Name = "Niveles")]
        public List<NivelDTO> Niveles { get; set; }

        [Display(Name = "CursosLectivos")]
        public List<CursoLectivoDTO> CursosLectivos { get; set; }
    }
}
