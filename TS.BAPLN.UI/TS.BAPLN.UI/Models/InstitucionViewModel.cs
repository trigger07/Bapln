using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.UI.Models
{
    public class InstitucionViewModel
    {
        public InstitucionDTO Institucion { get; set; }

        public List<MateriaDTO> Materias { get; set; }

        public List<PeriodoDTO> Periodos { get; set; }

        public List<NivelDTO> Niveles { get; set; }

        public string MateriasSeleccionadas { get; set; }

        public string NivelesSeleccionados { get; set; }

        public string PeriodosSeleccionados { get; set; }
    }
}