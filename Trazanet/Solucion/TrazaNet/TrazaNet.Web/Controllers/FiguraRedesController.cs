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
    public class FiguraRedesController : Controller
    {
        private TrazaNetEntitiesContext db = new TrazaNetEntitiesContext();

        // GET: FiguraRedes
        public ActionResult Index()
        {
            return View(db.FIGURARED.ToList());
        }

        // GET: FiguraRedes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FIGURARED fIGURARED = db.FIGURARED.Find(id);
            if (fIGURARED == null)
            {
                return HttpNotFound();
            }
            return View(fIGURARED);
        }

        // GET: FiguraRedes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FiguraRedes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDFIGURA,NOMFIGURA,DESCFIGURA")] FIGURARED fIGURARED)
        {
            if (ModelState.IsValid)
            {
                db.FIGURARED.Add(fIGURARED);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fIGURARED);
        }

        // GET: FiguraRedes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FIGURARED fIGURARED = db.FIGURARED.Find(id);
            if (fIGURARED == null)
            {
                return HttpNotFound();
            }
            return View(fIGURARED);
        }

        // POST: FiguraRedes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDFIGURA,NOMFIGURA,DESCFIGURA")] FIGURARED fIGURARED)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fIGURARED).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fIGURARED);
        }

        // GET: FiguraRedes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FIGURARED fIGURARED = db.FIGURARED.Find(id);
            if (fIGURARED == null)
            {
                return HttpNotFound();
            }
            return View(fIGURARED);
        }

        // POST: FiguraRedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FIGURARED fIGURARED = db.FIGURARED.Find(id);
            db.FIGURARED.Remove(fIGURARED);
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
