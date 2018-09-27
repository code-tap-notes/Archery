using System;
using System.Collections.Generic;
using System.Linq;
using Archery.Models;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Archery.Data;

namespace Archery.Controllers
{
	public class ArchersController : Controller
	{
		ArcheryDbContext Db = new ArcheryDbContext();
		// GET: Players
		public ActionResult Subscribe()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Subscribe(Archer archer)
		{
			/*if(DateTime.Now.AddYears(-9) <= archer.BirthDate)
            {
                //ViewBag.Erreur = "Date de naissance invalide";
                //return View();
                ModelState.AddModelError("BirthDate", "Date de naissance invalide");
            }*/
			
			if (ModelState.IsValid)
			{
				Db.Archers.Add(archer);
				Db.SaveChanges();
				//ée maniere return RedirectToAction("index","home");
				ViewBag.Data = "succcess";
			}

			return View();        
        }
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (!disposing)
				this.Db.Dispose();
		}
	}
}