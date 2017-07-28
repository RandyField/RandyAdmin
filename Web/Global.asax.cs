using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Web
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["OnlineTotal"] = 0;//记录当前已登录用户总数

            //DataDictionary.InitBusinessParam();
            //DataDictionary.InitSysParam();
        }


        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnlineTotal"] = (int)Application["OnlineTotal"] - 1;
            Application.UnLock();

        }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute(), 2);
            //filters.Add(new CustomExceptionAttribute(), 1);//自定义全局标签
        }
    }
}