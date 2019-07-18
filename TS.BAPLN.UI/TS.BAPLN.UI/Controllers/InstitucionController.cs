using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Mvc;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.UI.Models;
using TS.BAPLN.UI.ServiceReference;

namespace TS.BAPLN.UI.Controllers
{
    public class InstitucionController : Controller
    {
        ServiceClient cliente = null;

        public InstitucionController()
        {
            cliente = new ServiceClient();
        }

        public ActionResult Instituciones()
        {
            List<InstitucionDTO> instituciones = cliente.ObtenerInstituciones().ToList();
            return View(instituciones);
        }

        public ActionResult Editar(int id)
        {
            ViewBag.InstitucionId = id;

            InstitucionViewModel institucion = new InstitucionViewModel();
            institucion.Institucion = cliente.ObtenerInstitucion(id);
            institucion.Materias = cliente.ObtenerMaterias(id).ToList();
            institucion.Periodos = cliente.ObtenerPeriodos(id).ToList();
            institucion.Niveles = cliente.ObtenerNiveles(id).ToList();
            institucion.MateriasSeleccionadas = string.Join(",", institucion.Materias.Select(x => x.Id));
            institucion.PeriodosSeleccionados = string.Join(",", institucion.Periodos.Select(x => x.Id));
            institucion.NivelesSeleccionados = string.Join(",", institucion.Niveles.Select(x => x.Id));
            return View(institucion);
        }

        [HttpPost]
        public JsonResult Editar(int id, InstitucionViewModel model)
        {
            string result = "duplicate";
            List<InstitucionDTO> instituciones = cliente.ObtenerInstituciones().ToList();
            int[] materiasSeleccionadas = model.MateriasSeleccionadas != null ? Array.ConvertAll(model.MateriasSeleccionadas.Split(','), s => int.Parse(s.Trim())) : new int[] {};
            int[] periodosSeleccionados = model.PeriodosSeleccionados != null ? Array.ConvertAll(model.PeriodosSeleccionados.Split(','), s => int.Parse(s.Trim())) : new int[] {};
            int[] nivelesSeleccionados = model.NivelesSeleccionados != null ? Array.ConvertAll(model.NivelesSeleccionados.Split(','), s => int.Parse(s.Trim())) : new int[] {};
            model.Institucion.Id = id;
            if (!instituciones.Any(i => i.Nombre.ToLower() == model.Institucion.Nombre.ToLower() && (i.Id != id || model.Institucion.Id == 0)))
            {
                cliente.ActualizarInstitucion(model.Institucion, materiasSeleccionadas, periodosSeleccionados, nivelesSeleccionados);
                result = "success";
            }

            return new JsonResult { Data = new { Result = result } };
        }

        public ActionResult Crear()
        {
            ViewBag.InstitucionId = 0;

            InstitucionViewModel institucion = new InstitucionViewModel();
            institucion.Institucion = new InstitucionDTO();
            institucion.Materias = new List<MateriaDTO>();
            institucion.Periodos = new List<PeriodoDTO>();
            institucion.Niveles = new List<NivelDTO>();
            institucion.MateriasSeleccionadas = "";
            institucion.PeriodosSeleccionados = "";
            institucion.NivelesSeleccionados = "";
            return View("Editar", institucion);
        }

        [HttpGet]
        public JsonResult ObtenerCatalogoMaterias()
        {
            List<MateriaDTO> materias = cliente.ObtenerCatalogoMaterias().ToList();
            return Json(materias, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ObtenerCatalogoPeriodos()
        {
            List<PeriodoDTO> periodos = cliente.ObtenerCatalogoPeriodos().ToList();
            return Json(periodos, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ObtenerCatalogoNiveles()
        {
            List<NivelDTO> niveles = cliente.ObtenerCatalogoNiveles().ToList();
            return Json(niveles, JsonRequestBehavior.AllowGet);
        }
    }
}