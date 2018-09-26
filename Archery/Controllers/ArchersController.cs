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


			if (DateTime.Now > arche.BirthDate.AddYears(9))
			{
				return BadRequest(ModelState);
			}

			return View();
		}

		private ActionResult BadRequest(ModelStateDictionary modelState)
		{
			throw new NotImplementedException();
		}
	}
}