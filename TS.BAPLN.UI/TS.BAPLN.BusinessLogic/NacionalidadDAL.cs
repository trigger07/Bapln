using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataAccess;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.BusinessLogic
{
    public class NacionalidadDAL
    {
        public List<NacionalidadDTO> ObtenerNacionalidades()
        {
            NacionalidadDAO nacionalidadDao = new NacionalidadDAO();
            return nacionalidadDao.ObtenerNacionalidades();
        }
    }
}
