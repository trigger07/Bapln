using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.DataModel;

namespace TS.BAPLN.DataAccess
{
    public class TipoBecaDAO
    {
        public List<TipoBecaDTO> ObtenerTipoBecas()
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var query = from tipoBeca in entities.CAT_TipoBeca
                            select new TipoBecaDTO
                            {
                                Id = tipoBeca.Id,
                                Descripcion = tipoBeca.Descripcion
                            };
                return query.ToList();
            }
        }
    }
}
