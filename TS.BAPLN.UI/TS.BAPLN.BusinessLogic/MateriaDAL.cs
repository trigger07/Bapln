using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataAccess;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.BusinessLogic
{
    public class MateriaDAL
    {
        public List<MateriaDTO> ObtenerCatalogoMaterias()
        {
            var b = new MateriaDAO();
            return b.ObtenerCatalogoMaterias();
        }

        public List<MateriaDTO> ObtenerMaterias(int idInstitucion)
        {
            var b = new MateriaDAO();
            return b.ObtenerMaterias(idInstitucion);
        }

        public MateriaDTO ObtenerMateria(int idMateria, int idInstitucion)
        {
            var b = new MateriaDAO();
            return b.ObtenerMateria(idMateria,idInstitucion);
        }

        public void  ActualizarMateria(MateriaDTO materia)
        {
            var b = new MateriaDAO();
            if (materia.Id > 0)
            {
                b.ActualizarMateria(materia, true);
            }
            else
            {
                b.ActualizarMateria(materia, false);
            }
        }

        public void EditarMateria(MateriaDTO curso)
        {
            var b = new MateriaDAO();
            b.ActualizarMateria(curso, false);
        }

        public void InactivarMateria(int id)
        {
            MateriaDAO materiaDao = new MateriaDAO();
            materiaDao.InactivarMateria(id);
        }

        public void ActivarMateria(int id)
        {
            MateriaDAO materiaDao = new MateriaDAO();
            materiaDao.ActivarMateria(id);
        }

        public int BorrarMateria(int id)
        {
            MateriaDAO materiaDao = new MateriaDAO();
            return materiaDao.BorrarMateria(id);
        }
    }
}
