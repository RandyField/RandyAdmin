using Common.Enum;
using Common.Helper;
using DAL;
using EFModel;
using Interface;
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
    ///<summary>
    ///Zhp_GameRecord_BLL
    ///Author:ZhangDeng
    ///</summary>
    public class Zhp_GameRecord_BLL
    {
        ///<summary>
        ///create bll instance
        ///</summary>
        private static Zhp_GameRecord_BLL instance;

        /// <summary>
        /// 私有构造函数，该类无法被实例化
        /// </summary>
        private Zhp_GameRecord_BLL() { }

        /// <summary>
        /// 接口
        /// </summary>
        private static I_Zhp_GameRecord_DAL idal;

        /// <summary>
        /// 线程锁
        /// </summary>
        private static object asyncLock = new object();

        /// <summary>
        /// 获取一个可用的对象
        /// </summary>
        /// <returns></returns>
        public static Zhp_GameRecord_BLL getInstance()
        {

            //创建Ninject内核实例  前者为Ikernel接口 ，再用StandardKernel类作为接口的实例化
            IKernel ninjectKernel = new StandardKernel();

            //接口绑定实现接口的实例
            ninjectKernel.Bind<I_Zhp_GameRecord_DAL>().To<Zhp_GameRecord_DAL>();

            //获取接口实现
            I_Zhp_GameRecord_DAL _idal = ninjectKernel.Get<I_Zhp_GameRecord_DAL>();

            idal = _idal;

            if (instance == null)
            {
                instance = new Zhp_GameRecord_BLL();
            }

            return instance;
        }

        public DataTable GetGameList()
        {
            string sql = @"SELECT a.*,b.GameName,b.Description FROM [ZhpGame].[dbo].[Zhp_OnlineGame] a left join Zhp_GameConfig  b on a.GameCode=b.GameCode where b.State='1'";
            DataTable dt = idal.SqlQueryForDataTatable(sql);
            return dt;
        }

        /// <summary>
        /// 根据主键获取实体
        /// </summary>
        /// <param name="pkId">主键</param>
        /// <returns></returns>
        public Zhp_GameRecord GetById(string pkId)
        {
            Zhp_GameRecord model = null;
            try
            {
                model = idal.Find(Convert.ToInt32(pkId));
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Zhp_GameRecord_BLL 根据主键获取实体异常,异常信息:{0}", ex.ToString()));
            }
            return model;
        }

        /// <summary>
        /// 获取游戏记录排名
        /// </summary>
        /// <param name="recordtype"></param>
        /// <param name="top"></param>
        /// <returns></returns>
        public List<Zhp_GameRecord> GetSort(string recordtype, int top)
        {
            List<Zhp_GameRecord> list = null;
            string startdate = DateTime.Now.Date.ToString();
            string enddate = DateTime.Now.ToShortDateString() + " 23:59:59";
            try
            {
                DbParameter[] parameters;
                parameters = new[]{
                     new SqlParameter(){ ParameterName="@recordtype", Value=recordtype },
                     new SqlParameter(){ ParameterName="@top", Value=top },
                     new SqlParameter(){ ParameterName="@startdate", Value=startdate },
                     new SqlParameter(){ ParameterName="@enddate", Value=enddate }
                };
                string sql = @"SELECT top (@top) * FROM [ZhpGame].[dbo].[Zhp_GameRecord]  where RecordType=@recordtype and  UploadTime>=@startdate and UploadTime <=@enddate order by cast(PlayerScore as int) desc";
                list = idal.SqlQuery<Zhp_GameRecord>(sql, parameters);
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Zhp_GameRecord_BLL 根据条件获取排名实体列表异常,异常信息:{0},日期：【{1}】", ex.ToString(), startdate));
            }
            return list;
        }


        /// <summary>
        /// 获取游戏记录排名
        /// </summary>
        /// <param name="recordtype"></param>
        /// <param name="top"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<Zhp_GameRecord> GetSort(string recordtype, int top, string date)
        {
            List<Zhp_GameRecord> list = null;
            try
            {
                string startdate = date;
                string enddate = date + " 23:59:59";
                DbParameter[] parameters;
                parameters = new[]{
                    new SqlParameter(){ ParameterName="@top", Value=top },
                    new SqlParameter(){ ParameterName="@recordtype", Value=recordtype},                    
                     new SqlParameter(){ ParameterName="@startdate", Value=startdate },
                     new SqlParameter(){ ParameterName="@enddate", Value=enddate }
                };
                string sql = @"SELECT top (@top) * FROM [ZhpGame].[dbo].[Zhp_GameRecord]  where RecordType=@recordtype and UploadTime>=@startdate and UploadTime <=@enddate order by cast(PlayerScore as int) desc";
                list = idal.SqlQuery<Zhp_GameRecord>(sql, parameters);
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Zhp_GameRecord_BLL 根据条件获取排名实体列表异常,异常信息:{0},日期：【{1}】", ex.ToString(), date));
            }
            return list;
        }

        /// <summary>
        /// 是否存在二维码
        /// </summary>
        /// <param name="QRCode"></param>
        /// <returns></returns>
        public int FindByQRCode(string QRCode, out Zhp_GameRecord m)
        {
            int flag = 0;
            try
            {
                m = null;
                Expression<Func<Zhp_GameRecord, bool>> exp = a => a.QRCode == QRCode;
                if (idal.FindBy(exp).ToList().Count > 0)
                {
                    List<Zhp_GameRecord> list = null;
                    Zhp_GameRecord model = null;
                    list = idal.FindBy(exp).ToList();
                    if (list.Count > 0)
                    {
                        model = list.FirstOrDefault();
                        if (model.PlayerPhone == null)
                        {
                            flag = 1; //二维码已扫 但是没有手机号码录入
                        }
                        else
                        {
                            flag = 2; //二维码已扫 有手机号码录入
                        }

                        m = model;
                    }
                    else
                    {
                        flag = 3; //二维码未扫
                    }

                }
            }
            catch (Exception ex)
            {
                m = null;
                Logger.Error(string.Format("Zhp_GameRecord_BLL 是否存在二维码,异常信息:{0}", ex.ToString()));
            }
            return flag;
        }

        /// <summary>
        /// 根据条件获取实体列表
        /// </summary>
        /// <param name="exp">条件</param>
        /// <returns></returns>
        public List<Zhp_GameRecord> GetList(Expression<Func<Zhp_GameRecord, bool>> exp)
        {
            List<Zhp_GameRecord> list = null;
            try
            {
                list = idal.FindBy(exp).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Zhp_GameRecord_BLL 根据条件获取实体列表异常,异常信息:{0}", ex.ToString()));
            }
            return list;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model">待新增实体</param>
        /// <returns></returns>
        public bool Add(Zhp_GameRecord model, out string msg)
        {
            bool success = false;
            try
            {
                model.SaveTime = DateTime.Now;
                idal.Add(model);
                idal.Save();
                success = true;
                msg = "保存成功";
            }
            catch (Exception ex)
            {
                msg = "保存失败";
                success = false;
                Logger.Error(string.Format("Zhp_GameRecord_BLL 新增异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

        /// <summary>
        /// 保存玩家微信信息
        /// </summary>
        /// <param name="model"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool SavaGameData(Zhp_GameRecord model, Zhp_WxUserInfo wxmodel, out string msg)
        {
            bool success = false;
            using (var dbcontext = new DbEntities())
            {
                dbcontext.Database.Connection.Open();
                using (var tran = dbcontext.Database.BeginTransaction())
                {
                    try
                    {
                        if (dbcontext.Set<Zhp_WxUserInfo>().Where(a => a.openid == wxmodel.openid).ToList().Count == 0)
                        {
                            //保存用户微信信息
                            dbcontext.Set<Zhp_WxUserInfo>().Add(wxmodel);
                            dbcontext.SaveChanges();
                        }



                        //保存游戏数据
                        model.SaveTime = DateTime.Now;
                        model.Headimgurl = wxmodel.headimgurl;
                        model.PlayerNickname = wxmodel.nickname;
                        model.PlayerOpenId = wxmodel.openid;
                        dbcontext.Set<Zhp_GameRecord>().Add(model);
                        dbcontext.SaveChanges();

                        tran.Commit();
                        success = true;
                        msg = "保存成功";
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        msg = "保存失败";
                        success = false;
                        Logger.Error(string.Format("Zhp_GameRecord_BLL 保存玩家微信信息,游戏数据,异常信息:{0}", ex.ToString()));
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
        public bool Remove(Zhp_GameRecord model, out string msg)
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
                msg = "删除失败";
                success = false;
                Logger.Error(string.Format("Zhp_GameRecord_BLL 删除异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool Remove(string id, out string msg)
        {
            bool success = false;
            try
            {
                idal.Delete(Convert.ToInt32(id));
                idal.Save();
                success = true;
                msg = "删除成功";
            }
            catch (Exception ex)
            {
                msg = "删除失败";
                success = false;
                Logger.Error(string.Format("Zhp_GameRecord_BLL 删除异常,异常信息:{0}", ex.ToString()));
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
                Logger.Error(string.Format("Zhp_GameRecord_BLL 删除异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model">待编辑实体</param>
        /// <returns></returns>
        public bool Edit(Zhp_GameRecord model, out string msg)
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
                Logger.Error(string.Format("Zhp_GameRecord_BLL 编辑异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

        /// <summary>
        /// 按条件更新
        /// </summary>
        /// <param name="exp">更新条件</param>
        /// <param name="dic">更新值</param>
        /// <returns></returns>
        public bool Update(Expression<Func<Zhp_GameRecord, bool>> exp, Dictionary<string, object> dic, out string msg)
        {
            bool success = false;
            Zhp_GameRecord model = null;
            try
            {
                List<Zhp_GameRecord> list = null;
                list = idal.FindBy(exp).ToList();
                msg = "保存成功";
                if (list.Count > 0)
                {
                    model = list.FirstOrDefault();
                    if (model.PlayerPhone == null)
                    {
                        idal.update(exp, dic);
                        idal.Save();
                        success = true;


                        //提交手机号码计数 
                        Zhp_GameCount countmodel = new Zhp_GameCount();
                        countmodel.Gameid = model.Gameid;
                        countmodel.Count_Type_Code = "005";
                        Zhp_GameCount_BLL.getInstance().Count(countmodel);
                    }
                }
                else
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                msg = "保存失败";
                success = false;
                Logger.Error(string.Format("Zhp_GameRecord_BLL 按条件更新异常,异常信息:{0}", ex.ToString()));
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
        public List<Zhp_GameRecord> PageQuery<TKey>(int pageIndex, int pageSize, Expression<Func<Zhp_GameRecord, bool>> whLamdba, Expression<Func<Zhp_GameRecord, TKey>> orderByLamdba, out int recordCount, out int pageCount)
        {
            List<Zhp_GameRecord> list = null;
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
                Logger.Error(string.Format("Zhp_GameRecord_BLL 分页查询异常，异常信息：{0}", ex.ToString()));
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
        public DataTable PageQuery(Zhp_GameRecord modle, int pageIndex, int pageSize, out int recordCount, out int pageCount)
        {
            DataTable dt = new DataTable();
            try
            {
                SearchCondition condition = new SearchCondition();
                if (modle != null)
                {
                    #region 组装查询条件

                    if (!string.IsNullOrWhiteSpace(modle.PlayerNickname))
                    {
                        condition.AddCondition("a.PlayerNickname", modle.PlayerNickname, SqlOperator.Like, true);
                    }

                    #endregion
                }
                PagerInfo pager = new PagerInfo();
                #region 组装存储过程调用参数


                pager.curPage = pageIndex;
                pager.pageSize = pageSize;
                pager.isDescending = true;
                pager.fields = "a.*,c.GameName";
                pager.sortField = "a.UploadTime";
                pager.indexField = "a.ID";
                pager.where = null;
                pager.condition = condition;
                pager.tableName = "[ZhpGame].[dbo].[Zhp_GameRecord] a left join  [Zhp_OnlineGame] b on a.Gameid=b.Gameid left join [Zhp_GameConfig] c on b.GameCode= c.GameCode ";

                #endregion
                dt = idal.PageQuery(pager, out recordCount, out pageCount);
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["RecordType"] = BLL.CommonHelper.Helper.GetParamName("001", dt.Rows[i]["RecordType"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                recordCount = 0;
                pageCount = 0;
                Logger.Error(string.Format("Zhp_GameRecord_BLL 分页查询异常，异常信息：{0}", ex.ToString()));
            }
            return dt;
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="gameid"></param>
        /// <param name="recordtype"></param>
        /// <param name="sort"></param>
        /// <param name="gametime"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="recordCount"></param>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        public DataTable PageQuery(string gameid, string recordtype, string gametime, int pageIndex, int pageSize, out int recordCount, out int pageCount)
        {
            DataTable dt = new DataTable();
            try
            {
                SearchCondition condition = new SearchCondition();
                #region 组装查询条件
                if (!string.IsNullOrWhiteSpace(gameid))
                {
                    condition.AddCondition("a.Gameid", gameid, SqlOperator.Equal, true);
                }
                if (!string.IsNullOrWhiteSpace(recordtype))
                {
                    condition.AddCondition("a.RecordType", recordtype, SqlOperator.Equal, true);
                }
                if (!string.IsNullOrWhiteSpace(gametime))
                {
                    condition.AddCondition("a.UploadTime", gametime, SqlOperator.MoreThanOrEqual, true);
                }

                //if (!string.IsNullOrWhiteSpace(gameid))
                //{
                //    condition.AddCondition("a.Gameid", gameid, SqlOperator.Like, true);
                //}
                #endregion
                PagerInfo pager = new PagerInfo();
                #region 组装存储过程调用参数


                pager.curPage = pageIndex;
                pager.pageSize = pageSize;
                pager.isDescending = true;
                pager.fields = "a.*,c.GameName";
                pager.sortField = " cast(a.PlayerScore as int) desc";
                pager.indexField = "a.ID";
                pager.where = null;
                pager.condition = condition;
                pager.tableName = "[ZhpGame].[dbo].[Zhp_GameRecord] a left join  [Zhp_OnlineGame] b on a.Gameid=b.Gameid left join [Zhp_GameConfig] c on b.GameCode= c.GameCode ";

                #endregion
                dt = idal.PageQuery(pager, out recordCount, out pageCount);
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["RecordType"] = BLL.CommonHelper.Helper.GetParamName("001", dt.Rows[i]["RecordType"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                recordCount = 0;
                pageCount = 0;
                Logger.Error(string.Format("Zhp_GameRecord_BLL 分页查询异常，异常信息：{0}", ex.ToString()));
            }
            return dt;
        }
    }
}