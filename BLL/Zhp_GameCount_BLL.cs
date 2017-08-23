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
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
namespace BLL
{
    ///<summary>
    ///Zhp_GameCount_BLL
    ///Author:ZhangDeng
    ///</summary>
    public class Zhp_GameCount_BLL
    {
        ///<summary>
        ///create bll instance
        ///</summary>
        private static Zhp_GameCount_BLL instance;

        /// <summary>
        /// 私有构造函数，该类无法被实例化
        /// </summary>
        private Zhp_GameCount_BLL() { }

        /// <summary>
        /// 接口
        /// </summary>
        private static I_Zhp_GameCount_DAL idal;

        /// <summary>
        /// 线程锁
        /// </summary>
        private static object asyncLock = new object();

        /// <summary>
        /// 获取一个可用的对象
        /// </summary>
        /// <returns></returns>
        public static Zhp_GameCount_BLL getInstance()
        {

            //创建Ninject内核实例  前者为Ikernel接口 ，再用StandardKernel类作为接口的实例化
            IKernel ninjectKernel = new StandardKernel();

            //接口绑定实现接口的实例
            ninjectKernel.Bind<I_Zhp_GameCount_DAL>().To<Zhp_GameCount_DAL>();

            //获取接口实现
            I_Zhp_GameCount_DAL _idal = ninjectKernel.Get<I_Zhp_GameCount_DAL>();

            idal = _idal;

            if (instance == null)
            {
                instance = new Zhp_GameCount_BLL();
            }

            return instance;
        }

        /// <summary>
        /// 根据主键获取实体
        /// </summary>
        /// <param name="pkId">主键</param>
        /// <returns></returns>
        public Zhp_GameCount GetById(string pkId)
        {
            Zhp_GameCount model = null;
            try
            {
                model = idal.Find(Convert.ToInt32(pkId));
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Zhp_GameCount_BLL 根据主键获取实体异常,异常信息:{0}", ex.ToString()));
            }
            return model;
        }

