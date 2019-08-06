using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WebCatalog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HomePage()
        {
            return PartialView("HomePage");
        }

        public ActionResult List()
        {
            return PartialView("List");
        }
    }
}
