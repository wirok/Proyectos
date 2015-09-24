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
    public class MedidaRedesController : Controller
    {
        private TrazaNetEntitiesContext db = new TrazaNetEntitiesContext();

        // GET: MedidaRedes
        public ActionResult Index()
        {
            return View(db.MEDIDARED.ToList());
        }

        // GET: MedidaRedes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MEDIDARED mEDIDARED = db.MEDIDARED.Find(id);
            if (mEDIDARED == null)
            {
                return HttpNotFound();
            }
            return View(mEDIDARED);
        }

        // GET: MedidaRedes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedidaRedes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDMEDIDARED,NOMMEDIDA,DESCMEDIDA")] MEDIDARED mEDIDARED)
        {
            if (ModelState.IsValid)
            {
                db.MEDIDARED.Add(mEDIDARED);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mEDIDARED);
        }

        // GET: MedidaRedes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MEDIDARED mEDIDARED = db.MEDIDARED.Find(id);
            if (mEDIDARED == null)
            {
                return HttpNotFound();
            }
            return View(mEDIDARED);
        }

        // POST: MedidaRedes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDMEDIDARED,NOMMEDIDA,DESCMEDIDA")] MEDIDARED mEDIDARED)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mEDIDARED).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mEDIDARED);
        }

        // GET: MedidaRedes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MEDIDARED mEDIDARED = db.MEDIDARED.Find(id);
            if (mEDIDARED == null)
            {
                return HttpNotFound();
            }
            return View(mEDIDARED);
        }

        // POST: MedidaRedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MEDIDARED mEDIDARED = db.MEDIDARED.Find(id);
            db.MEDIDARED.Remove(mEDIDARED);
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