        /// <summary>
        /// 根据条件获取实体列表
        /// </summary>
        /// <param name="exp">条件</param>
        /// <returns></returns>
        public List<Zhp_GameCount> GetList(Expression<Func<Zhp_GameCount, bool>> exp)
        {
            List<Zhp_GameCount> list = null;
            try
            {
                list = idal.FindBy(exp).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Zhp_GameCount_BLL 根据条件获取实体列表异常,异常信息:{0}", ex.ToString()));
            }
            return list;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model">待新增实体</param>
        /// <returns></returns>
        public bool Add(Zhp_GameCount model, out string msg)
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
                Logger.Error(string.Format("Zhp_GameCount_BLL 新增异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model">待删除实体</param>
        /// <returns></returns>
        public bool Remove(Zhp_GameCount model, out string msg)
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
                Logger.Error(string.Format("Zhp_GameCount_BLL 删除异常,异常信息:{0}", ex.ToString()));
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
                Logger.Error(string.Format("Zhp_GameCount_BLL 删除异常,异常信息:{0}", ex.ToString()));
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
                Logger.Error(string.Format("Zhp_GameCount_BLL 删除异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model">待编辑实体</param>
        /// <returns></returns>
        public bool Edit(Zhp_GameCount model, out string msg)
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
                Logger.Error(string.Format("Zhp_GameCount_BLL 编辑异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

        /// <summary>
        /// 按条件更新
        /// </summary>
        /// <param name="exp">更新条件</param>
        /// <param name="dic">更新值</param>
        /// <returns></returns>
        public bool Update(Expression<Func<Zhp_GameCount, bool>> exp, Dictionary<string, object> dic, out string msg)
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
                Logger.Error(string.Format("Zhp_GameCount_BLL 按条件更新异常,异常信息:{0}", ex.ToString()));
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
        public List<Zhp_GameCount> PageQuery<TKey>(int pageIndex, int pageSize, Expression<Func<Zhp_GameCount, bool>> whLamdba, Expression<Func<Zhp_GameCount, TKey>> orderByLamdba, out int recordCount, out int pageCount)
        {
            List<Zhp_GameCount> list = null;
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
                Logger.Error(string.Format("Zhp_GameCount_BLL 分页查询异常，异常信息：{0}", ex.ToString()));
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
        public DataTable PageQuery(Zhp_GameCount modle, int pageIndex, int pageSize, out int recordCount, out int pageCount)
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
                Logger.Error(string.Format("Zhp_GameCount_BLL 分页查询异常，异常信息：{0}", ex.ToString()));
            }
            return dt;
        }

        /// <summary>
        /// 游戏各种统计计数 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="type">
        /// 001-游戏轮播次数
        /// 002-游戏屏前点击量
        /// 003-游戏完成次数
        /// 004-游戏完成扫码次数
        /// 005-游戏用户数据完整数
        /// </param>
        public void Count(Zhp_GameCount model)
        {
            using (var dbcontext = new DbEntities())
            {
                dbcontext.Database.Connection.Open();
                using (var tran = dbcontext.Database.BeginTransaction())
                {
                    try
                    {


                        Expression<Func<Zhp_GameCount, bool>> exp1 = a => a.Gameid == model.Gameid;
                        Expression<Func<Zhp_GameCount, bool>> exp2 = a => a.Count_Type_Code == model.Count_Type_Code;
                        Expression<Func<Zhp_GameCount, bool>> exp = CompileLinqSearch.AndAlso(exp1, exp2);
                        Expression<Func<Zhp_GameCount, bool>> exp3 = a => a.RESERVED_1 == model.RESERVED_1;
                        #region 使用纯sql


                        //DataTable dt = null;
                        //DbParameter[] parameters;
                        //parameters = new[]{
                        //         new SqlParameter(){ ParameterName="@UserID", Value=userid }
                        //};
                        //dt = idal.SqlQueryForDataTatable("select d.Access,e.* from [SYS_ROLE_PERMISSION_RELATION] c  inner join [SYS_PERMISSION_MENU_RELATION] d on c.PermissionID=d.PermissionID inner join [SYS_MENU] e on d.MenuID=e.ID where  c.RoleId=(SELECT b.RoleID FROM [ZhpGame].[dbo].[SYS_USER_ROLE_RELATION] a  inner join [SYS_ROLE] b  on a.RoleID=b.RoleID where  a.UserID=@UserID) ", parameters);

                        #endregion
                        //Logger.Debug(string.Format("微信调试信息：{0}", " var list = idal.FindBy(CompileLinqSearch.AndAlso(exp1, exp2)).ToList();之前"));
                        //var list = idal.FindBy(CompileLinqSearch.AndAlso(exp3, exp)).ToList();

                        var list=dbcontext.Set<Zhp_GameCount>().Where(CompileLinqSearch.AndAlso(exp3, exp)).ToList();
                        //Logger.Debug(string.Format("微信调试信息：{0}", " var list = idal.FindBy(CompileLinqSearch.AndAlso(exp1, exp2)).ToList();之后"));
                        if (list != null && list.Count > 0)
                        {
                            Zhp_GameCount tmodel = list.FirstOrDefault();
                            tmodel.Count = tmodel.Count + 1;
                            //idal.Edit(tmodel);
                             dbcontext.Entry(tmodel).State = (EntityState.Modified);
                             dbcontext.SaveChanges();
                        }
                        else
                        {
                            model.Count = 1;
                            dbcontext.Entry(model).State = (EntityState.Added);
                            dbcontext.SaveChanges();
                        }
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        Logger.Error(string.Format("游戏计数异常,异常信息:{0},Gameid：【{1}】，CountType：【{2}】", ex.ToString(), model.Gameid, model.Count_Type_Code));
                    }
                }
            }

        }
    }
}