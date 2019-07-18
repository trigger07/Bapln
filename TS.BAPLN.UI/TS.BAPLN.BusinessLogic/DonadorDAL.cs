using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataAccess;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.BusinessLogic
{
    public class DonadorDAL
    {
        public List<DonadorDTO> ObtenerDonadores()
        {
            DonadorDAO donadorDao = new DonadorDAO();
            return donadorDao.ObtenerDonadores();
        }

        public DonadorDTO ObtenerDonador(int id)
        {
            DonadorDAO donadorDao = new DonadorDAO();
            return donadorDao.ObtenerDonador(id);
        }

        public void CrearDonador(DonadorDTO donador)
        {
            DonadorDAO donadorDao = new DonadorDAO();
            donadorDao.CrearDonador(donador);
        }

        public void InactivarDonador(int id)
        {
            DonadorDAO donadorDao = new DonadorDAO();
            donadorDao.InactivarDonador(id);
        }

        public void ActivarDonador(int id)
        {
            DonadorDAO donadorDao = new DonadorDAO();
            donadorDao.ActivarDonador(id);
        }

        public bool ActualizarDonador(DonadorDTO donador)
        {
            DonadorDAO donadorDao = new DonadorDAO();
            return donadorDao.ActualizarDonador(donador);
        }
    }
}
