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
    public class NalazsController : Controller
    {
        private DiabetesTrackerASPAplikacijaContext db = new DiabetesTrackerASPAplikacijaContext();

        // GET: Nalazs
        public ActionResult Index()
        {
            var nalaz = db.Nalaz.Include(n => n.Korisnik);
            return View(nalaz.ToList());
        }

        // GET: Nalazs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nalaz nalaz = db.Nalaz.Find(id);
            if (nalaz == null)
            {
                return HttpNotFound();
            }
            return View(nalaz);
        }

        // GET: Nalazs/Create
        public ActionResult Create()
        {
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "JMBG");
            return View();
        }

        // POST: Nalazs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NazivFajla,TekstNalaza,KorisnikId")] Nalaz nalaz)
        {
            if (ModelState.IsValid)
            {
                db.Nalaz.Add(nalaz);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "JMBG", nalaz.KorisnikId);
            return View(nalaz);
        }

        // GET: Nalazs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nalaz nalaz = db.Nalaz.Find(id);
            if (nalaz == null)
            {
                return HttpNotFound();
            }
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", nalaz.KorisnikId);
            return View(nalaz);
        }

        // POST: Nalazs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NazivFajla,TekstNalaza,KorisnikId")] Nalaz nalaz)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nalaz).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", nalaz.KorisnikId);
            return View(nalaz);
        }

        // GET: Nalazs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nalaz nalaz = db.Nalaz.Find(id);
            if (nalaz == null)
            {
                return HttpNotFound();
            }
            return View(nalaz);
        }

        // POST: Nalazs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nalaz nalaz = db.Nalaz.Find(id);
            db.Nalaz.Remove(nalaz);
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
