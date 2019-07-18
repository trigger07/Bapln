using System;
using System.Linq;
using System.Web.Mvc;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.UI.ServiceReference;

namespace TS.BAPLN.UI.Controllers
{
    public class CatalogoController : Controller
    {
        ServiceClient cliente = null;
        CatalogosDTO catalogos = new CatalogosDTO();

        public CatalogoController()
        {
            cliente = new ServiceClient();
        }

        public ActionResult Catalogos()
        {
            ObtenerCatalogos();
            return View(catalogos);
        }

        public ActionResult Listas()
        {
            ObtenerCatalogos();
            return PartialView(catalogos);
        }

        public JsonResult Insertar(string descripcion, string catalogoId)
        {
            string result = "duplicate";
            switch (catalogoId)
            {
                case "m":
                    if (!cliente.ObtenerCatalogoMaterias().Any(m => m.Descripcion.ToLower() == descripcion.ToLower()))
                    {
                        MateriaDTO materia = new MateriaDTO();
                        materia.Descripcion = descripcion;
                        cliente.ActualizarMateria(materia);
                        result = "success";
                    }
                    break;
                case "p":
                    if (!cliente.ObtenerCatalogoPeriodos().Any(m => m.Descripcion.ToLower() == descripcion.ToLower()))
                    {
                        PeriodoDTO periodo = new PeriodoDTO();
                        periodo.Descripcion = descripcion;
                        cliente.ActualizarPeriodo(periodo);
                        result = "success";
                    }
                    break;
                case "n":
                    if (!cliente.ObtenerCatalogoNiveles().Any(m => m.Descripcion.ToLower() == descripcion.ToLower()))
                    {
                        NivelDTO nivel = new NivelDTO();
                        nivel.Descripcion = descripcion;
                        cliente.ActualizarNivel(nivel);
                        result = "success";
                    }
                    break;
                case "c":
                    if (!cliente.ObtenerCatalogoCursosLectivos().Any(m => m.Descripcion.ToLower() == descripcion.ToLower()))
                    {
                        CursoLectivoDTO cursoLectivo = new CursoLectivoDTO();
                        cursoLectivo.Descripcion = descripcion;
                        cliente.ActualizarCursoLectivo(cursoLectivo);
                        result = "success";
                    }
                    break;
            }

            return new JsonResult { Data = new { Result = result } };
        }

        public JsonResult Editar(string descripcion, string catalogoId, string itemId)
        {
            string result = "duplicate";
            switch (catalogoId)
            {
                case "m":
                    if (!cliente.ObtenerCatalogoMaterias().Any(m => m.Descripcion.ToLower() == descripcion.ToLower()))
                    {
                        MateriaDTO materia = new MateriaDTO();
                        materia.Descripcion = descripcion;
                        materia.Id = Int32.Parse(itemId);
                        cliente.ActualizarMateria(materia);
                        result = "success";
                    }
                    break;
                case "p":
                    if (!cliente.ObtenerCatalogoPeriodos().Any(m => m.Descripcion.ToLower() == descripcion.ToLower()))
                    {
                        PeriodoDTO periodo = new PeriodoDTO();
                        periodo.Descripcion = descripcion;
                        periodo.Id = Int32.Parse(itemId);
                        cliente.ActualizarPeriodo(periodo);
                        result = "success";
                    }
                    break;
                case "n":
                    if (!cliente.ObtenerCatalogoNiveles().Any(m => m.Descripcion.ToLower() == descripcion.ToLower()))
                    {
                        NivelDTO nivel = new NivelDTO();
                        nivel.Descripcion = descripcion;
                        nivel.Id = Int32.Parse(itemId);
                        cliente.ActualizarNivel(nivel);
                        result = "success";
                    }
                    break;
                case "c":
                    if (!cliente.ObtenerCatalogoCursosLectivos().Any(m => m.Descripcion.ToLower() == descripcion.ToLower()))
                    {
                        CursoLectivoDTO cursoLectivo = new CursoLectivoDTO();
                        cursoLectivo.Descripcion = descripcion;
                        cursoLectivo.Id = Int32.Parse(itemId);
                        cliente.ActualizarCursoLectivo(cursoLectivo);
                        result = "success";
                    }
                    break;
            }

            return new JsonResult { Data = new { Result = result } };
        }

        public JsonResult Activar(string catalogoId, string id)
        {
            string result = "success";

            switch (catalogoId)
            {
                case "m":                    
                        cliente.ActivarMateria(Int32.Parse(id));
                    break;
                case "p":
                    cliente.ActivarPeriodo(Int32.Parse(id));
                    break;
                case "n":
                    cliente.ActivarNivel(Int32.Parse(id));
                    break;
                case "c":
                    cliente.ActivarCursoLectivo(Int32.Parse(id));
                    break;
            }

            return new JsonResult { Data = new { Result = result } };
        }

        public JsonResult Borrar(string catalogoId, string id)
        {
            string result = "success";
            int operationResult = 1;
            switch (catalogoId)
            {
                case "m":
                    operationResult = cliente.BorrarMateria(Int32.Parse(id));
                    break;
                case "p":
                    operationResult = cliente.BorrarPeriodo(Int32.Parse(id));
                    break;
                case "n":
                    operationResult = cliente.BorrarNivel(Int32.Parse(id));
                    break;
                case "c":
                    operationResult = cliente.BorrarCursoLectivo(Int32.Parse(id));
                    break;
            }

            if (operationResult == 0)
                result = "desactivado";
            if (operationResult == 1)
                result = "borrado";

            return new JsonResult { Data = new { Result = result } };
        }

        private void ObtenerCatalogos(){
            catalogos.Materias = cliente.ObtenerCatalogoMaterias().ToList();
            catalogos.Periodos = cliente.ObtenerCatalogoPeriodos().ToList();
            catalogos.Niveles = cliente.ObtenerCatalogoNiveles().ToList();
            catalogos.CursosLectivos = cliente.ObtenerCatalogoCursosLectivos().ToList();
        }
    }
}