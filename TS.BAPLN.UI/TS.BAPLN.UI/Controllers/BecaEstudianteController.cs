using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.UI.Models;
using TS.BAPLN.UI.ServiceReference;

namespace TS.BAPLN.UI.Controllers
{
    public class BecaEstudianteController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BecaEstudiante
        public ActionResult Index()
        {
           
            return View();
        }

        // GET: BecaEstudiante/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BecaEstudianteDTO becaEstudianteDTO = db.BecaEstudianteDTOes.Find(id);
            if (becaEstudianteDTO == null)
            {
                return HttpNotFound();
            }
            return View(becaEstudianteDTO);
        }

        // GET: BecaEstudiante/Create
        public ActionResult Create()
        {
            ServiceClient c = new ServiceClient();
            BecaEstudianteDTO b = new BecaEstudianteDTO();
            b.Becas = c.ObtenerBecasActivas().ToList();
            return View(b);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FechaInicio,FechaFinal,Id_Estudiante,Estudiante,Id_Beca,TipoBeca,Activa,MontoTotal,MontoCuota,CantidadCuotas")] BecaEstudianteDTO becaEstudianteDTO)
        {
            if (ModelState.IsValid)
            {
                db.BecaEstudianteDTOes.Add(becaEstudianteDTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(becaEstudianteDTO);
        }

        // GET: BecaEstudiante/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BecaEstudianteDTO becaEstudianteDTO = db.BecaEstudianteDTOes.Find(id);
            if (becaEstudianteDTO == null)
            {
                return HttpNotFound();
            }
            return View(becaEstudianteDTO);
        }

        // POST: BecaEstudiante/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FechaInicio,FechaFinal,Id_Estudiante,Estudiante,Id_Beca,TipoBeca,Activa,MontoTotal,MontoCuota,CantidadCuotas")] BecaEstudianteDTO becaEstudianteDTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(becaEstudianteDTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(becaEstudianteDTO);
        }

        // GET: BecaEstudiante/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BecaEstudianteDTO becaEstudianteDTO = db.BecaEstudianteDTOes.Find(id);
            if (becaEstudianteDTO == null)
            {
                return HttpNotFound();
            }
            return View(becaEstudianteDTO);
        }

        // POST: BecaEstudiante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BecaEstudianteDTO becaEstudianteDTO = db.BecaEstudianteDTOes.Find(id);
            db.BecaEstudianteDTOes.Remove(becaEstudianteDTO);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult ObtenerEstudiantesActivos(string prefixText)
        {
            if (prefixText.Trim().Length > 2)
            {
                List<EstudianteDTO> result = new List<EstudianteDTO>();
                ServiceClient s = new ServiceClient();

                result = s.ObtenerEstudiantesAutocomplete(prefixText).ToList();
                
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json("", JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
