using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DiabetesTrackerASPAplikacija.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace DiabetesTrackerASPAplikacija.Controllers
{
    [Authorize]
    public class DoktorsController : Controller
    {
        
        private DiabetesTrackerASPAplikacijaContext db = new DiabetesTrackerASPAplikacijaContext();

        public object SecurityModule { get; private set; }

        // GET: Doktors
        public ActionResult Index()
        {
            return View(db.Doktor.ToList());
        }

        // GET: Doktors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doktor doktor = db.Doktor.Find(id);
            if (doktor == null)
            {
                return HttpNotFound();
            }
            return View(doktor);
        }

        // GET: Doktors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doktors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Spol,Ime,Prezime,Username,Password,PotvrdaPassworda,EMail,JMBG1,Spol1,DatumRodjenja")] Doktor doktor)
        {
            if (ModelState.IsValid)
            {
                var store = new UserStore<ApplicationUser>(new ApplicationDbContext());
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = doktor.EMail, Email=doktor.EMail };

                manager.Create(user, doktor.Password);

                
                //manager.AddToRole(user.Id, "Doktor");



                var dajIdDoktora = db.Database.SqlQuery<string>("SELECT Id FROM dbo.AspNetUsers WHERE " + "Email = '" + User.Identity.Name + "'").ToList();
                if (dajIdDoktora.Count > 0)    
                db.Doktor.Add(doktor);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            return View(doktor);
        }        

        // GET: Doktors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doktor doktor = db.Doktor.Find(id);
            if (doktor == null)
            {
                return HttpNotFound();
            }
            return View(doktor);
        }

        // POST: Doktors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Spol,Ime,Prezime,Username,Password,PotvrdaPassworda,EMail,JMBG1,Spol1,DatumRodjenja")] Doktor doktor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doktor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doktor);
        }

        // GET: Doktors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doktor doktor = db.Doktor.Find(id);
            if (doktor == null)
            {
                return HttpNotFound();
            }
            return View(doktor);
        }

        // POST: Doktors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doktor doktor = db.Doktor.Find(id);
            db.Doktor.Remove(doktor);
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
