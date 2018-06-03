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
    public class NamirnicaDodatnoesController : Controller
    {
        
        private DiabetesTrackerASPAplikacijaContext db = new DiabetesTrackerASPAplikacijaContext();

        // GET: NamirnicaDodatnoes
        public ActionResult Index()
        {
            return View(db.NamirnicaDodatno.ToList());
        }

        // GET: NamirnicaDodatnoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NamirnicaDodatno namirnicaDodatno = db.NamirnicaDodatno.Find(id);
            if (namirnicaDodatno == null)
            {
                return HttpNotFound();
            }
            return View(namirnicaDodatno);
        }

        // GET: NamirnicaDodatnoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NamirnicaDodatnoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Vrsta,Secer,Ugljikohidrati,Masti")] NamirnicaDodatno namirnicaDodatno)
        {
            if (ModelState.IsValid)
            {
                db.NamirnicaDodatno.Add(namirnicaDodatno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(namirnicaDodatno);
        }

        // GET: NamirnicaDodatnoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NamirnicaDodatno namirnicaDodatno = db.NamirnicaDodatno.Find(id);
            if (namirnicaDodatno == null)
            {
                return HttpNotFound();
            }
            return View(namirnicaDodatno);
        }

        // POST: NamirnicaDodatnoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Vrsta,Secer,Ugljikohidrati,Masti")] NamirnicaDodatno namirnicaDodatno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(namirnicaDodatno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(namirnicaDodatno);
        }

        // GET: NamirnicaDodatnoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NamirnicaDodatno namirnicaDodatno = db.NamirnicaDodatno.Find(id);
            if (namirnicaDodatno == null)
            {
                return HttpNotFound();
            }
            return View(namirnicaDodatno);
        }

        // POST: NamirnicaDodatnoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NamirnicaDodatno namirnicaDodatno = db.NamirnicaDodatno.Find(id);
            db.NamirnicaDodatno.Remove(namirnicaDodatno);
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
