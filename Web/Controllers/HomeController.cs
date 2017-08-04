using BLL;
using Common.Helper;
using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Attribute;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [AuthorityFilter]
        public ActionResult Index()
        {
//            for (int x = 63; x < 10000; x = x + 63)
//            {
//                if (x % 2 == 1 &&
//x % 4 == 1 &&
//x % 5 == 4 &&
//x % 6 == 3 &&
//x % 7 == 0 &&
//x % 8 == 1 &&
//x % 9 == 0)
//                {
//                    int i=0;
//                }



            //}
            //#region 菜单信息+用户信息+session
            //SYS_MENU_BLL bll = SYS_MENU_BLL.getInstance();
            //SYS_CONFIG_BLL sbll = SYS_CONFIG_BLL.getInstance();
            //List<SYS_MENU> FirstMenuList = bll.GetFirstMenu(1);
            //List<SYS_MENU> SecondMenuList = bll.GetSecondList(1);
            //List<SYS_MENU> ThirdMenuList = bll.GetThirdList(1);
            //SYS_CONFIG sysmodel = sbll.GetSysInfo(1);
            //CacheHelper.SetCache("FirstMenu", FirstMenuList);
            //CacheHelper.SetCache("SecondMenu", SecondMenuList);
            //CacheHelper.SetCache("ThirdMenu", ThirdMenuList);
            //CacheHelper.SetCache("SysInfo", sysmodel);
            //#endregion
            //return View();
            //if (CacheHelper.GetCache("FirstMenu") != null)
            //{
                return View();
            //}
            //else
            //{
            //    return RedirectToRoute(new { controller = "Login", action = "Index" });
            //}
            //加载菜单


        }

    }
}
