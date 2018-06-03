using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DiabetesTrackerASPAplikacija.Models;

namespace DiabetesTrackerASPAplikacija.Controllers
{
    [Authorize]
    public class Dnevni_unosController : Controller
    {
        private DiabetesTrackerASPAplikacijaContext db = new DiabetesTrackerASPAplikacijaContext();

        // GET: Dnevni_unos
        public ActionResult Index()
        {
            return View(db.DnevniUnos.ToList());
        }

        // GET: Dnevni_unos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dnevni_unos dnevni_unos = db.DnevniUnos.Find(id);
            if (dnevni_unos == null)
            {
                return HttpNotFound();
            }
            return View(dnevni_unos);
        }

        // GET: Dnevni_unos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dnevni_unos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Datum,TipKategorije")] Dnevni_unos dnevni_unos)
        {
            if (ModelState.IsValid)
            {
                db.DnevniUnos.Add(dnevni_unos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dnevni_unos);
        }

        // GET: Dnevni_unos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dnevni_unos dnevni_unos = db.DnevniUnos.Find(id);
            if (dnevni_unos == null)
            {
                return HttpNotFound();
            }
            return View(dnevni_unos);
        }

        // POST: Dnevni_unos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Datum,TipKategorije")] Dnevni_unos dnevni_unos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dnevni_unos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dnevni_unos);
        }

        // GET: Dnevni_unos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dnevni_unos dnevni_unos = db.DnevniUnos.Find(id);
            if (dnevni_unos == null)
            {
                return HttpNotFound();
            }
            return View(dnevni_unos);
        }

        // POST: Dnevni_unos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dnevni_unos dnevni_unos = db.DnevniUnos.Find(id);
            db.DnevniUnos.Remove(dnevni_unos);
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
