using System.Collections.Generic;
using System.Linq;
using TS.BAPLN.DataEntities;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.DataModel;

namespace TS.BAPLN.DataAccess
{
    public class CursoLectivoDAO
    {
        public List<CursoLectivoDTO> ObtenerCatalogoCursosLectivos()
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var lCursosLectivos = entities.CAT_CursoLectivo.OrderBy(v => v.Descripcion).Select(x => new CursoLectivoDTO
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Activo = x.Activa
                }).ToList();

                return lCursosLectivos;
            }
        }

        public List<CursoLectivoDTO> ObtenerCursoLectivos(int idInstitucion)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var lCursos = entities.CAT_CursoLectivo.Where(s => s.LIS_Instituciones.Any(c => c.Id == idInstitucion)).OrderBy(v => v.Descripcion).Select(x => new CursoLectivoDTO
                            {
                                Id = x.Id,
                                Descripcion = x.Descripcion,
                                IdInstitucion = x.LIS_Instituciones.FirstOrDefault().Id,
                                Activo = x.Activa
                            }).ToList();

                return lCursos;
            }
        }

        public void ActualizarCursoLectivo(CursoLectivoDTO curso, bool editar)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                if (editar)
                {
                    CAT_CursoLectivo existente = entities.CAT_CursoLectivo.FirstOrDefault(v => v.Id == curso.Id);
                    if (existente != null)
                    {
                        existente.Descripcion = curso.Descripcion;
                        entities.SaveChanges();
                    }
                }
                else
                {
                    var nuevo = new CAT_CursoLectivo();
                    nuevo.Descripcion = curso.Descripcion;
                    nuevo.Activa = true;
                    entities.CAT_CursoLectivo.Add(nuevo);
                    entities.SaveChanges();
                }
            }
        }

        public CursoLectivoDTO ObtenerCursoLectivo(int idCurso, int idInstitucion)
        {
           using (BAPLNEntities entities = new BAPLNEntities())
            {

                var lCurso = entities.CAT_CursoLectivo.Where(s => s.Id == idCurso && s.LIS_Instituciones.Any(c => c.Id == idInstitucion))
                    .Select(x => new CursoLectivoDTO
                            {
                                Id = x.Id,
                                Descripcion = x.Descripcion,
                                IdInstitucion = x.LIS_Instituciones.FirstOrDefault().Id
                            }).FirstOrDefault();

                return lCurso;
            }
        }

        public void ActivarCursoLectivo(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                CAT_CursoLectivo curso = entities.CAT_CursoLectivo.Find(id);
                curso.Activa = true;
                entities.SaveChanges();
            }
        }

        public void InactivarCursoLectivo(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                CAT_CursoLectivo curso = entities.CAT_CursoLectivo.Find(id);
                curso.Activa = false;
                entities.SaveChanges();
            }
        }

        public int BorrarCursoLectivo(int id)
        {
            int resultado = -1;
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                if (entities.HIS_HistorialAcademico.Any(h => h.Id_CursoLectivo == id) || entities.LIS_Instituciones.Any(i => i.CAT_CursoLectivo.Any(m => m.Id == id)))
                {
                    InactivarCursoLectivo(id);
                    resultado = 0;
                }
                else
                {
                    CAT_CursoLectivo curso = entities.CAT_CursoLectivo.Find(id);
                    if (curso != null)
                    {
                        entities.CAT_CursoLectivo.Remove(curso);
                        entities.SaveChanges();
                        resultado = 1;
                    }
                }
            }
            return resultado;
        }
    }
}