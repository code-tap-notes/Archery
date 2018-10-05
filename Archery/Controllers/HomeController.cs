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
    {// GET: Home
        public ActionResult Index()
        {
            ViewData["Title"] = "Accueil";
            HomeIndexViewModel model = new HomeIndexViewModel();
            model.Tournaments = db.Tournaments.Include("Weapons")
                                              .Include("Pictures")
                                              .Where(x => x.StartDate >= DateTime.Now)
                                              .OrderBy(x => x.StartDate)
                                              .Take(20);
            return View(model);
        }


        public ActionResult DetailTournament(int? id)
        {
            if (id == null)
                return HttpNotFound();
            var model = db.Tournaments.Include("Weapons")
                                             .Include("Pictures")
                                             .SingleOrDefault(x => x.ID == id);
            if (model == null)
                return HttpNotFound();
            return View(model);
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