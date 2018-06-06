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
    public class PodsjetniksController : Controller
    {
        
        private DiabetesTrackerASPAplikacijaContext db = new DiabetesTrackerASPAplikacijaContext();

        // GET: Podsjetniks
        public ActionResult Index()
        {
            var podsjetnik = db.Podsjetnik.Include(p => p.Korisnik);
            return View(podsjetnik.ToList());
        }

        // GET: Podsjetniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Podsjetnik podsjetnik = db.Podsjetnik.Find(id);
            if (podsjetnik == null)
            {
                return HttpNotFound();
            }
            return View(podsjetnik);
        }

        // GET: Podsjetniks/Create
        public ActionResult Create()
        {
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa");
            return View();
        }

        // POST: Podsjetniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tip,Datum,Ponavljanje,Opis,KorisnikId")] Podsjetnik podsjetnik)
        {
            if (ModelState.IsValid)
            {
                var dajId = db.Database.SqlQuery<int>("SELECT Id FROM dbo.Korisnik WHERE " + "EMail = '" + User.Identity.Name + "'").ToList();
                if (dajId.Count > 0)
                    podsjetnik.KorisnikId = dajId[0];                
                db.Podsjetnik.Add(podsjetnik);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", podsjetnik.KorisnikId);
            return View(podsjetnik);
        }

        // GET: Podsjetniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Podsjetnik podsjetnik = db.Podsjetnik.Find(id);
            if (podsjetnik == null)
            {
                return HttpNotFound();
            }
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", podsjetnik.KorisnikId);
            return View(podsjetnik);
        }

        // POST: Podsjetniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tip,Datum,Ponavljanje,Opis,KorisnikId")] Podsjetnik podsjetnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(podsjetnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", podsjetnik.KorisnikId);
            return View(podsjetnik);
        }

        // GET: Podsjetniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Podsjetnik podsjetnik = db.Podsjetnik.Find(id);
            if (podsjetnik == null)
            {
                return HttpNotFound();
            }
            return View(podsjetnik);
        }

        // POST: Podsjetniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Podsjetnik podsjetnik = db.Podsjetnik.Find(id);
            db.Podsjetnik.Remove(podsjetnik);
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
