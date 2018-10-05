using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Archery
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.MapMvcAttributeRoutes();    //ajouter cette ligne pour ajouter un chemin a-propos

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { Controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
			routes.MapRoute(                               //Pour marcher le chemin comme localhoste:(58482/a-propos
				name: "AboutRoute",
				url: "a-propos",
				defaults: new {Controller= "Home",action ="About"}
		    );
            routes.MapRoute(
               name: "DetailTournament",
               url: "{name}/{id}",
               defaults: new { Controller = "Home", action = "DetailTournament" }
           );
            routes.MapRoute(
               name: "CreateShooter",
               url: "{name}/{id}",
               defaults: new { Controller = "Shooter", action = "Create" }
           );

        }
    }
}
