using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using EFModel;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data;
using Common.Helper;

namespace Interface
{
    public interface I_BASE_Interface<U>
        where U : class,new()
    {
        #region Interface

        DbEntities Getdbcontext();

        #region Find

        /// <summary>
        /// IQueryable 获取所有
        /// </summary>
        /// <returns></returns>
        IQueryable<U> FindAll { get; }

        /// <summary>
        /// IQueryable 获取所有
        /// </summary>
        /// <returns></returns>
        IQueryable<U> IQueryable();

        /// <summary>
        /// 根据主键查找 注意主键类型需要跟数据库匹配
        /// </summary>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        U Find(params object[] keyValues);

        /// <summary>
        /// 按条件查询
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        IQueryable<U> FindBy(Expression<Func<U, bool>> exp);

        #endregion

        #region Inser Add

        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="entity"></param>
        void Add(U entity);

        /// <summary>
        /// 批量插入实体
        /// </summary>
        /// <param name="list"></param>
        void BulkInsert(List<U> list);

        #endregion

        #region Delete

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity"></param>
        void Delete(U entity);

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="pKey">主键</param>
        void Delete(params object[] pKey);

        /// <summary>
        /// 按条件批量删除
        /// </summary>
        /// <param name="exp"></param>
        void Delete(Expression<Func<U, bool>> exp);

        /// <summary>
        /// 全删除，慎用
        /// </summary>
        void DeleteAll();

        #endregion

        #region Update

        /// <summary>
        /// 编辑实体
        /// </summary>
        /// <param name="entity"></param>
        void Edit(U entity);


        /// <summary>
        /// 未使用
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="insertExpression"></param>
        void Upsert(U entity, Func<U, bool> insertExpression);

        /// <summary>
        /// 按条件更新实体
        /// </summary>
        /// <param name="where"></param>
        /// <param name="dic"></param>
        void update(Expression<Func<U, bool>> where, Dictionary<string, object> dic);

        #endregion

        #region Save
        /// <summary>
        /// ef保存
        /// </summary>
        void Save();
        #endregion

        #region 分页查询

        /// <summary>
        ///EF分页查询 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="recordTotal"></param>
        /// <param name="pageCount"></param>
        /// <param name="whLamdba"></param>
        /// <param name="orderBy"></param>
        /// <param name="isDescending"></param>
        /// <returns></returns>
        List<U> PageQuery<TKey>(int pageIndex, int pageSize, out int recordTotal, out int pageCount, Expression<Func<U, bool>> whLamdba, Expression<Func<U, TKey>> orderBy, bool isDescending = true);

        /// <summary>
        /// EF分页查询
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        IEnumerable<U> getSearchListByPage<TKey>(Expression<Func<U, bool>> where, Expression<Func<U, TKey>> orderBy, int pageSize, int pageIndex);

        /// <summary>
        /// 分页查询-调用存储过程P_PagerQuery
        /// </summary>
        /// <param name="info"></param>
        /// <param name="total"></param>
        /// <param name="pagecount"></param>
        /// <returns></returns>
        DataTable PageQuery(PagerInfo info, out int total, out int pagecount);

        /// <summary>
        /// 分页查询-调用存储过程P_PagerQuery
        /// </summary>
        /// <param name="tblName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="fields"></param>
        /// <param name="indexfield"></param>
        /// <param name="sort"></param>
        /// <param name="where"></param>
        /// <param name="total"></param>
        /// <param name="pagecount"></param>
        /// <returns></returns>
        DataTable PageQuery(string tblName, int pageIndex, int pageSize, string fields, string indexfield, string sort, string where, out int total, out int pagecount);

        /// <summary>
        /// 分页查询-调用存储过程P_PagerQuery
        /// </summary>
        /// <param name="info"></param>
        /// <param name="total"></param>
        /// <param name="pagecount"></param>
        /// <returns></returns>
        List<U> PageQueryList(string tblName, int pageNo, int pageSize, string fileds, string indexfield,
   string sort, string where, out int total, out int pagecount);

        #endregion

        #region ef执行sql

        DataTable SqlQueryForDataTatable(string sql);

        #endregion

        #region Dispose

        /// <summary>
        /// 释放数据库上下文
        /// </summary>
        void Dispose();

        #endregion

        #endregion
    }
}
