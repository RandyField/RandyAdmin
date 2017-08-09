using BLL;
using Common;
using Common.Enum;
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
        /// 首次登录
        /// </summary>
        /// <returns></returns>
        public ActionResult FirstLogin()
        {
            if (CacheHelper.GetCache("Username") == null)
            {
                return View("Index");
            }
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
            LoginStatus status = cbll.Login(username, pwd, out msg);
            jsonResult result = new jsonResult();
            if (status == LoginStatus.Success)
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

                result.success = true;
            }
            else if (status == LoginStatus.FirstLogin)
            {
                CacheHelper.SetCache("Username", username);
                //跳转至修改密码的默认页面
                //ViewData["username"] = username;
                result.success = false;

            }

            result.msg = msg;
            result.state = status;
            return Json(result);


            //return JavaScript("location.href='/Home/Index'");

            //http post不支持转发，需在客户端进行处理
            //return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Resetpwd(string pwd1, string pwd2)
        {
            //缓存中获取用户名
            string username = CacheHelper.GetCache("Username").ToString();

            //缓存清理
            CacheHelper.RemoveAllCache("Username");

            jsonResult result = new jsonResult();
            string msg = "";
            result.success = cbll.Resetpwd(username, pwd1, out msg);
            result.msg = msg;
            return Json(result);
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
