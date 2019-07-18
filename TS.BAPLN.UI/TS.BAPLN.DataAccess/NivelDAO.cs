using System.Collections.Generic;
using System.Linq;
using TS.BAPLN.DataEntities;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.DataModel;

namespace TS.BAPLN.DataAccess
{
    public class NivelDAO
    {
        public List<NivelDTO> ObtenerCatalogoNiveles()
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var lNiveles = entities.CAT_Nivel.OrderBy(v => v.Descripcion).Select(x => new NivelDTO
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Activo = x.Activa
                }).ToList();

                return lNiveles;
            }
        }

        public List<NivelDTO> ObtenerNiveles(int idInstitucion)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var lNiveles = entities.CAT_Nivel.Where(s => s.LIS_Instituciones.Any(c => c.Id == idInstitucion)).OrderBy(v => v.Descripcion).Select(x => new NivelDTO
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    IdInstitucion = x.LIS_Instituciones.FirstOrDefault().Id,
                    Activo = x.Activa
                }).ToList();

                return lNiveles;
            }
        }

        public void ActualizarNivel(NivelDTO nivel, bool editar)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                if (editar)
                {
                    CAT_Nivel existente = entities.CAT_Nivel.FirstOrDefault(v => v.Id == nivel.Id);
                    if (existente != null)
                    {
                        existente.Descripcion = nivel.Descripcion;
                        entities.SaveChanges();
                    }
                }
                else
                {
                    CAT_Nivel nuevo = new CAT_Nivel();
                    nuevo.Descripcion = nivel.Descripcion;
                    nuevo.Activa = true;
                    entities.CAT_Nivel.Add(nuevo);
                    entities.SaveChanges();
                }
            }
        }

        public NivelDTO ObtenerNivel(int idNivel, int idInstitucion)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var lCurso = entities.CAT_Nivel.Where(s => s.Id == idNivel && s.LIS_Instituciones.Any(c => c.Id == idInstitucion))
                    .Select(x => new NivelDTO()
                    {
                        Id = x.Id,
                        Descripcion = x.Descripcion,
                        IdInstitucion = x.LIS_Instituciones.FirstOrDefault().Id
                    }).FirstOrDefault();

                return lCurso;
            }
        }

        public void ActivarNivel(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                CAT_Nivel nivel = entities.CAT_Nivel.Find(id);
                nivel.Activa = true;
                entities.SaveChanges();
            }
        }

        public void InactivarNivel(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                CAT_Nivel nivel = entities.CAT_Nivel.Find(id);
                nivel.Activa = false;
                entities.SaveChanges();
            }
        }

        public int BorrarNivel(int id)
        {
            int resultado = -1;
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                if (entities.HIS_HistorialAcademico.Any(h => h.Id_Nivel == id) || entities.LIS_Instituciones.Any(i => i.CAT_Nivel.Any(m => m.Id == id)))
                {
                    InactivarNivel(id);
                    resultado = 0;
                }
                else
                {
                    CAT_Nivel nivel = entities.CAT_Nivel.Find(id);
                    if (nivel != null)
                    {
                        entities.CAT_Nivel.Remove(nivel);
                        entities.SaveChanges();
                        resultado = 1;
                    }
                }
            }
            return resultado;
        }
    }
}

