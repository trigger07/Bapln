using System.Collections.Generic;
using System.Linq;
using TS.BAPLN.DataEntities;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.DataModel;

namespace TS.BAPLN.DataAccess
{
    public class MateriaDAO
    {
        public List<MateriaDTO> ObtenerCatalogoMaterias()
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var lMaterias = entities.CAT_Materia.OrderBy(v => v.Descripcion).Select(x => new MateriaDTO
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Activo = x.Activa
                }).ToList();

                return lMaterias;
            }
        }

        public List<MateriaDTO> ObtenerMaterias(int idInstitucion)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var lMaterias = entities.CAT_Materia.Where(s => s.LIS_Instituciones.Any(c => c.Id == idInstitucion)).OrderBy(v => v.Descripcion).Select(x => new MateriaDTO
                            {
                                Id = x.Id,
                                Descripcion = x.Descripcion,
                                IdInstitucion = x.LIS_Instituciones.FirstOrDefault().Id,
                                Activo = x.Activa
                            }).ToList();

                return lMaterias;
            }
        }

        public void ActualizarMateria(MateriaDTO materia, bool editar)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                if (editar)
                {
                    CAT_Materia existente = entities.CAT_Materia.FirstOrDefault(v => v.Id == materia.Id);
                    if (existente != null)
                    {
                        existente.Descripcion = materia.Descripcion;
                        entities.SaveChanges();
                    }
                }
                else
                {
                    CAT_Materia nueva = new CAT_Materia();
                    nueva.Descripcion = materia.Descripcion;
                    nueva.Activa = true;
                    entities.CAT_Materia.Add(nueva);
                    entities.SaveChanges();
                }
            }
        }

        public MateriaDTO ObtenerMateria(int idMateria, int idInstitucion)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {

                var lCurso = entities.CAT_Materia.Where(s => s.Id == idMateria && s.LIS_Instituciones.Any(c => c.Id == idInstitucion))
                    .Select(x => new MateriaDTO
                            {
                                Id = x.Id,
                                Descripcion = x.Descripcion,
                                IdInstitucion = x.LIS_Instituciones.FirstOrDefault().Id
                            }).FirstOrDefault();

                return lCurso;
            }
        }

        public void ActivarMateria(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                CAT_Materia materia = entities.CAT_Materia.Find(id);
                materia.Activa = true;
                entities.SaveChanges();
            }
        }

        public void InactivarMateria(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                CAT_Materia materia = entities.CAT_Materia.Find(id);
                materia.Activa = false;
                entities.SaveChanges();
            }
        }

        public int BorrarMateria(int id)
        {
            int resultado = -1;
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                if (entities.HIS_HistorialAcademico.Any(h => h.Id_Materia == id) || entities.LIS_Instituciones.Any(i => i.CAT_Materia.Any(m => m.Id == id)))
                {
                    InactivarMateria(id);
                    resultado = 0;
                }
                else {
                    CAT_Materia materia = entities.CAT_Materia.Find(id);
                    if (materia != null)
                    {
                        entities.CAT_Materia.Remove(materia);
                        entities.SaveChanges();
                        resultado = 1;
                    }
                }
            }
            return resultado;
        }
    }
}

