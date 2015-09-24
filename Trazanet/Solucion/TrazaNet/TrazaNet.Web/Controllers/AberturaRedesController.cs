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
    public class AberturaRedesController : Controller
    {
        private TrazaNetEntitiesContext db = new TrazaNetEntitiesContext();

        // GET: AberturaRedes
        public ActionResult Index()
        {
            return View(db.ABERTURARED.ToList());
        }

        // GET: AberturaRedes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ABERTURARED aBERTURARED = db.ABERTURARED.Find(id);
            if (aBERTURARED == null)
            {
                return HttpNotFound();
            }
            return View(aBERTURARED);
        }

        // GET: AberturaRedes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AberturaRedes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDABERTURARED,NOMABERTURA,DESCABERTURA")] ABERTURARED aBERTURARED)
        {
            if (ModelState.IsValid)
            {
                db.ABERTURARED.Add(aBERTURARED);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aBERTURARED);
        }

        // GET: AberturaRedes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ABERTURARED aBERTURARED = db.ABERTURARED.Find(id);
            if (aBERTURARED == null)
            {
                return HttpNotFound();
            }
            return View(aBERTURARED);
        }

        // POST: AberturaRedes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDABERTURARED,NOMABERTURA,DESCABERTURA")] ABERTURARED aBERTURARED)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aBERTURARED).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aBERTURARED);
        }

        // GET: AberturaRedes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ABERTURARED aBERTURARED = db.ABERTURARED.Find(id);
            if (aBERTURARED == null)
            {
                return HttpNotFound();
            }
            return View(aBERTURARED);
        }

        // POST: AberturaRedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ABERTURARED aBERTURARED = db.ABERTURARED.Find(id);
            db.ABERTURARED.Remove(aBERTURARED);
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
