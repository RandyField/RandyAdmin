using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL.Session
{
    public class AccountInfo
    {
        /// <summary>
        /// 获取用户session
        /// 超时或未登录返回null
        /// </summary>
        public static UserSession UserInfo
        {
            get { return HttpContext.Current.Session["UserInfo"] as UserSession; }
            set { HttpContext.Current.Session.Add("UserInfo", value); }
        }


        /// <summary>
        /// 设置用户Session
        /// </summary>
        /// <param name="user">用户信息</param>
        public static void SetUserSession(SYS_USERINFO user)
        {
            if (user == null)
            {
                UserInfo = null;
                return;
            }

            UserSession session = new UserSession();
            
            //设置用户信息
            session.User = user;
            
            //设置用户角色信息

            //设置用户权限信息

            //设置用户一级菜单信息

            //设置用户二级菜单信息

            //设置用户三级菜单信息
            
            UserInfo = session;
        }
    }
}
