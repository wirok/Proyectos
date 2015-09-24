using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrazaNet.DataLayer;

namespace TrazaNet.Web.Controllers
{
    public class TalleresController : Controller
    {
        private TrazaNetEntitiesContext db = new TrazaNetEntitiesContext();

        // GET: Talleres
        public ActionResult Index()
        {
            return View(db.TALLER.ToList());
        }

        // GET: Talleres/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TALLER tALLER = db.TALLER.Find(id);
            if (tALLER == null)
            {
                return HttpNotFound();
            }
            return View(tALLER);
        }

        // GET: Talleres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Talleres/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RUTTALLER,NOMBRETALLER,CONTACTOTALLER,CIUDADTALLER,DIRECCIONTALLER,FONOTALLER,EMAILTALLER,VIGENCIATALLER")] TALLER tALLER)
        {
            if (ModelState.IsValid)
            {
                db.TALLER.Add(tALLER);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tALLER);
        }

        // GET: Talleres/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TALLER tALLER = db.TALLER.Find(id);
            if (tALLER == null)
            {
                return HttpNotFound();
            }
            return View(tALLER);
        }

        // POST: Talleres/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RUTTALLER,NOMBRETALLER,CONTACTOTALLER,CIUDADTALLER,DIRECCIONTALLER,FONOTALLER,EMAILTALLER,VIGENCIATALLER")] TALLER tALLER)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tALLER).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tALLER);
        }

        // GET: Talleres/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TALLER tALLER = db.TALLER.Find(id);
            if (tALLER == null)
            {
                return HttpNotFound();
            }
            return View(tALLER);
        }

        // POST: Talleres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TALLER tALLER = db.TALLER.Find(id);
            db.TALLER.Remove(tALLER);
            db.SaveChanges();
            return RedirectToAction("Index");
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
