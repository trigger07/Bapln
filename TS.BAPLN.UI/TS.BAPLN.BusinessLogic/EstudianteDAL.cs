using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataAccess;
using TS.BAPLN.DataEntities.DTO;

namespace TS.BAPLN.BusinessLogic
{
    public class EstudianteDAL
    {
        public List<EstudianteDTO> ObtenerEstudiantes()
        { 
            EstudianteDAO estudianteDao = new EstudianteDAO();
            return estudianteDao.ObtenerEstudiantes();
        }

        public List<EstudianteDTO> ObtenerEstudiantesAutocomplete(string filtro)
        {
            EstudianteDAO e = new EstudianteDAO();
            return e.ObtenerEstudiantesAutocomplete(filtro);
        }

        public EstudianteDTO ObtenerEsudiante(int id)
        {
            EstudianteDAO estudianteDao = new EstudianteDAO();
            return estudianteDao.ObtenerEsudiante(id);
        }

        public void CrearEstudiante(EstudianteDTO estudiante)
        {
            EstudianteDAO estudianteDao = new EstudianteDAO();
            estudianteDao.CrearEstudiante(estudiante);
        }

        public void InactivarEstudiante(int id)
        {
            EstudianteDAO estudianteDao = new EstudianteDAO();
            estudianteDao.InactivarEstudiante(id);
        }

        public void ActivarEstudiante(int id)
        {
            EstudianteDAO estudianteDao = new EstudianteDAO();
            estudianteDao.ActivarEstudiante(id);
        }

        public bool ActualizarEstudiante(EstudianteDTO estudiante)
        {
            EstudianteDAO estudianteDao = new EstudianteDAO();
            return estudianteDao.ActualizarEstudiante(estudiante);
        }
    }
}
