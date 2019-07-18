using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataAccess;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.BusinessLogic
{
    public class NivelDAL
    {
        public List<NivelDTO> ObtenerCatalogoNiveles()
        {
            var b = new NivelDAO();
            return b.ObtenerCatalogoNiveles();
        }

        public List<NivelDTO> ObtenerNiveles(int idInstitucion)
        {
            var b = new NivelDAO();
            return b.ObtenerNiveles(idInstitucion);
        }

        public NivelDTO ObtenerPeriodo(int idNivel, int idInstitucion)
        {
            var b = new NivelDAO();
            return b.ObtenerNivel(idNivel,idInstitucion);
        }

        public void ActualizarNivel(NivelDTO nivel)
        {
            var b = new NivelDAO();
            if (nivel.Id > 0)
            {
                b.ActualizarNivel(nivel, true);
            }
            else
            {
                b.ActualizarNivel(nivel, false);
            }
        }

        public void EditarNivel(NivelDTO curso)
        {
            var b = new NivelDAO();
            b.ActualizarNivel(curso, false);
        }

        public void InactivarNivel(int id)
        {
            NivelDAO nivelDao = new NivelDAO();
            nivelDao.InactivarNivel(id);
        }

        public void ActivarNivel(int id)
        {
            NivelDAO nivelDao = new NivelDAO();
            nivelDao.ActivarNivel(id);
        }

        public int BorrarNivel(int id)
        {
            NivelDAO nivelDao = new NivelDAO();
            return nivelDao.BorrarNivel(id);
        }
    }
}
