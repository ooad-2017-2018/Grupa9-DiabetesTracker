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
    [Authorize(Roles = "Admin")]
    public class NamirnicaHranaPoveznicasController : Controller
    {
        private DiabetesTrackerASPAplikacijaContext db = new DiabetesTrackerASPAplikacijaContext();

        // GET: NamirnicaHranaPoveznicas
        public ActionResult Index()
        {
            return View(db.NamirnicaHranaPoveznica.ToList());
        }

        // GET: NamirnicaHranaPoveznicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NamirnicaHranaPoveznica namirnicaHranaPoveznica = db.NamirnicaHranaPoveznica.Find(id);
            if (namirnicaHranaPoveznica == null)
            {
                return HttpNotFound();
            }
            return View(namirnicaHranaPoveznica);
        }

        // GET: NamirnicaHranaPoveznicas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NamirnicaHranaPoveznicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NamirnicaId,HranaId")] NamirnicaHranaPoveznica namirnicaHranaPoveznica)
        {
            if (ModelState.IsValid)
            {
                db.NamirnicaHranaPoveznica.Add(namirnicaHranaPoveznica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(namirnicaHranaPoveznica);
        }

        // GET: NamirnicaHranaPoveznicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NamirnicaHranaPoveznica namirnicaHranaPoveznica = db.NamirnicaHranaPoveznica.Find(id);
            if (namirnicaHranaPoveznica == null)
            {
                return HttpNotFound();
            }
            return View(namirnicaHranaPoveznica);
        }

        // POST: NamirnicaHranaPoveznicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NamirnicaId,HranaId")] NamirnicaHranaPoveznica namirnicaHranaPoveznica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(namirnicaHranaPoveznica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(namirnicaHranaPoveznica);
        }

        // GET: NamirnicaHranaPoveznicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NamirnicaHranaPoveznica namirnicaHranaPoveznica = db.NamirnicaHranaPoveznica.Find(id);
            if (namirnicaHranaPoveznica == null)
            {
                return HttpNotFound();
            }
            return View(namirnicaHranaPoveznica);
        }

        // POST: NamirnicaHranaPoveznicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NamirnicaHranaPoveznica namirnicaHranaPoveznica = db.NamirnicaHranaPoveznica.Find(id);
            db.NamirnicaHranaPoveznica.Remove(namirnicaHranaPoveznica);
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
