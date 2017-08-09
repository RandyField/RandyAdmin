using Common.Helper;
using DAL;
using EFModel;
using Interface;
using Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SYS_MENU_BLL
    {
        /// <summary>
        /// 创建bll的一个对象
        /// </summary>
        private static SYS_MENU_BLL instance;


        /// <summary>
        /// 私有构造函数，改类无法被实例化
        /// </summary>
        private SYS_MENU_BLL() { }

        /// <summary>
        /// 接口
        /// </summary>
        private static I_SYS_MENU_DAL idal;

        /// <summary>
        /// 线程锁
        /// </summary>
        private static object asyncLock = new object();

        /// <summary>
        /// 获取一个可用的对象
        /// </summary>
        /// <returns></returns>
        public static SYS_MENU_BLL getInstance()
        {

            //创建Ninject内核实例  前者为Ikernel接口 ，再用StandardKernel类作为接口的实例化
            IKernel ninjectKernel = new StandardKernel();

            //接口绑定实现接口的实例
            ninjectKernel.Bind<I_SYS_MENU_DAL>().To<SYS_MENU_DAL>();

            //获取接口实现
            I_SYS_MENU_DAL _idal = ninjectKernel.Get<I_SYS_MENU_DAL>();

            idal = _idal;

            if (instance == null)
            {
                instance = new SYS_MENU_BLL();
            }

            return instance;
        }

        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <returns></returns>
        public List<SYS_MENU> GetMenuList(int sysId)
        {
            List<SYS_MENU> list = null;
            try
            {
                Expression<Func<SYS_MENU, bool>> exp = a => 1 == 1;

                //系统Id
                exp = a => a.BelongSys == sysId;
                list = idal.FindBy(exp).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("获取菜单列表异常，异常信息：{0}", ex.ToString()));
            }
            return list;
        }

        /// <summary>
        /// 获取1级菜单
        /// </summary>
        /// <returns></returns>
        public List<SYS_MENU> GetFirstMenu(int sysId)
        {
            List<SYS_MENU> list = null;
            try
            {
                Expression<Func<SYS_MENU, bool>> temp = a => 1 == 1;


                //系统Id
                temp = a => a.BelongSys == sysId;

                Expression<Func<SYS_MENU, bool>> exp = a => 1 == 1;
                exp = a => a.Isdelete == 0;
                list = idal.FindBy(exp).Where(a => a.MenuLevel == 1).OrderBy(a => a.Sort).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("获取1级菜单列表异常，异常信息：{0}", ex.ToString()));
            }
            return list;
        }

        /// <summary>
        /// 获取二级菜单
        /// </summary>
        /// <param name="sysId"></param>
        /// <returns></returns>
        public List<SYS_MENU> GetSecondList(int sysId)
        {
            List<SYS_MENU> list = null;
            try
            {
                Expression<Func<SYS_MENU, bool>> temp = a => 1 == 1;

                //系统Id
                temp = a => a.BelongSys == sysId;

                Expression<Func<SYS_MENU, bool>> exp = a => 1 == 1;
                exp = a => a.Isdelete == 0;

                exp = Common.Helper.CompileLinqSearch.AndAlso(exp, temp);
                list = idal.FindBy(exp).Where(a => a.MenuLevel == 2).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("获取2级菜单列表异常，异常信息：{0}", ex.ToString()));
            }
            return list;
        }

        public List<SYS_MENU> GetThirdList(int sysId)
        {
            List<SYS_MENU> list = null;
            try
            {
                Expression<Func<SYS_MENU, bool>> temp = a => 1 == 1;

                //系统Id
                temp = a => a.BelongSys == sysId;

                Expression<Func<SYS_MENU, bool>> exp = a => 1 == 1;
                exp = a => a.Isdelete == 0;

                exp = Common.Helper.CompileLinqSearch.AndAlso(exp, temp);
                list = idal.FindBy(exp).Where(a => a.MenuLevel == 3).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("获取3级菜单列表异常，异常信息：{0}", ex.ToString()));
            }
            return list;
        }

        /// <summary>
        /// 根据用户id获取菜单
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public List<Menuaccess> GetMenuByUserId(string userid)
        {
            ///****** Script for SelectTopNRows command from SSMS  ******/
            //select d.Access,e.* from [SYS_ROLE_PERMISSION_RELATION] c  inner join [SYS_PERMISSION_MENU_RELATION] d on c.PermissionID=d.PermissionID inner join [SYS_MENU] e on d.MenuID=e.ID where  c.RoleId= 
            //(SELECT b.RoleID FROM [ZhpGame].[dbo].[SYS_USER_ROLE_RELATION] a  inner join [SYS_ROLE] b  on a.RoleID=b.RoleID where  a.UserID=7) 

            List<Menuaccess> list = null;
            DataTable dt = null;
            try
            {
                DbParameter[] parameters;
                parameters = new[]{
                         new SqlParameter(){ ParameterName="@UserID", Value=userid }
                };
                dt = idal.SqlQueryForDataTatable("select d.Access,e.* from [SYS_ROLE_PERMISSION_RELATION] c  inner join [SYS_PERMISSION_MENU_RELATION] d on c.PermissionID=d.PermissionID inner join [SYS_MENU] e on d.MenuID=e.ID where  c.RoleId=(SELECT b.RoleID FROM [ZhpGame].[dbo].[SYS_USER_ROLE_RELATION] a  inner join [SYS_ROLE] b  on a.RoleID=b.RoleID where  a.UserID=@UserID) ", parameters);

                list= DatatableHelper.DataTableToList<Menuaccess>(dt,0);

            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("获取角色的所有权限组异常，异常信息：{0}", ex.ToString()));
            }

            return list;
        }
    }
}
