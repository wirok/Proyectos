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
    public class FuncionRedesController : Controller
    {
        private TrazaNetEntitiesContext db = new TrazaNetEntitiesContext();

        // GET: FuncionRedes
        public ActionResult Index()
        {
            return View(db.FUNCIONRED.ToList());
        }

        // GET: FuncionRedes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FUNCIONRED fUNCIONRED = db.FUNCIONRED.Find(id);
            if (fUNCIONRED == null)
            {
                return HttpNotFound();
            }
            return View(fUNCIONRED);
        }

        // GET: FuncionRedes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FuncionRedes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDFUNCIONRED,NOMFUNCION,DESCFUNCION")] FUNCIONRED fUNCIONRED)
        {
            if (ModelState.IsValid)
            {
                db.FUNCIONRED.Add(fUNCIONRED);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fUNCIONRED);
        }

        // GET: FuncionRedes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FUNCIONRED fUNCIONRED = db.FUNCIONRED.Find(id);
            if (fUNCIONRED == null)
            {
                return HttpNotFound();
            }
            return View(fUNCIONRED);
        }

        // POST: FuncionRedes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDFUNCIONRED,NOMFUNCION,DESCFUNCION")] FUNCIONRED fUNCIONRED)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fUNCIONRED).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fUNCIONRED);
        }

        // GET: FuncionRedes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FUNCIONRED fUNCIONRED = db.FUNCIONRED.Find(id);
            if (fUNCIONRED == null)
            {
                return HttpNotFound();
            }
            return View(fUNCIONRED);
        }

        // POST: FuncionRedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FUNCIONRED fUNCIONRED = db.FUNCIONRED.Find(id);
            db.FUNCIONRED.Remove(fUNCIONRED);
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
