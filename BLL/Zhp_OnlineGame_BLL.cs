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
namespace BLL  
{
	///<summary>
	 	///Zhp_OnlineGame_BLL
		///Author:ZhangDeng
	///</summary>
	public class Zhp_OnlineGame_BLL
	{	
		///<summary>
		///create bll instance
		///</summary>
		private static Zhp_OnlineGame_BLL instance;
		
		/// <summary>
        /// 私有构造函数，该类无法被实例化
        /// </summary>
        private Zhp_OnlineGame_BLL() { }
        
         /// <summary>
        /// 接口
        /// </summary>
        private static I_Zhp_OnlineGame_DAL idal;

        /// <summary>
        /// 线程锁
        /// </summary>
        private static object asyncLock = new object();

        /// <summary>
        /// 获取一个可用的对象
        /// </summary>
        /// <returns></returns>
        public static Zhp_OnlineGame_BLL getInstance()
        {

            //创建Ninject内核实例  前者为Ikernel接口 ，再用StandardKernel类作为接口的实例化
            IKernel ninjectKernel = new StandardKernel();

            //接口绑定实现接口的实例
            ninjectKernel.Bind<I_Zhp_OnlineGame_DAL>().To<Zhp_OnlineGame_DAL>();

            //获取接口实现
            I_Zhp_OnlineGame_DAL _idal = ninjectKernel.Get<I_Zhp_OnlineGame_DAL>();

            idal = _idal;

            if (instance == null)
            {
                instance = new Zhp_OnlineGame_BLL();
            }

            return instance;
        }

        /// <summary>
        /// 获取游戏列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetGameList() 
        {
            string sql = @"SELECT * FROM  Zhp_GameConfig  where State='1'";
            DataTable dt = idal.SqlQueryForDataTatable(sql);
            return dt;
        }
        
        /// <summary>
        /// 根据主键获取实体
        /// </summary>
        /// <param name="pkId">主键</param>
        /// <returns></returns>
        public Zhp_OnlineGame GetById(string pkId)
        {
            Zhp_OnlineGame model = null;
            try
            {
                model = idal.Find(Convert.ToInt32(pkId));
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Zhp_OnlineGame_BLL 根据主键获取实体异常,异常信息:{0}", ex.ToString()));
            }
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recordid"></param>
        /// <returns></returns>
        public DataTable GetOnlineList(string gameid)
        {
            string sql = @" SELECT ID FROM  Zhp_OnlineGame a inner join Zhp_GameRecord b on a.Gameid=b.Gameid  where a.Gameid='" + gameid + "'";
            DataTable dt = idal.SqlQueryForDataTatable(sql);
            return dt;
        }
        
         /// <summary>
        /// 根据条件获取实体列表
        /// </summary>
        /// <param name="exp">条件</param>
        /// <returns></returns>
         public List<Zhp_OnlineGame> GetList(Expression<Func<Zhp_OnlineGame, bool>> exp)
        {
            List<Zhp_OnlineGame> list = null;
            try
            {
                list = idal.FindBy(exp).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Zhp_OnlineGame_BLL 根据条件获取实体列表异常,异常信息:{0}", ex.ToString()));
            }
            return list;
        }
        
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model">待新增实体</param>
        /// <returns></returns>
        public bool Add(Zhp_OnlineGame model,out string msg)
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
                Logger.Error(string.Format("Zhp_OnlineGame_BLL 新增异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }

		/// <summary>
        /// 删除
        /// </summary>
        /// <param name="model">待删除实体</param>
        /// <returns></returns>
		public bool Remove(Zhp_OnlineGame model,out string msg)
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
                Logger.Error(string.Format("Zhp_OnlineGame_BLL 删除异常,异常信息:{0}", ex.ToString()));
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
                DataTable dt = GetOnlineList(id);
                if (dt!=null && dt.Rows.Count>0)
                {
                    success = false;
                    msg = "当前游戏存在记录，不允许删除";
                }
                else
                {
                    idal.Delete(Convert.ToInt32(id));
                    idal.Save();
                    success = true;
                    msg = "删除成功";                  
                }
               
            }
            catch (Exception ex)
            {
                msg = "删除失败";
                success = false;
                Logger.Error(string.Format("Zhp_OnlineGame_BLL 删除异常,异常信息:{0}", ex.ToString()));
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
                Logger.Error(string.Format("Zhp_OnlineGame_BLL 删除异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }
        
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model">待编辑实体</param>
        /// <returns></returns>
        public bool Edit(Zhp_OnlineGame model, out string msg)
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
                Logger.Error(string.Format("Zhp_OnlineGame_BLL 编辑异常,异常信息:{0}", ex.ToString()));
            }
            return success;
        }
        
        /// <summary>
        /// 按条件更新
        /// </summary>
        /// <param name="exp">更新条件</param>
        /// <param name="dic">更新值</param>
        /// <returns></returns>
        public bool Update(Expression<Func<Zhp_OnlineGame, bool>> exp, Dictionary<string, object> dic, out string msg)
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
                Logger.Error(string.Format("Zhp_OnlineGame_BLL 按条件更新异常,异常信息:{0}", ex.ToString()));
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
        public List<Zhp_OnlineGame> PageQuery<TKey>(int pageIndex, int pageSize, Expression<Func<Zhp_OnlineGame, bool>> whLamdba,Expression<Func<Zhp_OnlineGame, TKey>> orderByLamdba, out int recordCount, out int pageCount)
        {
            List<Zhp_OnlineGame> list = null;
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
                Logger.Error(string.Format("Zhp_OnlineGame_BLL 分页查询异常，异常信息：{0}", ex.ToString()));
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
        public DataTable PageQuery(Zhp_OnlineGame modle,int pageIndex, int pageSize, out int recordCount, out int pageCount)
        {
            DataTable dt = new DataTable();
            try
            {
                SearchCondition condition = new SearchCondition();
                if (modle!=null)
                {
                    #region 组装查询条件

                    if (!string.IsNullOrWhiteSpace(modle.GameCode))
                    {
                        condition.AddCondition("a.GameCode", modle.GameCode, SqlOperator.Like, true);
                    }
                    if (modle.GameStartTime!=null)
                    {
                        condition.AddCondition("a.GameStartTime", modle.GameStartTime, SqlOperator.MoreThanOrEqual, true);
                    }
                    if (modle.GameEndTime!=null)
                    {
                        condition.AddCondition("a.GameEndTime", modle.GameEndTime, SqlOperator.LessThanOrEqual, true);
                    }
                    #endregion
                }
                PagerInfo pager = new PagerInfo();
                #region 组装存储过程调用参数


                pager.curPage = pageIndex;
                pager.pageSize = pageSize;
                pager.isDescending = true;
                pager.fields = "a.*,b.GameName";
                pager.sortField = "a.Gameid";
                pager.indexField = "a.Gameid";
                pager.where = null;
                pager.condition = condition;
                pager.tableName = "[ZhpGame].[dbo].[Zhp_OnlineGame] a left join [Zhp_GameConfig] b on a.GameCode=b.GameCode";

                #endregion
                dt = idal.PageQuery(pager, out recordCount, out pageCount);
            }
            catch (Exception ex)
            {
                recordCount = 0;
                pageCount = 0;
                Logger.Error(string.Format("Zhp_OnlineGame_BLL 分页查询异常，异常信息：{0}", ex.ToString()));
            }
            return dt;
        }
	}
}