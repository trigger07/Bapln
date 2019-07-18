using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.BAPLN.DataEntities.DTO
{
    public class InstitucionFullDTO
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
