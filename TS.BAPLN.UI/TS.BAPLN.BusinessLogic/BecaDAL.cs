using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataAccess;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.BusinessLogic
{
    public class BecaDAL
    {
        public List<BecaDTO> ObtenerBecas()
        {
            BecaDAO b = new BecaDAO();
            return b.ObtenerBecas();
        }

        public BecaDTO ObtenerBecaPorId(int id)
        {
            BecaDAO bDao = new BecaDAO();
            return bDao.ObtenerBecaPorId(id);
        }

        public void Inactivar(int id)
        {
            BecaDAO b = new BecaDAO();
            b.Inactivar(id);
        }

        public void Activar(int id)
        {
            BecaDAO b = new BecaDAO();
            b.Activar(id);
        }

        public bool ActualizarBeca(BecaDTO beca)
        {
            BecaDAO b = new BecaDAO();
            return b.ActualizarBeca(beca);
        }

        public void CrearBeca(BecaDTO beca)
        {
            BecaDAO b = new BecaDAO();
            b.CrearBeca(beca);
        }

        public List<BecaDTO> ObtenerBecasActivas()
        {
            BecaDAO b = new BecaDAO();
            return b.ObtenerBecasActivas();
        }
    }
}
