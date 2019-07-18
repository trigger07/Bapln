using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataAccess;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.BusinessLogic
{
    public class CursoLectivoDAL
    {
        public List<CursoLectivoDTO> ObtenerCatalogoCursosLectivos()
        {
            var b = new CursoLectivoDAO();
            return b.ObtenerCatalogoCursosLectivos();
        }

        public List<CursoLectivoDTO> ObtenerCursoLectivos(int idInstitucion)
        {
            var b = new CursoLectivoDAO();
            return b.ObtenerCursoLectivos(idInstitucion);
        }

        public CursoLectivoDTO ObtenerCursoLectivo(int idCurso, int idInstitucion)
        {
            var b = new CursoLectivoDAO();
            return b.ObtenerCursoLectivo(idCurso, idInstitucion);
        }
        public void  ActualizarCursoLectivo(CursoLectivoDTO curso)
        {
            var b = new CursoLectivoDAO();
            if (curso.Id > 0)
            {
                b.ActualizarCursoLectivo(curso, true);
            }
            else
            {
                b.ActualizarCursoLectivo(curso, false);
            }
        }

        public void EditarCursoLectivo(CursoLectivoDTO curso)
        {
            var b = new CursoLectivoDAO();
            b.ActualizarCursoLectivo(curso, false);
        }

        public void InactivarCursoLectivo(int id)
        {
            CursoLectivoDAO cursoLectivoDao = new CursoLectivoDAO();
            cursoLectivoDao.InactivarCursoLectivo(id);
        }

        public void ActivarCursoLectivo(int id)
        {
            CursoLectivoDAO cursoLectivoDao = new CursoLectivoDAO();
            cursoLectivoDao.ActivarCursoLectivo(id);
        }

        public int BorrarCursoLectivo(int id)
        {
            CursoLectivoDAO cursoLectivoDao = new CursoLectivoDAO();
            return cursoLectivoDao.BorrarCursoLectivo(id);
        }
    }
}
