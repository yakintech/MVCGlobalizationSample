using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGlobalizationSample.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index(string language)
        {
            //language değeri dbden menuleri vs çekerken yardımcı olacak aynı zamanda routeda da görünmesi gerekiyor 
            return View();
        }

        public ActionResult About(string language)
        {
            return View();
        }

        public ActionResult Contact(string language)
        {
            return View();
        }
    }
}