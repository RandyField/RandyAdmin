using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            ViewData["FirstMenu"] = "首页";
            //ViewData["FirstMenu"] = "首页";
            return View();
        }

    }
}
