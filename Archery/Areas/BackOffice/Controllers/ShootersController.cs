using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Archery.Data;
using Archery.Models;

namespace Archery.Areas.BackOffice.Controllers
{
    public class ShootersController : Controller
    {
        private ArcheryDbContext db = new ArcheryDbContext();

        // GET: BackOffice/Shooters
        public ActionResult Index()
        {
            var shooters = db.Shooters.Include(s => s.Archer).Include(s => s.Tournament).Include(s => s.Weapon);
            return View(shooters.ToList());
        }

        // GET: BackOffice/Shooters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shooter shooter = db.Shooters.Find(id);
            if (shooter == null)
            {
                return HttpNotFound();
            }
            return View(shooter);
        }

        // GET: BackOffice/Shooters/Create
        public ActionResult Create()
        {
            ViewBag.ArcherID = new SelectList(db.Archers, "ID", "LicenseNumber");
            ViewBag.TournamentID = new SelectList(db.Tournaments, "ID", "Name");
            ViewBag.WeaponID = new SelectList(db.Weapons, "ID", "Name");
            return View();
        }

        // POST: BackOffice/Shooters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TournamentID,WeaponID,ArcherID,Departure")] Shooter shooter)
        {
            if (ModelState.IsValid)
            {
                db.Shooters.Add(shooter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArcherID = new SelectList(db.Archers, "ID", "LicenseNumber", shooter.ArcherID);
            ViewBag.TournamentID = new SelectList(db.Tournaments, "ID", "Name", shooter.TournamentID);
            ViewBag.WeaponID = new SelectList(db.Weapons, "ID", "Name", shooter.WeaponID);
            return View(shooter);
        }

        // GET: BackOffice/Shooters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shooter shooter = db.Shooters.Find(id);
            if (shooter == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArcherID = new SelectList(db.Archers, "ID", "LicenseNumber", shooter.ArcherID);
            ViewBag.TournamentID = new SelectList(db.Tournaments, "ID", "Name", shooter.TournamentID);
            ViewBag.WeaponID = new SelectList(db.Weapons, "ID", "Name", shooter.WeaponID);
            return View(shooter);
        }

        // POST: BackOffice/Shooters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TournamentID,WeaponID,ArcherID,Departure")] Shooter shooter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shooter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArcherID = new SelectList(db.Archers, "ID", "LicenseNumber", shooter.ArcherID);
            ViewBag.TournamentID = new SelectList(db.Tournaments, "ID", "Name", shooter.TournamentID);
            ViewBag.WeaponID = new SelectList(db.Weapons, "ID", "Name", shooter.WeaponID);
            return View(shooter);
        }

        // GET: BackOffice/Shooters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shooter shooter = db.Shooters.Find(id);
            if (shooter == null)
            {
                return HttpNotFound();
            }
            return View(shooter);
        }

        // POST: BackOffice/Shooters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shooter shooter = db.Shooters.Find(id);
            db.Shooters.Remove(shooter);
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
