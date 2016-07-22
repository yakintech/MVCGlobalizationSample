using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGlobalizationSample.Services
{
    public static class GlobalizationManager
    {
        public static string DefaultLanguage
        {
            get
            {
                return HttpContext.Current.Request.Cookies["LanguageInfo"].Value;
            }
        }
    }
}