using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateTemplateV5Beta.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult serviceProfile()
        {
            return View("~/Views/Shared/modules/service-profile.cshtml");
        }

        public ActionResult serviceDirectory()
        {
            return View("~/Views/Shared/modules/service-directory.cshtml");
        }
    
        public ActionResult serp()
        {
            return View("~/Views/Shared/modules/serp.cshtml");
        }
    }
}