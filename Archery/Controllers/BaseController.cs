﻿using Archery.Data;
using Archery.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Archery.Controllers
{
	public abstract class BaseController : Controller
	{
        /// <summary>
        /// Affiche un message dans le layout success ou erreur avec ou sans redirection
        /// </summary>
        /// <param name="text">le text a afficher</param>
        /// <param name="type">le type de message</param>
        protected ArcheryDbContext db = new ArcheryDbContext(); 
		protected void Display(string text, MessageType type = MessageType.Success)
		{
			var m = new Message(type, text);
			TempData["MESSAGE"] = m;
		}
	}
}