﻿using System;
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
    public class UnosHranesController : Controller
    {
        
        private DiabetesTrackerASPAplikacijaContext db = new DiabetesTrackerASPAplikacijaContext();

        // GET: UnosHranes
        public ActionResult Index()
        {
            var unosHrane = db.UnosHrane.Include(u => u.Korisnik);
            return View(unosHrane.ToList());
        }

        // GET: UnosHranes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnosHrane unosHrane = db.UnosHrane.Find(id);
            if (unosHrane == null)
            {
                return HttpNotFound();
            }
            return View(unosHrane);
        }

        // GET: UnosHranes/Create
        public ActionResult Create()
        {
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa");
            return View();
        }

        // POST: UnosHranes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Datum,TipKategorije,KorisnikId")] UnosHrane unosHrane)
        {
            if (ModelState.IsValid)
            {
                var dajId = db.Database.SqlQuery<int>("SELECT Id FROM dbo.Korisnik WHERE " + "EMail = '" + User.Identity.Name + "'").ToList();
                if(dajId.Count>0)
                    unosHrane.KorisnikId = dajId[0];
                db.UnosHrane.Add(unosHrane);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", unosHrane.KorisnikId);
            return View(unosHrane);
        }

        // GET: UnosHranes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnosHrane unosHrane = db.UnosHrane.Find(id);
            if (unosHrane == null)
            {
                return HttpNotFound();
            }
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", unosHrane.KorisnikId);
            return View(unosHrane);
        }

        // POST: UnosHranes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Datum,TipKategorije,KorisnikId")] UnosHrane unosHrane)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unosHrane).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KorisnikId = new SelectList(db.Korisnik, "Id", "TipDijabetesa", unosHrane.KorisnikId);
            return View(unosHrane);
        }

        // GET: UnosHranes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnosHrane unosHrane = db.UnosHrane.Find(id);
            if (unosHrane == null)
            {
                return HttpNotFound();
            }
            return View(unosHrane);
        }

        // POST: UnosHranes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UnosHrane unosHrane = db.UnosHrane.Find(id);
            db.UnosHrane.Remove(unosHrane);
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
