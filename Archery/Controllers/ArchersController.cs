using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Archery.Models;
using System.Data;
using System.Net;

namespace Archery.Controllers
{
	public class ArchersController : Controller
	{
		// GET: Players
		public ActionResult Subscribe()
		{
			return View();
		}

		[HttpPost]      //Recouperer l'information de Html.
		public ActionResult Subscribe(Archer arche)
		{
			if (ModelState.IsValid)
			{

			}
			return View();
		}


		/*	if (DateTime.Now <= arche.BirthDate.AddYears(9))
			{
				//ViewBag.Erreur = "Vous n'avez pas plus que 9 ans";
				//return View();  use other way
				ModelState.AddModelError("Birthday", "Il fault avoir au moins 9 ans");
			}

			return View(); 
		}
		*/
		private ActionResult BadRequest(ModelStateDictionary modelState)
		{
			throw new NotImplementedException();
		}
	}
}