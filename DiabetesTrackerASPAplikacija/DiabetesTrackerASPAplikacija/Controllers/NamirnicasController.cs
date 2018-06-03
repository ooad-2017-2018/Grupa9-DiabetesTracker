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
    public class NamirnicasController : Controller
    {
        private DiabetesTrackerASPAplikacijaContext db = new DiabetesTrackerASPAplikacijaContext();

        // GET: Namirnicas
        public ActionResult Index()
        {
            var namirnica = db.Namirnica.Include(n => n.Hrana);
            return View(namirnica.ToList());
        }

        // GET: Namirnicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Namirnica namirnica = db.Namirnica.Find(id);
            if (namirnica == null)
            {
                return HttpNotFound();
            }
            return View(namirnica);
        }

        // GET: Namirnicas/Create
        public ActionResult Create()
        {
            ViewBag.HranaId = new SelectList(db.DnevniUnos, "Id", "Id");
            return View();
        }

        // POST: Namirnicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Vrsta,Secer,Ugljikohidrati,Masti,HranaId")] Namirnica namirnica)
        {
            if (ModelState.IsValid)
            {
                db.Namirnica.Add(namirnica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HranaId = new SelectList(db.DnevniUnos, "Id", "Id", namirnica.HranaId);
            return View(namirnica);
        }

        // GET: Namirnicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Namirnica namirnica = db.Namirnica.Find(id);
            if (namirnica == null)
            {
                return HttpNotFound();
            }
            ViewBag.HranaId = new SelectList(db.DnevniUnos, "Id", "Id", namirnica.HranaId);
            return View(namirnica);
        }

        // POST: Namirnicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Vrsta,Secer,Ugljikohidrati,Masti,HranaId")] Namirnica namirnica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(namirnica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HranaId = new SelectList(db.DnevniUnos, "Id", "Id", namirnica.HranaId);
            return View(namirnica);
        }

        // GET: Namirnicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Namirnica namirnica = db.Namirnica.Find(id);
            if (namirnica == null)
            {
                return HttpNotFound();
            }
            return View(namirnica);
        }

        // POST: Namirnicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Namirnica namirnica = db.Namirnica.Find(id);
            db.Namirnica.Remove(namirnica);
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
