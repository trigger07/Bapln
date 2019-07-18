using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.DataModel;

namespace TS.BAPLN.DataAccess
{
    public class PeriodicidadDAO
    {
        public List<PeriodoDTO> ObtenerCatalogoPeriodos()
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var lPeriodos = entities.CAT_Periodo.OrderBy(v => v.Descripcion).Select(x => new PeriodoDTO
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion
                }).ToList();

                return lPeriodos;
            }
        }

        public List<PeriodicidadDTO> ObtenerPeriodicidades()
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var query = from periodicidad in entities.CAT_PeriodicidadPago
                            select new PeriodicidadDTO
                            {
                                Id = periodicidad.Id,
                                Descripcion = periodicidad.Descripcion
                            };
                return query.ToList();
            }
        }
    }
}
