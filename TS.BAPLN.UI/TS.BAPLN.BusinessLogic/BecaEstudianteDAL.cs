using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataAccess;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.BusinessLogic
{
    public class BecaEstudianteDAL
    {
        public void CrearBecaEstudiante(BecaEstudianteDTO beDto)
        {
            BecaEstudianteDAO be = new BecaEstudianteDAO();
            be.CrearBecaEstudiante(beDto);
        }
    }
}
