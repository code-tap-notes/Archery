using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Archery.Areas.BackOffice.Models;
using System.ComponentModel.DataAnnotations;
using System.Web.Http;
using Archery.Controllers;
using Archery.Data;
using Archery.Tools;

namespace Archery.Areas.BackOffice.Controllers
{
    public class AuthenticationController : BaseController
    {

        // GET: BackOffice/Authentication
        public ActionResult Login()
        {
            return View();
        }
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AuthenticationLoginViewModels model)
        { 
            if (ModelState.IsValid)
            { var hash = model.Password.HashMD5();
                var admin = db.Administrators.SingleOrDefault(
                    x => x.Mail == model.Mail && x.Password == hash);
               
            if (admin==null)
                {
                    ModelState.AddModelError("Mail", "Login/mot de pas invalide");
                    return View();
                }
                else
                { 
                return RedirectToAction("index","Dashboard",new { area = "BackOffice"});
                }
            }
            return View();
        }
    }
}