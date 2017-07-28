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
        public bool Add(SYS_USERINFO model, out string msg)
        {
            bool success = false;
            try
            {
                idal.Add(model);
                idal.Save();
                success = true;
                msg = "保存成功";
            }
            catch (Exception ex)
            {
                success = false;
                msg = "保存失败";
                Logger.Error(string.Format("SYS_USERINFO_BLL 新增异常,异常信息:{0}", ex.ToString()));
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
            try
            {
                idal.Delete(id);
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

                    //if (!string.IsNullOrWhiteSpace(modle.PlayerNickname))
                    //{
                    //    condition.AddCondition("a.PlayerNickname", modle.PlayerNickname, SqlOperator.Like, true);                        
                    //}

                    #endregion
                }
                PagerInfo pager = new PagerInfo();
                #region 组装存储过程调用参数


                //pager.curPage = pageIndex;
                //pager.pageSize = pageSize;
                //pager.isDescending = true;
                //pager.fields = "a.*,c.GameName";
                //pager.sortField = "a.UploadTime";
                //pager.indexField = "a.ID";
                //pager.where = null;
                //pager.condition = condition;
                //pager.tableName = "[ZhpGame].[dbo].[Zhp_GameRecord] a left join  [Zhp_OnlineGame] b on a.Gameid=b.Gameid left join [Zhp_GameConfig] c on b.GameCode= c.GameCode ";

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


        ///// <summary>
        ///// 新增用户
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public bool Add(SYS_USERINFO model, out string msg)
        //{
        //    bool success = false;
        //    msg = "";
        //    try
        //    {
        //        Expression<Func<SYS_USERINFO, bool>> exp = a => 1 == 1;
        //        exp = a => a.UserName.Trim() == model.UserName.Trim();
        //        if (idal.FindBy(exp).ToList().Count > 0)
        //        {
        //            msg = "用户名已存在！";
        //            success = false;
        //        }
        //        else
        //        {
        //            idal.Add(model);
        //            idal.Save();
        //            msg = "新增成功";
        //            success = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        msg = "新增异常";
        //        success = false;
        //        Logger.Error(string.Format("新增用户异常，异常信息：{0}", ex.ToString()));
        //    }
        //    return success;
        //}

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        public bool Login(string LoginName, string Password, out string msg)
        {
            bool success = false;
            msg = "";
            try
            {
                Expression<Func<SYS_USERINFO, bool>> exp = a => 1 == 1;
                exp = a => a.UserName == LoginName;
                if (idal.FindBy(exp).ToList().Count == 0)
                {
                    msg = "用户名不存在！";
                    success = false;
                }
                else
                {
                    SYS_USERINFO model = idal.FindBy(exp).ToList().FirstOrDefault();
                    if (model.Password.Trim() == Password.Trim())
                    {
                        msg = "登录成功！";

                        model.Count = model.Count + 1;
                        model.LastLoginTime = DateTime.Now;
                        //if (model.FromRole == null)
                        //{
                        //    msg += "此账号还未分配角色";
                        //}
                        //else
                        //{

                        //    SYS_ROLE_BLL bll = SYS_ROLE_BLL.getInstance();


                        //    DataTable dt = bll.GetRightGroupList(model.FromRole);
                        //    if (dt == null || dt.Rows.Count == 0)
                        //    {
                        //        msg += "角色尚未定义权限组";
                        //    }
                        //    else
                        //    {

                        //    }
                        //}

                        success = true;
                    }
                    else
                    {
                        msg = "密码错误";
                        success = false;
                    }
                }
            }
            catch (Exception ex)
            {
                msg = "登录异常";
                success = false;
                Logger.Error(string.Format("用户登录异常，异常信息：{0}", ex.ToString()));
            }
            return success;
        }

    }
}
