using Common;
using Common.Enum;
using Common.Helper;
using DAL;
using EFModel;
using Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL
{
    public class SYS_USERINFO_BLL
    {
        /// <summary>
        /// 创建bll的一个对象
        /// </summary>
        private static SYS_USERINFO_BLL instance;


        /// <summary>
        /// 私有构造函数，改类无法被实例化
        /// </summary>
        private SYS_USERINFO_BLL() { }

        /// <summary>
        /// 接口
        /// </summary>
        private static I_SYS_USERINFO_DAL idal;

        /// <summary>
        /// 线程锁
        /// </summary>
        private static object asyncLock = new object();

        /// <summary>
        /// 获取一个可用的对象
        /// </summary>
        /// <returns></returns>
        public static SYS_USERINFO_BLL getInstance()
        {

            //创建Ninject内核实例  前者为Ikernel接口 ，再用StandardKernel类作为接口的实例化
            IKernel ninjectKernel = new StandardKernel();

            //接口绑定实现接口的实例
            ninjectKernel.Bind<I_SYS_USERINFO_DAL>().To<SYS_USERINFO_DAL>();

            //获取接口实现
            I_SYS_USERINFO_DAL _idal = ninjectKernel.Get<I_SYS_USERINFO_DAL>();

            idal = _idal;

            if (instance == null)
            {
                instance = new SYS_USERINFO_BLL();
            }

            return instance;
        }

        /// <summary>
        /// 根据主键获取实体
        /// </summary>
        /// <param name="pkId">主键</param>
        /// <returns></returns>
        public SYS_USERINFO GetById(string pkId)
        {
            SYS_USERINFO model = null;
            try
            {
                model = idal.Find(Convert.ToInt32(pkId));
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("SYS_USERINFO_BLL 根据主键获取实体异常,异常信息:{0}", ex.ToString()));
            }
            return model;
        }

        /// <summary>
        /// 根据条件获取实体列表
        /// </summary>
        /// <param name="exp">条件</param>
        /// <returns></returns>
        public List<SYS_USERINFO> GetList(Expression<Func<SYS_USERINFO, bool>> exp)
        {
            List<SYS_USERINFO> list = null;
            try
            {
                list = idal.FindBy(exp).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("SYS_USERINFO_BLL 根据条件获取实体列表异常,异常信息:{0}", ex.ToString()));
            }
            return list;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model">待新增实体</param>
        /// <returns></returns>
        public bool Add(SYS_USERINFO model, string roleid, out string msg)
        {
            bool success = false;
            using (var dbcontext = new DbEntities())
            {
                dbcontext.Database.Connection.Open();
                using (var tran = dbcontext.Database.BeginTransaction())
                {
                    try
                    {
                        model.Count = 0;
                        model.State = 0;
                        model.Isdelete = 0;
                        model.CreateTime = DateTime.Now;
                        model.LastLoginTime = DateTime.Now;
                        dbcontext.Set<SYS_USERINFO>().Add(model);
                        dbcontext.SaveChanges();

                        SYS_USER_ROLE_RELATION rm = new SYS_USER_ROLE_RELATION();
                        rm.RoleID = Convert.ToInt32(roleid);
                        rm.UserID = model.UserID;
                        dbcontext.Set<SYS_USER_ROLE_RELATION>().Add(rm);
                        dbcontext.SaveChanges();

                        tran.Commit();
                        msg = "保存成功";
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        success = false;
                        msg = "保存失败";
                        Logger.Error(string.Format("SYS_USERINFO_BLL 新增异常,异常信息:{0}", ex.ToString()));
                    }
                }
            }
            return success;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model">待删除实体</param>
        /// <returns></returns>
        public bool Remove(SYS_USERINFO model, out string msg)
        {
            bool success = false;
            try
            {
                idal.Delete(model);
                idal.Save();
                success = true;
                msg = "删除成功";
            }
            catch (Exception ex)
            {
                success = false;
                msg = "删除失败";
                Logger.Error(string.Format("SYS_USERINFO_BLL 删除异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

        /// <summary>
        /// 删除-注意主键要与数据库类型相同
        /// </summary>
        /// <param name="id"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool Remove(string id, out string msg)
        {
            bool success = false;
            using (var dbcontext = new DbEntities())
            {
                dbcontext.Database.Connection.Open();
                using (var tran = dbcontext.Database.BeginTransaction())
                {
                    try
                    {
                        int iid = Convert.ToInt32(id);
                        SYS_USERINFO model = dbcontext.Set<SYS_USERINFO>().Find(iid);
                        dbcontext.Set<SYS_USERINFO>().Remove(model);
                        dbcontext.SaveChanges();


                        Expression<Func<SYS_USER_ROLE_RELATION, bool>> exp = a => a.UserID == iid;
                        var query = dbcontext.Set<SYS_USER_ROLE_RELATION>().Where(exp);
                        dbcontext.Set<SYS_USER_ROLE_RELATION>().RemoveRange(query);

                        dbcontext.SaveChanges();

                        tran.Commit();

                        msg = "删除成功";

                        success = true;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        msg = "删除失败";
                        success = false;
                        Logger.Error(string.Format("SYS_USERINFO_BLL 删除异常,异常信息:{0}", ex.ToString()));
                    }
                }
            }
            return success;
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <returns></returns>
        public bool BulkRemove(Expression<Func<Zhp_GameRecord, bool>> exp, out string msg)
        {
            bool success = false;
            try
            {
                idal.Delete(exp);
                idal.Save();
                success = true;
                msg = "删除成功";
            }
            catch (Exception ex)
            {
                msg = "删除失败";
                success = false;
                Logger.Error(string.Format("SYS_USERINFO_BLL 删除异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model">待编辑实体</param>
        /// <returns></returns>
        public bool Edit(SYS_USERINFO model, out string msg)
        {
            bool success = false;
            try
            {
                idal.Edit(model);
                idal.Save();
                success = true;
                msg = "保存成功";
            }
            catch (Exception ex)
            {
                msg = "保存失败";
                success = false;
                Logger.Error(string.Format("SYS_USERINFO_BLL 编辑异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

        /// <summary>
        /// 按条件更新
        /// </summary>
        /// <param name="exp">更新条件</param>
        /// <param name="dic">更新值</param>
        /// <returns></returns>
        public bool Update(Expression<Func<SYS_USERINFO, bool>> exp, Dictionary<string, object> dic, out string msg)
        {
            bool success = false;
            try
            {
                idal.update(exp, dic);
                idal.Save();
                success = true;
                msg = "保存成功";
            }
            catch (Exception ex)
            {
                msg = "保存失败";
                success = false;
                Logger.Error(string.Format("SYS_USERINFO_BLL 按条件更新异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool Resetpwd(string username, string pwd, out string msg)
        {
            bool success = false;
            try
            {
                string password = SecureHelper.MD5(SecureHelper.MD5(pwd) + SysParam.SecretKey);
                Expression<Func<SYS_USERINFO, bool>> exp = a => a.UserName == username;
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("Password", password);
                dic.Add("State", 1);
                idal.update(exp, dic);
                idal.Save();
                success = true;
                msg = "保存成功";
            }
            catch (Exception ex)
            {
                msg = "保存失败";
                success = false;
                Logger.Error(string.Format("SYS_USERINFO_BLL 按条件更新异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="whLamdba"></param>
        /// <param name="recordCount"></param>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        public List<SYS_USERINFO> PageQuery<TKey>(int pageIndex, int pageSize, Expression<Func<SYS_USERINFO, bool>> whLamdba, Expression<Func<SYS_USERINFO, TKey>> orderByLamdba, out int recordCount, out int pageCount)
        {
            List<SYS_USERINFO> list = null;
            try
            {
                if (pageIndex == 0)
                {
                    pageIndex = 1;
                }
                list = idal.PageQuery(pageIndex, pageSize, out recordCount, out pageCount, whLamdba, orderByLamdba);
            }
            catch (Exception ex)
            {
                recordCount = 0;
                pageCount = 0;
                Logger.Error(string.Format("SYS_USERINFO_BLL 分页查询异常，异常信息：{0}", ex.ToString()));
            }
            return list;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="modle"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="recordCount"></param>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        public DataTable PageQuery(SYS_USERINFO modle, int pageIndex, int pageSize, out int recordCount, out int pageCount)
        {
            DataTable dt = new DataTable();
            try
            {
                SearchCondition condition = new SearchCondition();
                if (modle != null)
                {
                    #region 组装查询条件

                    if (!string.IsNullOrWhiteSpace(modle.UserName))
                    {
                        condition.AddCondition("b.UserName", modle.UserName, SqlOperator.Like, true);
                    }
                    #endregion
                }
                PagerInfo pager = new PagerInfo();
                #region 组装存储过程调用参数


                pager.curPage = pageIndex;
                pager.pageSize = pageSize;
                pager.isDescending = true;
                pager.fields = "b.*,c.RoleName,c.RoleID";
                pager.sortField = "b.UserID";
                pager.indexField = "b.UserID";
                pager.where = null;
                pager.condition = condition;
                pager.tableName = "[ZhpGame].[dbo].[SYS_USER_ROLE_RELATION]  a inner join [SYS_USERINFO] b on a.UserID=b.UserID inner join [SYS_ROLE] c on c.RoleID=a.RoleID";

                #endregion
                dt = idal.PageQuery(pager, out recordCount, out pageCount);
            }
            catch (Exception ex)
            {
                recordCount = 0;
                pageCount = 0;
                Logger.Error(string.Format("SYS_USERINFO_BLL 分页查询异常，异常信息：{0}", ex.ToString()));
            }
            return dt;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        public LoginStatus Login(string LoginName, string Password, out string msg)
        {
            LoginStatus status = LoginStatus.Other;
            msg = "";
            try
            {
                Expression<Func<SYS_USERINFO, bool>> exp = a => 1 == 1;
                exp = a => a.UserName.ToUpper() == LoginName.ToUpper();
                if (idal.FindBy(exp).ToList().Count == 0)
                {
                    msg = "用户名不存在！";
                    status = LoginStatus.Error;
                }
                else
                {
                    SYS_USERINFO model = idal.FindBy(exp).ToList().FirstOrDefault();

                    //首次登录
                    if (model.State == 0)
                    {
                        status = LoginStatus.FirstLogin;
                        if (Password != "888888")
                        {
                            msg = "密码错误";
                            status = LoginStatus.Error;
                        }
                    }

                    else if (model.Password.Trim() == SecureHelper.MD5(SecureHelper.MD5(Password) + SysParam.SecretKey).Trim())
                    {
                        msg = "登录成功！";

                        //更新用户登录信息
                        model.Count = model.Count + 1;
                        model.LastLoginTime = DateTime.Now;
                        idal.Edit(model);
                        idal.Save();

                        HttpContext.Current.Application.Lock();

                        //增加一个在线人数
                        HttpContext.Current.Application["OnlineTotal"] = (int)HttpContext.Current.Application["OnlineTotal"] + 1;

                        //解锁
                        HttpContext.Current.Application.UnLock();

                        status = LoginStatus.Success;
                    }
                    else
                    {
                        msg = "密码错误";
                        status = LoginStatus.Error;
                    }
                }
            }
            catch (Exception ex)
            {
                msg = "登录异常";
                status = LoginStatus.Error;
                Logger.Error(string.Format("用户登录异常，异常信息：{0}", ex.ToString()));
            }
            return status;
        }


        /// <summary>
        /// 校验用户是否单点登录
        /// </summary>
        /// <returns></returns>
        private void IsSSO(string loginName, bool isSSO = false)
        {
            ///判断是否是单点登录 默认不判断单点登录
            if (isSSO && SysParam.SessionDictionary != null)
            {
                //校验登录用户中是否包含当前登录用户
                if (SysParam.SessionDictionary.ContainsKey(loginName))
                {
                    //获取之前客户端SessionID值
                    string value = SysParam.SessionDictionary[loginName];

                    //此客户端sessionid值与当前客户端sessionid 不同
                    if (value != HttpContext.Current.Session.SessionID)
                    {
                        Dictionary<string, string> Dictionary = SysParam.SessionDictionary;
                        Dictionary[loginName] = HttpContext.Current.Session.SessionID;
                        SysParam.SessionDictionary = Dictionary;
                    }
                }
                else
                {
                    //客户端登录名，sessionid，键值对存入字典
                    SysParam.SessionDictionary.Add(loginName, HttpContext.Current.Session.SessionID);
                }
            }
        }

    }
}
