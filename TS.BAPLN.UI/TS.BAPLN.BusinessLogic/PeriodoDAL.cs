using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataAccess;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.BusinessLogic
{
    public class PeriodoDAL
    {
        public List<PeriodoDTO> ObtenerCatalogoPeriodos()
        {
            var b = new PeriodoDAO();
            return b.ObtenerCatalogoPeriodos();
        }

        public List<PeriodoDTO> ObtenerPeriodos(int idInstitucion)
        {
            var b = new PeriodoDAO();
            return b.ObtenerPeriodos(idInstitucion);
        }

        public PeriodoDTO ObtenerPeriodo(int idPeriodo, int idInstitucion)
        {
            var b = new PeriodoDAO();
            return b.ObtenerPeriodo(idPeriodo,idInstitucion);
        }

        public void ActualizarPeriodo(PeriodoDTO periodo)
        {
            var b = new PeriodoDAO();
            if (periodo.Id > 0)
            {
                b.ActualizarPeriodo(periodo, true);
            }
            else
            {
                b.ActualizarPeriodo(periodo, false);
            }
        }

        public void EditarPeriodo(PeriodoDTO curso)
        {
            var b = new PeriodoDAO();
            b.ActualizarPeriodo(curso, false);
        }

        public void InactivarPeriodo(int id)
        {
            PeriodoDAO nivelDao = new PeriodoDAO();
            nivelDao.InactivarPeriodo(id);
        }

        public void ActivarPeriodo(int id)
        {
            PeriodoDAO nivelDao = new PeriodoDAO();
            nivelDao.ActivarPeriodo(id);
        }

        public int BorrarPeriodo(int id)
        {
            PeriodoDAO periodoDao = new PeriodoDAO();
            return periodoDao.BorrarPeriodo(id);
        }
    }
}
