using System;
using System.Collections.Generic;
using System.Linq;
using Archery.Models;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Archery.Data;
using Archery.Tools;
using Archery.Validators;

namespace Archery.Controllers
{
	public class ArchersController : BaseController
	{
		private ArcheryDbContext Db = new ArcheryDbContext();
		// GET: Players
		public ActionResult Subscribe()
		{
			return View();
		}
        
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Subscribe([Bind(Exclude ="ID")]Archer archer)
		{
            archer.Password = Crypter.GetMD5Password(archer.Password);    //Crypter password by me
         
            if (ModelState.IsValid)
			{			
				{
                    //archer.Password = Password.HashMD5(archer.Password); //1e Crypter password by prof
                    // archer.Password = archer.Password.HashMD5();        //2e Crypter password by prof
                    // archer.Password = archer.Password.HashMD5();
                    Db.Configuration.ValidateOnSaveEnabled = false;  //faire apres erreur EntityValidation*
                   
				Db.Archers.Add(archer);
				Display("Archer a ete enregistré");
					//Db.SaveChanges();
					
					//TempData["Message"]=TempData["Success"];
				RedirectToAction("index", "home");  //  retourer au home page, sans message					
				}	
				//ViewBag.Message = "succcess";
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