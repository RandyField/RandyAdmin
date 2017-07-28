using Common.Helper;
using DAL;
using EFModel;
using Interface;
using Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL
{
    public class TRF_WeChatUserInfo_BLL
    {
        ///// <summary>
        ///// 创建bll的一个对象
        ///// </summary>
        //private static TRF_WeChatUserInfo_BLL instance ;


        ///// <summary>
        ///// 私有构造函数，改类无法被实例化
        ///// </summary>
        //private TRF_WeChatUserInfo_BLL() { }

        ///// <summary>
        ///// 接口
        ///// </summary>
        //private static I_TRF_WeChatUserInfo_DAL idal;

        ///// <summary>
        ///// 线程锁
        ///// </summary>
        //private static object asyncLock = new object();

        ///// <summary>
        ///// 获取一个可用的对象
        ///// </summary>
        ///// <returns></returns>
        //public static TRF_WeChatUserInfo_BLL getInstance() 
        //{
          
        //    //创建Ninject内核实例  前者为Ikernel接口 ，再用StandardKernel类作为接口的实例化
        //    IKernel ninjectKernel = new StandardKernel();

        //    //接口绑定实现接口的实例
        //    ninjectKernel.Bind<I_TRF_WeChatUserInfo_DAL>().To<TRF_WeChatUserInfo_DAL>();

        //    //获取接口实现
        //    I_TRF_WeChatUserInfo_DAL _idal = ninjectKernel.Get<I_TRF_WeChatUserInfo_DAL>();

        //    idal = _idal;

        //    if (instance==null)
        //    {
        //        instance = new TRF_WeChatUserInfo_BLL();
        //    }

        //    return instance;
        //}

        ///// <summary>
        ///// 是否存在此微信用户
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public bool isExist(string openId)
        //{
        //    bool flag = false;
        //    try
        //    {
        //        Expression<Func<TRF_WeChatUserInfo, bool>> exp = a => 1 == 1;
        //        if (!string.IsNullOrWhiteSpace(openId))
        //        {
        //            exp = a => a.openid == openId;
        //            var list = idal.FindBy(exp).ToList();
        //            if (list.Count > 0)
        //            {
        //                flag = true;
        //            }
        //        }          
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Error(string.Format("判断是否存在此微信用户信息异常，异常信息：{0}",ex.ToString()));
        //    }

        //    return flag;
        //}

        ///// <summary>
        ///// 获取所有微信用户
        ///// </summary>
        ///// <returns></returns>
        //public List<TRF_WeChatUserInfo> getAll()
        //{
        //    List<TRF_WeChatUserInfo> list = null;
        //    try
        //    {
        //        Expression<Func<TRF_WeChatUserInfo, bool>> exp = a => 1 == 1;
        //        exp = a => a.sex == null;
        //        list = idal.FindBy(exp).ToList();
        //    }
        //    catch (Exception ex)
        //    {

        //        Logger.Error("获取所有微信用户信息异常，异常信息为:"+ex.ToString());
        //    }
           
        //    return list;
        //}

    }
}
