using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.UI.ServiceReference;

namespace TS.BAPLN.UI.Controllers
{
    public class EstudianteController : Controller
    {
        public ActionResult Estudiantes()
        {
            ServiceClient cliente = new ServiceClient();
            List<EstudianteDTO> estudiantes = cliente.ObtenerEsudiantes().ToList();
            return View(estudiantes);
        }

        public ActionResult Detalle(int id)
        {
            ServiceClient client = new ServiceClient();
            EstudianteDTO estudiante = client.ObtenerEsudiante(id);

            return PartialView(estudiante);
        }

        public ActionResult Crear()
        {
            ServiceClient cliente = new ServiceClient();
            EstudianteDTO estudiante = new EstudianteDTO();
            estudiante.Nacionalidades = cliente.ObtenerNacionalidades().ToList();
            return View(estudiante);
        }

        [HttpPost]
        public ActionResult Crear(EstudianteDTO estudiante)
        {
            ServiceClient cliente = new ServiceClient();

            if (!ModelState.IsValid)
            {
                estudiante.Nacionalidades = cliente.ObtenerNacionalidades().ToList();
                return View(estudiante);
            }
            
            cliente.CrearEstudiante(estudiante);
            return RedirectToAction("Estudiantes");
        }

        public ActionResult Editar(int id)
        {
            ServiceClient cliente = new ServiceClient();
            EstudianteDTO estudiante = cliente.ObtenerEsudiante(id);
            estudiante.Nacionalidades = cliente.ObtenerNacionalidades().ToList();
            return View(estudiante);
        }

        [HttpPost]
        public ActionResult Editar(int id, EstudianteDTO estudiante)
        {
            ServiceClient cliente = new ServiceClient();
            
            if (!ModelState.IsValid)
            {
                estudiante.Nacionalidades = cliente.ObtenerNacionalidades().ToList();
                return View(estudiante);
            }
            
            estudiante.Id = id;
            cliente.ActualizarEstudiante(estudiante);
            return RedirectToAction("Estudiantes");
        }
        
        public ActionResult Inactivar(int id)
        {
            ServiceClient cliente = new ServiceClient();
            cliente.InactivarEstudiante(id);
            return RedirectToAction("Estudiantes");
        }
        
        public ActionResult Activar(int id)
        {
            ServiceClient cliente = new ServiceClient();
            cliente.ActivarEstudiante(id);
            return RedirectToAction("Estudiantes");
        }
    }
}
