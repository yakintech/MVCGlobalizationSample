using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCGlobalizationSample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Globalization", "change-language/{lang}", new { controller = "Base", action = "ChangeLanguage", lang = UrlParameter.Optional });

            #region HomeRoutes-TR

            routes.MapRoute("anasayfa", "{language}/anasayfa", new { controller = "Home", action = "Index", language = UrlParameter.Optional });

            routes.MapRoute("hakkimizda", "{language}/hakkimizda", new { controller = "Home", action = "About", language = UrlParameter.Optional });

            routes.MapRoute("iletisim", "{language}/iletisim", new { controller = "Home", action = "Contact", language = UrlParameter.Optional });

            #endregion


            #region HomeRoutes-TR

            routes.MapRoute("home", "{language}/home", new { controller = "Home", action = "Index", language = UrlParameter.Optional });

            routes.MapRoute("about", "{language}/about", new { controller = "Home", action = "About", language = UrlParameter.Optional });

            routes.MapRoute("contact", "{language}/contact", new { controller = "Home", action = "Contact", language = UrlParameter.Optional });

            #endregion



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
