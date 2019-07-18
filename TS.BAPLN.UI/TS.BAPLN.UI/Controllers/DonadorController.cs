using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.UI.ServiceReference;

namespace TS.BAPLN.UI.Controllers
{
    public class DonadorController : Controller
    {
        public ActionResult Donadores()
        {
            ServiceClient cliente = new ServiceClient();
            List<DonadorDTO> donadores = cliente.ObtenerDonadores().ToList();
            return View(donadores);
        }

        public ActionResult Detalle(int id)
        {
            ServiceClient client = new ServiceClient();
            DonadorDTO donador = client.ObtenerDonador(id);

            return PartialView(donador);
        }

        public ActionResult Crear()
        {
            ServiceClient cliente = new ServiceClient();
            DonadorDTO donador = new DonadorDTO();
            donador.Nacionalidades = cliente.ObtenerNacionalidades().ToList();
            donador.Periodicidades = cliente.ObtenerPeriodicidades().ToList();
            return View(donador);
        }

        [HttpPost]
        public ActionResult Crear(DonadorDTO donador)
        {
            ServiceClient cliente = new ServiceClient();
            
            if (!ModelState.IsValid)
            {
                donador.Nacionalidades = cliente.ObtenerNacionalidades().ToList();
                donador.Periodicidades = cliente.ObtenerPeriodicidades().ToList();
                return View(donador);
            }
            
            cliente.CrearDonador(donador);
            return RedirectToAction("Donadores");
        }

        public ActionResult Editar(int id)
        {
            ServiceClient cliente = new ServiceClient();
            DonadorDTO donador = cliente.ObtenerDonador(id);
            donador.Nacionalidades = cliente.ObtenerNacionalidades().ToList();
            donador.Periodicidades = cliente.ObtenerPeriodicidades().ToList();
            return View(donador);
        }

        [HttpPost]
        public ActionResult Editar(int id, DonadorDTO donador)
        {
            ServiceClient cliente = new ServiceClient();

            if (!ModelState.IsValid)
            {
                donador.Nacionalidades = cliente.ObtenerNacionalidades().ToList();
                donador.Periodicidades = cliente.ObtenerPeriodicidades().ToList();
                return View(donador);
            }
            
            donador.Id = id;
            cliente.ActualizarDonador(donador);
            return RedirectToAction("Donadores");
        }

        public ActionResult Inactivar(int id)
        {
            ServiceClient cliente = new ServiceClient();
            cliente.InactivarDonador(id);
            return RedirectToAction("Donadores");
        }

        public ActionResult Activar(int id)
        {
            ServiceClient cliente = new ServiceClient();
            cliente.ActivarDonador(id);
            return RedirectToAction("Donadores");
        }
    }
}
