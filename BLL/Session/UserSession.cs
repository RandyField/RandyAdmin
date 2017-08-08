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
        //RBAC梳理
        //基础-整个系统的菜单
        //权限-关联菜单功能模块，包括增删改查，且一个权限包括所有菜单功能模块
        //角色-关联权限，一个角色可以对应多个权限
        //角色-权限-菜单
        //角色是一组权限集合，也是一组用户集合
        //so用户隶属的角色，角色包括的权限集，各个权限包括的菜单功能模块的限制（增删改查）
        //--所以，当一个角色存在用户，角色则不能删除，当权限被某个角色占用，则权限不能删除，

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
