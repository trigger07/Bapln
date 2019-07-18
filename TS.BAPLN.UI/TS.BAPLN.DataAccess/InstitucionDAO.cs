using System.Collections.Generic;
using System.Linq;
using TS.BAPLN.DataEntities;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.DataModel;

namespace TS.BAPLN.DataAccess
{
    public class InstitucionDAO
    {
        public List<InstitucionDTO> ObtenerInstituciones()
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var query = from institucion in entities.LIS_Instituciones                            
                            select new InstitucionDTO
                            {
                                Id = institucion.Id,
                                Nombre = institucion.Nombre,
                                Telefono = institucion.Telefono,
                                Direccion = institucion.Direccion,
                                EmailContacto = institucion.EmailContacto,
                                Website = institucion.WebSite
                            };
                return query.ToList<InstitucionDTO>();
            }
        }

        public InstitucionDTO ObtenerInstitucion(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var query = from institucion in entities.LIS_Instituciones
                            where institucion.Id == id
                            select new InstitucionDTO
                            {
                                Id = institucion.Id,
                                Nombre = institucion.Nombre,
                                Telefono = institucion.Telefono,
                                Direccion = institucion.Direccion,
                                EmailContacto = institucion.EmailContacto,
                                Website = institucion.WebSite
                            };
                return query.First();
            }
        }

        public bool ActualizarInstitucion(InstitucionDTO institucion, int[] materiasIds, int[] periodosIds, int[] nivelesIds, bool editar) 
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                LIS_Instituciones actual = null;
                if (editar){
                    actual = entities.LIS_Instituciones.FirstOrDefault(i => i.Id == institucion.Id);
                    if (actual != null)
                    {
                        actual.Nombre = institucion.Nombre;
                        actual.Telefono = institucion.Telefono;
                        actual.Direccion = institucion.Direccion;
                        actual.EmailContacto = institucion.EmailContacto;
                        actual.WebSite = institucion.Website;
                        actual.CAT_Materia.Clear();
                        actual.CAT_Periodo.Clear();
                        actual.CAT_Nivel.Clear();
                    }
                }
                else{
                    actual = new LIS_Instituciones();
                    actual.Nombre = institucion.Nombre;
                    actual.Telefono = institucion.Telefono;
                    actual.Direccion = institucion.Direccion;
                    actual.EmailContacto = institucion.EmailContacto;
                    actual.WebSite = institucion.Website;

                    entities.LIS_Instituciones.Add(actual); 
                }
                //Dependencia Materia
                actual.CAT_Materia = new List<CAT_Materia>();
                foreach (int id in materiasIds)
                {
                    actual.CAT_Materia.Add(entities.CAT_Materia.FirstOrDefault(m => m.Id == id));
                }

                //Dependencia Periodo
                actual.CAT_Periodo = new List<CAT_Periodo>();
                foreach (int id in periodosIds)
                {
                    actual.CAT_Periodo.Add(entities.CAT_Periodo.FirstOrDefault(p => p.Id == id));
                }

                //Dependencia Nivel                    
                actual.CAT_Nivel = new List<CAT_Nivel>();
                foreach (int id in nivelesIds)
                {
                    actual.CAT_Nivel.Add(entities.CAT_Nivel.FirstOrDefault(n => n.Id == id));
                }
                               
                entities.SaveChanges();
            }
            return true;
        }
    }
}
