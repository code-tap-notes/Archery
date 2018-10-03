using Archery.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Archery.Areas.BackOffice.Controllers
{               [AuthenticationAttribute]
    public class DashboardController : Controller
    {
        // GET: BackOffice/Dashboard
        public ActionResult Index()
        {
            if(Session["ADMINISTRATOR"]==null) return RedirectToAction ("login","autothentication");
            //au lieu utiliser if sur chaque methode on utilise Authorize
            return View();
        }

    }
}