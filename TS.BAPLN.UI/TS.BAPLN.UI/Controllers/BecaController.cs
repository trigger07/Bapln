using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.UI.ServiceReference;

namespace TS.BAPLN.UI.Controllers
{
    public class BecaController : Controller
    {
        // GET: Beca
        public ActionResult Index()
        {
            ServiceClient c = new ServiceClient();
            List<BecaDTO> becaL = c.ObtenerBecas().ToList();
            return View(becaL);
        }

        // GET: Beca/Create
        public ActionResult Create()
        {
            ServiceClient cliente = new ServiceClient();
            BecaDTO tb = new BecaDTO();
            tb.tipoBecas = cliente.ObtenerTipoBecas().ToList();
            return View(tb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BecaDTO becaDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(becaDTO);
            }
            ServiceClient cliente = new ServiceClient();
            cliente.CrearBeca(becaDTO);
            return RedirectToAction("Index");
        }

        // GET: Beca/Edit/5
        public ActionResult Edit(int id)
        {
            ServiceClient cliente = new ServiceClient();
            BecaDTO beca = cliente.ObtenerBecaPorId(id);
            beca.tipoBecas = cliente.ObtenerTipoBecas().ToList();
            return View(beca);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BecaDTO becaDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(becaDTO);
            }
            ServiceClient cliente = new ServiceClient();
            becaDTO.Id = id;
            cliente.ActualizarBeca(becaDTO);
            return RedirectToAction("Index");
        }

        public ActionResult Inactivar(int id)
        {
            ServiceClient cliente = new ServiceClient();
            cliente.InactivarBeca(id);
            return RedirectToAction("Index");
        }

        public ActionResult Activar(int id)
        {
            ServiceClient cliente = new ServiceClient();
            cliente.ActivarBeca(id);
            return RedirectToAction("Index");
        }
    }
}
