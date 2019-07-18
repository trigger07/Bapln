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
    public class EstudianteDAO
    {
        public List<EstudianteDTO> ObtenerEstudiantes()
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var query = from estudiante in entities.LIS_Estudiante
                            join nacionalidad in entities.CAT_Nacionalidad
                            on estudiante.Id_Nacionalidad equals nacionalidad.Id
                            select new EstudianteDTO
                            {
                                Id = estudiante.Id,
                                Nombre = estudiante.Nombre,
                                PrimerApellido = estudiante.PrimerApellido,
                                SegundoApellido = estudiante.SegundoApellido,
                                Carne = estudiante.Carne,
                                Cedula = estudiante.Cedula,
                                Padre = estudiante.Padre,
                                Madre = estudiante.Madre,
                                TelefonoLocal = estudiante.TelefonoLocal,
                                TelefonoMovil = estudiante.TelefonoMovil,
                                Fotografia = estudiante.Fotografia,
                                Direccion = estudiante.Direccion,
                                Email = estudiante.Email,
                                Fecha_Nacimiento = estudiante.Fecha_Nacimiento ?? DateTime.MinValue,
                                Id_Nacionalidad = estudiante.Id_Nacionalidad,
                                Nacionalidad = nacionalidad.Descripcion,
                                Activo = estudiante.Activo
                            };
                return query.ToList<EstudianteDTO>();
            }
        }

        public List<EstudianteDTO> ObtenerEstudiantesAutocomplete(string filter)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var query = from estudiante in entities.LIS_Estudiante
                            where estudiante.Activo == true && (estudiante.Nombre.Contains(filter) || estudiante.PrimerApellido.Contains(filter) ||
                            estudiante.SegundoApellido.Contains(filter))
                            select new EstudianteDTO
                            {
                                Id = estudiante.Id,
                                Nombre = estudiante.Nombre,
                                PrimerApellido = estudiante.PrimerApellido,
                                SegundoApellido = estudiante.SegundoApellido,
                                Carne = estudiante.Carne,
                                Cedula = estudiante.Cedula 
                            };
                return query.ToList<EstudianteDTO>();
            }
        }

        public EstudianteDTO ObtenerEsudiante(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var query = from estudiante in entities.LIS_Estudiante
                            join nacionalidad in entities.CAT_Nacionalidad
                            on estudiante.Id_Nacionalidad equals nacionalidad.Id
                            where estudiante.Id == id
                            select new EstudianteDTO
                            {
                                Id = estudiante.Id,
                                Nombre = estudiante.Nombre,
                                PrimerApellido = estudiante.PrimerApellido,
                                SegundoApellido = estudiante.SegundoApellido,
                                Carne = estudiante.Carne,
                                Cedula = estudiante.Cedula,
                                Padre = estudiante.Padre,
                                Madre = estudiante.Madre,
                                TelefonoLocal = estudiante.TelefonoLocal,
                                TelefonoMovil = estudiante.TelefonoMovil,
                                Fotografia = estudiante.Fotografia,
                                Direccion = estudiante.Direccion,
                                Email = estudiante.Email,
                                Fecha_Nacimiento = estudiante.Fecha_Nacimiento ?? DateTime.MinValue,
                                Id_Nacionalidad = estudiante.Id_Nacionalidad,
                                Nacionalidad = nacionalidad.Descripcion,
                                Activo = estudiante.Activo
                            };
                return query.First();
            }
        }

        public void CrearEstudiante(EstudianteDTO estudiante)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                LIS_Estudiante lisEstudiante = new LIS_Estudiante
                {
                    Nombre = estudiante.Nombre,
                    PrimerApellido = estudiante.PrimerApellido,
                    SegundoApellido = estudiante.SegundoApellido,
                    Carne = estudiante.Carne,
                    Cedula = estudiante.Cedula,
                    Padre = estudiante.Padre,
                    Madre = estudiante.Madre,
                    TelefonoLocal = estudiante.TelefonoLocal,
                    TelefonoMovil = estudiante.TelefonoMovil,
                    Fotografia = estudiante.Fotografia,
                    Direccion = estudiante.Direccion,
                    Email = estudiante.Email,
                    Fecha_Nacimiento = estudiante.Fecha_Nacimiento,
                    Id_Nacionalidad = estudiante.Id_Nacionalidad,
                    Activo = true
                };

                entities.LIS_Estudiante.Add(lisEstudiante);
                entities.SaveChanges();
            }
        }

        public void InactivarEstudiante(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                LIS_Estudiante estudiante = entities.LIS_Estudiante.Find(id);
                estudiante.Activo = false;

                entities.SaveChanges();
            }
        }

        public void ActivarEstudiante(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                LIS_Estudiante estudiante = entities.LIS_Estudiante.Find(id);
                estudiante.Activo = true;

                entities.SaveChanges();
            }
        }

        public bool ActualizarEstudiante(EstudianteDTO estudiante)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                LIS_Estudiante lisEstudiante = entities.LIS_Estudiante.Find(estudiante.Id);
                lisEstudiante.Nombre = estudiante.Nombre;
                lisEstudiante.PrimerApellido = estudiante.PrimerApellido;
                lisEstudiante.SegundoApellido = estudiante.SegundoApellido;
                lisEstudiante.Carne = estudiante.Carne;
                lisEstudiante.Cedula = estudiante.Cedula;
                lisEstudiante.Padre = estudiante.Padre;
                lisEstudiante.Madre = estudiante.Madre;
                lisEstudiante.TelefonoLocal = estudiante.TelefonoLocal;
                lisEstudiante.TelefonoMovil = estudiante.TelefonoMovil;
                lisEstudiante.Fotografia = estudiante.Fotografia;
                lisEstudiante.Direccion = estudiante.Direccion;
                lisEstudiante.Email = estudiante.Email;
                lisEstudiante.Fecha_Nacimiento = estudiante.Fecha_Nacimiento;
                lisEstudiante.Id_Nacionalidad = estudiante.Id_Nacionalidad;
                lisEstudiante.Activo = estudiante.Activo;
                entities.SaveChanges();
            }
            return true;
        }
    }
}
