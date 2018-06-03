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
    public class UnosNijeHranasController : Controller
    {
        private DiabetesTrackerASPAplikacijaContext db = new DiabetesTrackerASPAplikacijaContext();

        // GET: UnosNijeHranas
        public ActionResult Index()
        {
            var unosNijeHrana = db.UnosNijeHrana.Include(u => u.Korisnik);
            return View(unosNijeHrana.ToList());
        }

        // GET: UnosNijeHranas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnosNijeHrana unosNijeHrana = db.UnosNijeHrana.Find(id);
            if (unosNijeHrana == null)
            {
                return HttpNotFound();
            }
            return View(unosNijeHrana);
        }

        // GET: UnosNijeHranas/Create
        public ActionResult Create()
        {
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa");
            return View();
        }

        // POST: UnosNijeHranas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tip,Vrijednost,Datum,TipKategorije,KorisnikId")] UnosNijeHrana unosNijeHrana)
        {
            if (ModelState.IsValid)
            {
                db.UnosNijeHrana.Add(unosNijeHrana);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", unosNijeHrana.KorisnikId);
            return View(unosNijeHrana);
        }

        // GET: UnosNijeHranas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnosNijeHrana unosNijeHrana = db.UnosNijeHrana.Find(id);
            if (unosNijeHrana == null)
            {
                return HttpNotFound();
            }
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", unosNijeHrana.KorisnikId);
            return View(unosNijeHrana);
        }

        // POST: UnosNijeHranas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tip,Vrijednost,Datum,TipKategorije,KorisnikId")] UnosNijeHrana unosNijeHrana)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unosNijeHrana).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", unosNijeHrana.KorisnikId);
            return View(unosNijeHrana);
        }

        // GET: UnosNijeHranas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnosNijeHrana unosNijeHrana = db.UnosNijeHrana.Find(id);
            if (unosNijeHrana == null)
            {
                return HttpNotFound();
            }
            return View(unosNijeHrana);
        }

        // POST: UnosNijeHranas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UnosNijeHrana unosNijeHrana = db.UnosNijeHrana.Find(id);
            db.UnosNijeHrana.Remove(unosNijeHrana);
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
