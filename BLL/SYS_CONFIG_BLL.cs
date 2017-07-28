using Common.Helper;
using DAL;
using EFModel;
using Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SYS_CONFIG_BLL
    {
        /// <summary>
        /// 创建bll的一个对象
        /// </summary>
        private static SYS_CONFIG_BLL instance;


        /// <summary>
        /// 私有构造函数，改类无法被实例化
        /// </summary>
        private SYS_CONFIG_BLL() { }

        /// <summary>
        /// 接口
        /// </summary>
        private static I_SYS_CONFIG_DAL idal;

        /// <summary>
        /// 线程锁
        /// </summary>
        private static object asyncLock = new object();

        /// <summary>
        /// 获取一个可用的对象
        /// </summary>
        /// <returns></returns>
        public static SYS_CONFIG_BLL getInstance()
        {

            //创建Ninject内核实例  前者为Ikernel接口 ，再用StandardKernel类作为接口的实例化
            IKernel ninjectKernel = new StandardKernel();

            //接口绑定实现接口的实例
            ninjectKernel.Bind<I_SYS_CONFIG_DAL>().To<SYS_CONFIG_DAL>();

            //获取接口实现
            I_SYS_CONFIG_DAL _idal = ninjectKernel.Get<I_SYS_CONFIG_DAL>();

            idal = _idal;

            if (instance == null)
            {
                instance = new SYS_CONFIG_BLL();
            }

            return instance;
        }

        /// <summary>
        /// 获取系统信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SYS_CONFIG GetSysInfo(int id)
        {
            SYS_CONFIG model = null;
            try
            {
                model = idal.Find(id);
            }
            catch (Exception ex)
            {

                Logger.Error(string.Format("获取系统信息异常，异常信息：{0}", ex.ToString()));
            }
            return model;
        }

    }
}
