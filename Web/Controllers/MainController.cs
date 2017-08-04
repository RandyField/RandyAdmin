using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Attribute;

namespace Web.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/
        [AuthorityFilter]
        public ActionResult Index()
        {
            ViewData["FirstMenu"] = "首页";
            //ViewData["FirstMenu"] = "首页";
            return View();
        }

    }
}
