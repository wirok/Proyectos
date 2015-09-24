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
    public class TipoRedesController : Controller
    {
        private TrazaNetEntitiesContext db = new TrazaNetEntitiesContext();

        // GET: TipoRedes
        public ActionResult Index()
        {
            var tIPORED = db.TIPORED.Include(t => t.ABERTURARED).Include(t => t.DENIERRED).Include(t => t.FIGURARED).Include(t => t.FUNCIONRED).Include(t => t.MEDIDARED).Include(t => t.TELARED);
            return View(tIPORED.ToList());
        }

        // GET: TipoRedes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPORED tIPORED = db.TIPORED.Find(id);
            if (tIPORED == null)
            {
                return HttpNotFound();
            }
            return View(tIPORED);
        }

        // GET: TipoRedes/Create
        public ActionResult Create()
        {
            ViewBag.IDABERTURARED = new SelectList(db.ABERTURARED, "IDABERTURARED", "NOMABERTURA");
            ViewBag.IDDENIER = new SelectList(db.DENIERRED, "IDDENIERRED", "NOMDENIER");
            ViewBag.IDFIGURA = new SelectList(db.FIGURARED, "IDFIGURA", "NOMFIGURA");
            ViewBag.IDFUNCIONRED = new SelectList(db.FUNCIONRED, "IDFUNCIONRED", "NOMFUNCION");
            ViewBag.IDMEDIDARED = new SelectList(db.MEDIDARED, "IDMEDIDARED", "NOMMEDIDA");
            ViewBag.IDTELA = new SelectList(db.TELARED, "IDTELA", "NOMTELA");
            return View();
        }

        // POST: TipoRedes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDTIPORED,NOMTIPORED,IDDENIER,IDMEDIDARED,IDTELA,IDABERTURARED,IDFUNCIONRED,IDFIGURA,ZIPPET,TENSIONSTANDAR,TESNSIONMINIMA,PERIODOESTANDAR")] TIPORED tIPORED)
        {
            if (ModelState.IsValid)
            {
                db.TIPORED.Add(tIPORED);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDABERTURARED = new SelectList(db.ABERTURARED, "IDABERTURARED", "NOMABERTURA", tIPORED.IDABERTURARED);
            ViewBag.IDDENIER = new SelectList(db.DENIERRED, "IDDENIERRED", "NOMDENIER", tIPORED.IDDENIER);
            ViewBag.IDFIGURA = new SelectList(db.FIGURARED, "IDFIGURA", "NOMFIGURA", tIPORED.IDFIGURA);
            ViewBag.IDFUNCIONRED = new SelectList(db.FUNCIONRED, "IDFUNCIONRED", "NOMFUNCION", tIPORED.IDFUNCIONRED);
            ViewBag.IDMEDIDARED = new SelectList(db.MEDIDARED, "IDMEDIDARED", "NOMMEDIDA", tIPORED.IDMEDIDARED);
            ViewBag.IDTELA = new SelectList(db.TELARED, "IDTELA", "NOMTELA", tIPORED.IDTELA);
            return View(tIPORED);
        }

        // GET: TipoRedes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPORED tIPORED = db.TIPORED.Find(id);
            if (tIPORED == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDABERTURARED = new SelectList(db.ABERTURARED, "IDABERTURARED", "NOMABERTURA", tIPORED.IDABERTURARED);
            ViewBag.IDDENIER = new SelectList(db.DENIERRED, "IDDENIERRED", "NOMDENIER", tIPORED.IDDENIER);
            ViewBag.IDFIGURA = new SelectList(db.FIGURARED, "IDFIGURA", "NOMFIGURA", tIPORED.IDFIGURA);
            ViewBag.IDFUNCIONRED = new SelectList(db.FUNCIONRED, "IDFUNCIONRED", "NOMFUNCION", tIPORED.IDFUNCIONRED);
            ViewBag.IDMEDIDARED = new SelectList(db.MEDIDARED, "IDMEDIDARED", "NOMMEDIDA", tIPORED.IDMEDIDARED);
            ViewBag.IDTELA = new SelectList(db.TELARED, "IDTELA", "NOMTELA", tIPORED.IDTELA);
            return View(tIPORED);
        }

        // POST: TipoRedes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDTIPORED,NOMTIPORED,IDDENIER,IDMEDIDARED,IDTELA,IDABERTURARED,IDFUNCIONRED,IDFIGURA,ZIPPET,TENSIONSTANDAR,TESNSIONMINIMA,PERIODOESTANDAR")] TIPORED tIPORED)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tIPORED).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDABERTURARED = new SelectList(db.ABERTURARED, "IDABERTURARED", "NOMABERTURA", tIPORED.IDABERTURARED);
            ViewBag.IDDENIER = new SelectList(db.DENIERRED, "IDDENIERRED", "NOMDENIER", tIPORED.IDDENIER);
            ViewBag.IDFIGURA = new SelectList(db.FIGURARED, "IDFIGURA", "NOMFIGURA", tIPORED.IDFIGURA);
            ViewBag.IDFUNCIONRED = new SelectList(db.FUNCIONRED, "IDFUNCIONRED", "NOMFUNCION", tIPORED.IDFUNCIONRED);
            ViewBag.IDMEDIDARED = new SelectList(db.MEDIDARED, "IDMEDIDARED", "NOMMEDIDA", tIPORED.IDMEDIDARED);
            ViewBag.IDTELA = new SelectList(db.TELARED, "IDTELA", "NOMTELA", tIPORED.IDTELA);
            return View(tIPORED);
        }

        // GET: TipoRedes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPORED tIPORED = db.TIPORED.Find(id);
            if (tIPORED == null)
            {
                return HttpNotFound();
            }
            return View(tIPORED);
        }

        // POST: TipoRedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TIPORED tIPORED = db.TIPORED.Find(id);
            db.TIPORED.Remove(tIPORED);
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
