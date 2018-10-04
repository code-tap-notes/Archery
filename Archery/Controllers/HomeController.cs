using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Archery.Models;

namespace Archery.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
			
            return View(db.Tournaments.OrderBy(x=>x.StartDate).ToList());
           
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }   //"Weapon est nom de variable ajouter dans Create
            Tournament tournament = db.Tournaments.Include("Pictures").Include("Weapons").SingleOrDefault(x => x.ID == id);

            if (tournament == null)
            {
                return HttpNotFound();
            }
            return View(tournament);
        }

        [Route ("a-propos")]			//Pour marcher le chemin comme localhoste:(58482/a-propos
		public ActionResult About()
		{
			var info = new Info()
			{
			DevName = "Gtm",
			ContactMail="Gtm@gmail.com",
			CreatedDate= DateTime.Now			
			};			
			return View(info);
		}
    }

}