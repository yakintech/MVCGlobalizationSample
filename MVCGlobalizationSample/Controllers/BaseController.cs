using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using MVCGlobalizationSample.Services;

namespace MVCGlobalizationSample.Controllers
{
    public class BaseController : Controller
    {
        public ActionResult ChangeLanguage(string lang = "tr-TR")
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

            HttpCookie cookie = new HttpCookie("LanguageInfo");
            cookie.Value = lang;
            Response.Cookies.Add(cookie);

            return Redirect("/" + lang + "/" + MVCGlobalizationSample.Resource.SiteLanguage.Home.Slugify());
        }
    }
}