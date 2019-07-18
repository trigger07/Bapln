using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataAccess;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.BusinessLogic
{
    public class HistorialAcademicoDAL
    {
        public List<vwHistorialAcademicoDTO> ObtenerHistorialAcademico(int idEstudiante, int idInstitucion)
        {
            var b = new HistorialAcademicoDAO();
            return b.ObtenerHistorialAcademico(idEstudiante,idInstitucion);
        }

        public void BorrarHistorialAcademico(HistorialAcademicoDTO registro)
        {
            var b = new HistorialAcademicoDAO();
            b.BorrarHistorialAcademico(registro);
        }
        
        public void  CrearHistorialAcademico(HistorialAcademicoDTO registro)
        {
            var b = new HistorialAcademicoDAO();
             b.CrearHistorialAcademico(registro,true);
        }

        public void EditarCursoLectivo(HistorialAcademicoDTO registro)
        {
             var b = new HistorialAcademicoDAO();
            b.CrearHistorialAcademico(registro, false);
        }
    }
}
