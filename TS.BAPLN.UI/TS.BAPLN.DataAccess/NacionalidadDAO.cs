using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.DataModel;

namespace TS.BAPLN.DataAccess
{
    public class NacionalidadDAO
    {
        public List<NacionalidadDTO> ObtenerNacionalidades()
        {
            using(BAPLNEntities entities = new BAPLNEntities())
            {
                var query = from nacionalidad in entities.CAT_Nacionalidad
                            orderby nacionalidad.Descripcion ascending
                            select new NacionalidadDTO 
                            {
                                Id = nacionalidad.Id,
                                Descripcion = nacionalidad.Descripcion
                            };
                return query.ToList();
            }
        }
    }
}
