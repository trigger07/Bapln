using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataEntities;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.DataModel;

namespace TS.BAPLN.DataAccess
{
    public class PeriodoDAO
    {
        public List<PeriodoDTO> ObtenerCatalogoPeriodos()
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var lPeriodos = entities.CAT_Periodo.OrderBy(v => v.Descripcion).Select(x => new PeriodoDTO
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Activo = x.Activa
                }).ToList();

                return lPeriodos;
            }
        }

        public List<PeriodoDTO> ObtenerPeriodos(int idInstitucion)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {

                var lPeriodos = entities.CAT_Periodo.Where(s => s.LIS_Instituciones.Any(c => c.Id == idInstitucion)).OrderBy(v => v.Descripcion).Select(x => new PeriodoDTO
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    IdInstitucion = x.LIS_Instituciones.FirstOrDefault().Id,
                    Activo = x.Activa
                }).ToList();

                return lPeriodos;
            }
        }

        public void ActualizarPeriodo(PeriodoDTO periodo, bool editar)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                if (editar)
                {
                    CAT_Periodo existente = entities.CAT_Periodo.FirstOrDefault(v => v.Id == periodo.Id);
                    if (existente != null)
                    {
                        existente.Descripcion = periodo.Descripcion;
                        entities.SaveChanges();
                    }
                }
                else
                {                    
                    CAT_Periodo nuevo = new CAT_Periodo();
                    nuevo.Descripcion = periodo.Descripcion;
                    nuevo.Activa = true;
                    entities.CAT_Periodo.Add(nuevo);
                    entities.SaveChanges();
                }
            }
        }

        public PeriodoDTO ObtenerPeriodo(int idPeriodo, int idInstitucion)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {

                var lCurso = entities.CAT_Periodo.Where(s => s.Id == idPeriodo && s.LIS_Instituciones.Any(c => c.Id == idInstitucion))
                    .Select(x => new PeriodoDTO()
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        IdInstitucion = x.LIS_Instituciones.FirstOrDefault().Id
                    }).FirstOrDefault();

                return lCurso;
            }
        }

        public void ActivarPeriodo(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                CAT_Periodo periodo = entities.CAT_Periodo.Find(id);
                periodo.Activa = true;
                entities.SaveChanges();
            }
        }

        public void InactivarPeriodo(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                CAT_Periodo periodo = entities.CAT_Periodo.Find(id);
                periodo.Activa = false;
                entities.SaveChanges();
            }
        }

        public int BorrarPeriodo(int id)
        {
            int resultado = -1;
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                if (entities.HIS_HistorialAcademico.Any(h => h.Id_Periodo == id) || entities.LIS_Instituciones.Any(i => i.CAT_Periodo.Any(m => m.Id == id)))
                {
                    InactivarPeriodo(id);
                    resultado = 0;
                }
                else
                {
                    CAT_Periodo periodo = entities.CAT_Periodo.Find(id);
                    if (periodo != null)
                    {
                        entities.CAT_Periodo.Remove(periodo);
                        entities.SaveChanges();
                        resultado = 1;
                    }
                }
            }

            return resultado;
        }
    }
}
