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
    public class TelaRedesController : Controller
    {
        private TrazaNetEntitiesContext db = new TrazaNetEntitiesContext();

        // GET: TelaRedes
        public ActionResult Index()
        {
            return View(db.TELARED.ToList());
        }

        // GET: TelaRedes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TELARED tELARED = db.TELARED.Find(id);
            if (tELARED == null)
            {
                return HttpNotFound();
            }
            return View(tELARED);
        }

        // GET: TelaRedes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TelaRedes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDTELA,NOMTELA,DESCTELA")] TELARED tELARED)
        {
            if (ModelState.IsValid)
            {
                db.TELARED.Add(tELARED);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tELARED);
        }

        // GET: TelaRedes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TELARED tELARED = db.TELARED.Find(id);
            if (tELARED == null)
            {
                return HttpNotFound();
            }
            return View(tELARED);
        }

        // POST: TelaRedes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDTELA,NOMTELA,DESCTELA")] TELARED tELARED)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tELARED).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tELARED);
        }

        // GET: TelaRedes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TELARED tELARED = db.TELARED.Find(id);
            if (tELARED == null)
            {
                return HttpNotFound();
            }
            return View(tELARED);
        }

        // POST: TelaRedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TELARED tELARED = db.TELARED.Find(id);
            db.TELARED.Remove(tELARED);
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
