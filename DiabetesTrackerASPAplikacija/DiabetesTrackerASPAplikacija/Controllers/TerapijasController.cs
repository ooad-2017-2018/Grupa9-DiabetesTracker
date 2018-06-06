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
    public class TerapijasController : Controller
    {
        private DiabetesTrackerASPAplikacijaContext db = new DiabetesTrackerASPAplikacijaContext();

        // GET: Terapijas
        public ActionResult Index()
        {
            var terapija = db.Terapija.Include(t => t.Korisnik);
            return View(terapija.ToList());
        }

        // GET: Terapijas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Terapija terapija = db.Terapija.Find(id);
            if (terapija == null)
            {
                return HttpNotFound();
            }
            return View(terapija);
        }

        // GET: Terapijas/Create
        public ActionResult Create()
        {
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa");
            return View();
        }

        // POST: Terapijas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Lijekovi,DozaLijeka,Tip,KorisnikId")] Terapija terapija)
        {
            if (ModelState.IsValid)
            {
                var dajId = db.Database.SqlQuery<int>("SELECT Id FROM dbo.Korisnik WHERE " + "EMail = '" + User.Identity.Name + "'").ToList();
                if (dajId.Count > 0)
                    terapija.KorisnikId = dajId[0];
                db.Terapija.Add(terapija);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", terapija.KorisnikId);
            return View(terapija);
        }

        // GET: Terapijas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Terapija terapija = db.Terapija.Find(id);
            if (terapija == null)
            {
                return HttpNotFound();
            }
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", terapija.KorisnikId);
            return View(terapija);
        }

        // POST: Terapijas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Lijekovi,DozaLijeka,Tip,KorisnikId")] Terapija terapija)
        {
            if (ModelState.IsValid)
            {
                db.Entry(terapija).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", terapija.KorisnikId);
            return View(terapija);
        }

        // GET: Terapijas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Terapija terapija = db.Terapija.Find(id);
            if (terapija == null)
            {
                return HttpNotFound();
            }
            return View(terapija);
        }

        // POST: Terapijas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Terapija terapija = db.Terapija.Find(id);
            db.Terapija.Remove(terapija);
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
