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
    public class RedesController : Controller
    {
        private TrazaNetEntitiesContext db = new TrazaNetEntitiesContext();

        // GET: Redes
        public ActionResult Index()
        {
            var rED = db.RED.Include(r => r.TALLER).Include(r => r.TIPORED);
            return View(rED.ToList());
        }

        // GET: Redes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RED rED = db.RED.Find(id);
            if (rED == null)
            {
                return HttpNotFound();
            }
            return View(rED);
        }

        // GET: Redes/Create
        public ActionResult Create()
        {
            ViewBag.RUTTALLER = new SelectList(db.TALLER, "RUTTALLER", "NOMBRETALLER");
            ViewBag.IDTIPORED = new SelectList(db.TIPORED, "IDTIPORED", "NOMTIPORED");
            return View();
        }

        // POST: Redes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDRED,IDTIPORED,RUTTALLER,TENSIOMETRIAINICIAL,FECHAINGRESO,COSTOINICIAL,VIGENCIARED,FECHACAMBIO")] RED rED)
        {
            if (ModelState.IsValid)
            {
                db.RED.Add(rED);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RUTTALLER = new SelectList(db.TALLER, "RUTTALLER", "NOMBRETALLER", rED.RUTTALLER);
            ViewBag.IDTIPORED = new SelectList(db.TIPORED, "IDTIPORED", "NOMTIPORED", rED.IDTIPORED);
            return View(rED);
        }

        // GET: Redes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RED rED = db.RED.Find(id);
            if (rED == null)
            {
                return HttpNotFound();
            }
            ViewBag.RUTTALLER = new SelectList(db.TALLER, "RUTTALLER", "NOMBRETALLER", rED.RUTTALLER);
            ViewBag.IDTIPORED = new SelectList(db.TIPORED, "IDTIPORED", "NOMTIPORED", rED.IDTIPORED);
            return View(rED);
        }

        // POST: Redes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDRED,IDTIPORED,RUTTALLER,TENSIOMETRIAINICIAL,FECHAINGRESO,COSTOINICIAL,VIGENCIARED,FECHACAMBIO")] RED rED)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rED).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RUTTALLER = new SelectList(db.TALLER, "RUTTALLER", "NOMBRETALLER", rED.RUTTALLER);
            ViewBag.IDTIPORED = new SelectList(db.TIPORED, "IDTIPORED", "NOMTIPORED", rED.IDTIPORED);
            return View(rED);
        }

        // GET: Redes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RED rED = db.RED.Find(id);
            if (rED == null)
            {
                return HttpNotFound();
            }
            return View(rED);
        }

        // POST: Redes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RED rED = db.RED.Find(id);
            db.RED.Remove(rED);
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
