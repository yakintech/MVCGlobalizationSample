using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace MVCGlobalizationSample.App_Start
{
    public class LanguageConfig
    {
        public static void SetDefaultLanguage()
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["LanguageInfo"];

            if (cookie != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(cookie.Value);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(cookie.Value);
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");

                cookie = new HttpCookie("LanguageInfo");
                cookie.Value = "tr-TR";
                HttpContext.Current.Response.Cookies.Add(cookie);
            }


        }
    }
}