using BLL;
using Common.Helper;
using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        SYS_USERINFO_BLL cbll = SYS_USERINFO_BLL.getInstance();

        /// <summary>
        /// 加载登录页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(string username, string pwd)
        {

            string msg = "";
            bool success = cbll.Login(username, pwd, out msg);
            if (success)
            {
                #region 菜单信息+用户信息+session
                SYS_MENU_BLL bll = SYS_MENU_BLL.getInstance();
                SYS_CONFIG_BLL sbll = SYS_CONFIG_BLL.getInstance();
                List<SYS_MENU> FirstMenuList = bll.GetFirstMenu(1);
                List<SYS_MENU> SecondMenuList = bll.GetSecondList(1);
                List<SYS_MENU> ThirdMenuList = bll.GetThirdList(1);
                SYS_CONFIG sysmodel = sbll.GetSysInfo(1);
                CacheHelper.SetCache("FirstMenu", FirstMenuList);
                CacheHelper.SetCache("SecondMenu", SecondMenuList);
                CacheHelper.SetCache("ThirdMenu", ThirdMenuList);
                CacheHelper.SetCache("SysInfo", sysmodel);
                CacheHelper.SetCache("Username", username);
                #endregion
            }

            jsonResult result = new jsonResult();
            result.success = success;
            result.msg = msg;
            //return JavaScript("location.href='/Home/Index'");
            return Json(result);
            //http post不支持转发，需在客户端进行处理
            //return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            #region 清理缓存 跳转页面
            CacheHelper.RemoveAllCache();
            #endregion
            return View("Index");
        }

    }
}
