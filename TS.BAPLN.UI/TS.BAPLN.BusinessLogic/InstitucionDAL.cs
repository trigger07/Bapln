using System.Collections.Generic;
using TS.BAPLN.DataAccess;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.BusinessLogic
{
    public class InstitucionDAL
    {
        public List<InstitucionDTO> ObtenerInstituciones()
        {
            InstitucionDAO institucionDao = new InstitucionDAO();
            return institucionDao.ObtenerInstituciones();
        }

        public InstitucionDTO ObtenerInstitucion(int id)
        {
            InstitucionDAO institucionDao = new InstitucionDAO();
            return institucionDao.ObtenerInstitucion(id);
        }

        public bool ActualizarInstitucion(InstitucionDTO institucion, int[] materiasIds, int[] periodosIds, int[] nivelesIds)
        {
            InstitucionDAO institucionDao = new InstitucionDAO();
            if (institucion.Id > 0)
            {
                return institucionDao.ActualizarInstitucion(institucion, materiasIds, periodosIds, nivelesIds, true);
            }
            else
            {
                return institucionDao.ActualizarInstitucion(institucion, materiasIds, periodosIds, nivelesIds, false);
            }
        }
    }
}
