using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Session
{
    public class UserSession
    {
        public SYS_USERINFO User { get; set; }

        /// <summary>
        /// 用户角色信息
        /// </summary>
        public SYS_ROLE Role { get; set; }



        ///// <summary>
        ///// 用户角色 与 权限组 关联信息
        ///// </summary>
        //public SYS_ROLE_RIGHT_RELATION RoleRelationRight { get; set; }

        ///// <summary>
        ///// 用户的菜单、页面操作权限
        ///// </summary>
        //public SYS_RIGHT_PAGE RightPage { get; set; }

        /// <summary>
        /// 获取用户一级菜单
        /// </summary>
        public List<SYS_MENU> FirstMenuList { get; set; }

        /// <summary>
        /// 获取用户二级菜单
        /// </summary>
        public List<SYS_MENU> SecondMenuList { get; set; }

        /// <summary>
        /// 获取用户三级菜单
        /// </summary>
        public List<SYS_MENU> ThirdMenuList { get; set; }

        /// <summary>
        /// 系统信息
        /// </summary>
        public SYS_CONFIG SysInfo { get; set; }
    }
}
