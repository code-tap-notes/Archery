using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Archery.Filters
{

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class ArcherAuthenticationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["ARCHER"] == null)
            {
                //   filterContext.Result= new RedirectToRouteResult( new System.Web.Routing.RouteValueDictionary {"controller"="authentication", "action" = "login", "area" = "backoffice" }));
                filterContext.Controller.TempData["REDIRECT"] = filterContext.HttpContext.Request.Url.AbsoluteUri;
                //Pour enregistrer Url dans TempData.
                filterContext.Result = new RedirectResult(@"\archer\login");
            };
        }
    }
}
 
 
   