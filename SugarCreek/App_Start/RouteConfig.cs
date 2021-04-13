using SugarCreek.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SugarCreek
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "logout",
            url: "Account/Logoff",
            defaults: new { controller = "Account", action = "Logoff", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "login",
                url: "Account/Login",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "DefaultAccount",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    constraints: new
            //    {
            //        serverRoute = new ServerRouteConstraint(url => url.PathAndQuery.StartsWith("/Account/", StringComparison.InvariantCultureIgnoreCase))
            //    }
            //);

            routes.MapRoute(
                name: "Angular",
                url: "{*url}",
                defaults: new { controller = "Home", action = "Index" }
                );
        }
    }
}
