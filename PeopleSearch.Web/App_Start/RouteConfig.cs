using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PeopleSearch.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "GlobalVariablesScript",
               url: "GlobalVariablesScript",
               defaults: new { controller = "PeopleSearch", action = "GlobalVariablesScript" }
           );
                     

            // Moved from global.asax following guidance to place more specific routing ahead of generic area routing but before default route: see https://blogs.msdn.microsoft.com/webdev/2013/10/17/attribute-routing-in-asp-net-mvc-5/
            AreaRegistration.RegisterAllAreas();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "PeopleSearch", action = "PeopleSearch", id = UrlParameter.Optional }
            );
        }
    }
}
