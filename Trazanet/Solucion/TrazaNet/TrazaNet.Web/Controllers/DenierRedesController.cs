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
    public class DenierRedesController : Controller
    {
        private TrazaNetEntitiesContext db = new TrazaNetEntitiesContext();

        // GET: DenierRedes
        public ActionResult Index()
        {
            return View(db.DENIERRED.ToList());
        }

        // GET: DenierRedes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DENIERRED dENIERRED = db.DENIERRED.Find(id);
            if (dENIERRED == null)
            {
                return HttpNotFound();
            }
            return View(dENIERRED);
        }

        // GET: DenierRedes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DenierRedes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDDENIERRED,NOMDENIER,DESCDENIER")] DENIERRED dENIERRED)
        {
            if (ModelState.IsValid)
            {
                db.DENIERRED.Add(dENIERRED);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dENIERRED);
        }

        // GET: DenierRedes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DENIERRED dENIERRED = db.DENIERRED.Find(id);
            if (dENIERRED == null)
            {
                return HttpNotFound();
            }
            return View(dENIERRED);
        }

        // POST: DenierRedes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDDENIERRED,NOMDENIER,DESCDENIER")] DENIERRED dENIERRED)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dENIERRED).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dENIERRED);
        }

        // GET: DenierRedes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DENIERRED dENIERRED = db.DENIERRED.Find(id);
            if (dENIERRED == null)
            {
                return HttpNotFound();
            }
            return View(dENIERRED);
        }

        // POST: DenierRedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DENIERRED dENIERRED = db.DENIERRED.Find(id);
            db.DENIERRED.Remove(dENIERRED);
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
