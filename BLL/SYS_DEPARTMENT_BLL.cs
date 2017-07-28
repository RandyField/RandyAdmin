using Common.Helper;
using DAL;
using EFModel;
using Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SYS_DEPARTMENT_BLL
    {
        /// <summary>
        /// 创建bll的一个对象
        /// </summary>
        private static SYS_DEPARTMENT_BLL instance;


        /// <summary>
        /// 私有构造函数，改类无法被实例化
        /// </summary>
        private SYS_DEPARTMENT_BLL() { }

        /// <summary>
        /// 接口
        /// </summary>
        private static I_SYS_DEPARTMENT_DAL idal;

        /// <summary>
        /// 线程锁
        /// </summary>
        private static object asyncLock = new object();

        /// <summary>
        /// 获取一个可用的对象
        /// </summary>
        /// <returns></returns>
        public static SYS_DEPARTMENT_BLL getInstance()
        {

            //创建Ninject内核实例  前者为Ikernel接口 ，再用StandardKernel类作为接口的实例化
            IKernel ninjectKernel = new StandardKernel();

            //接口绑定实现接口的实例
            ninjectKernel.Bind<I_SYS_DEPARTMENT_DAL>().To<SYS_DEPARTMENT_DAL>();

            //获取接口实现
            I_SYS_DEPARTMENT_DAL _idal = ninjectKernel.Get<I_SYS_DEPARTMENT_DAL>();

            idal = _idal;

            if (instance == null)
            {
                instance = new SYS_DEPARTMENT_BLL();
            }

            return instance;
        }


        /// <summary>
        /// 获取一级部门列表
        /// </summary>
        /// <returns></returns>
        public List<SYS_DEPARTMENT> GetAllDepart()
        {
            List<SYS_DEPARTMENT> list = null;
            try
            {
                Expression<Func<SYS_DEPARTMENT, bool>> temp = a => 1 == 1;

                ////系统Id
                temp = a => a.Isdelete == 0;

                Expression<Func<SYS_DEPARTMENT, bool>> exp = a => 1 == 1;
                exp = a => a.ParentDepart == "0";

                exp = Common.Helper.CompileLinqSearch.AndAlso(exp, temp);
                list = idal.FindAll.OrderBy(a => a.DepartCode).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("获取部门列表，异常信息：{0}", ex.ToString()));
            }
            return list;
        }

        /// <summary>
        /// 分页获取一级部门列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="recordCount"></param>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        public List<SYS_DEPARTMENT> PageQuery(int pageIndex, int pageSize, out int recordCount, out int pageCount)
        {
            List<SYS_DEPARTMENT> list = null;
            try
            {
                if (pageIndex == 0)
                {
                    pageIndex = 1;
                }
                Expression<Func<SYS_DEPARTMENT, bool>> exp = a => 1 == 1;
                exp = a => a.ParentDepart == "0";
                Expression<Func<SYS_DEPARTMENT, int>> temp = a => a.ID;
                list = idal.PageQuery(pageIndex, pageSize, out recordCount, out pageCount, exp, temp);
            }
            catch (Exception ex)
            {
                recordCount = 0;
                pageCount = 0;
                Logger.Error(string.Format("分页获取一级部门列表，异常信息：{0}", ex.ToString()));
            }
            return list;
        }

    }
}
