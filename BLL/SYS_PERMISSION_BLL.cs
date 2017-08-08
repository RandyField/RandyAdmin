using Common.Helper;
using DAL;
using EFModel;
using Interface;
using Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SYS_PERMISSION_BLL
    {
        /// <summary>
        /// 创建bll的一个对象
        /// </summary>
        private static SYS_PERMISSION_BLL instance;


        /// <summary>
        /// 私有构造函数，改类无法被实例化
        /// </summary>
        private SYS_PERMISSION_BLL() { }

        /// <summary>
        /// 接口
        /// </summary>
        private static I_SYS_PERMISSION_DAL idal;

        /// <summary>
        /// 线程锁
        /// </summary>
        private static object asyncLock = new object();

        /// <summary>
        /// 获取一个可用的对象
        /// </summary>
        /// <returns></returns>
        public static SYS_PERMISSION_BLL getInstance()
        {

            //创建Ninject内核实例  前者为Ikernel接口 ，再用StandardKernel类作为接口的实例化
            IKernel ninjectKernel = new StandardKernel();

            //接口绑定实现接口的实例
            ninjectKernel.Bind<I_SYS_PERMISSION_DAL>().To<SYS_PERMISSION_DAL>();

            //获取接口实现
            I_SYS_PERMISSION_DAL _idal = ninjectKernel.Get<I_SYS_PERMISSION_DAL>();

            idal = _idal;

            if (instance == null)
            {
                instance = new SYS_PERMISSION_BLL();
            }

            return instance;
        }

        /// <summary>
        /// 获取权限
        /// </summary>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        public SYS_PERMISSION GetById(string permissionId)
        {
            SYS_PERMISSION model = null;
            try
            {
                model = idal.Find(Convert.ToInt32(permissionId));
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("获取权限异常,异常信息:{0}", ex.ToString()));
            }
            return model;
        }




        /// <summary>
        /// 新增权限
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool Add(List<PermissionMenuModel> list, out string msg)
        {
            bool success = false;

            using (var dbcontext = new DbEntities())
            {
                dbcontext.Database.Connection.Open();
                using (var tran = dbcontext.Database.BeginTransaction())
                {
                    try
                    {
                        SYS_PERMISSION model = new SYS_PERMISSION();
                        model.PermissionName = list[0].permissionName;
                        model.CreateTime = DateTime.Now;
                        dbcontext.Set<SYS_PERMISSION>().Add(model);
                        dbcontext.SaveChanges();
                        foreach (var item in list)
                        {
                            SYS_PERMISSION_MENU_RELATION p_mmodel = new SYS_PERMISSION_MENU_RELATION();
                            p_mmodel.MenuID = item.menuId;
                            p_mmodel.PermissionID = model.PermissionID;
                            p_mmodel.Access = GetAccess(item);
                            dbcontext.Set<SYS_PERMISSION_MENU_RELATION>().Add(p_mmodel);
                            dbcontext.SaveChanges();
                        }
                        tran.Commit();
                        msg = "保存成功";                  
                        success = true;
                    }
                    catch (Exception ex)
                    {

                        tran.Rollback();
                        success = false;
                        msg = string.Format("保存权限,事务异常，异常信息：{0}", ex.ToString());
                        Logger.Error(msg);
                    }
                }
            }

            return success;
        }

        /// <summary>
        /// 获取权限
        /// </summary>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        public List<SYS_PERMISSION_MENU_RELATION> GetPermission(int permissionId)
        {
            List<SYS_PERMISSION_MENU_RELATION> list = null;
            try
            {
                var dbcontext = new DbEntities();
                Expression<Func<SYS_PERMISSION_MENU_RELATION, bool>> exp = a => a.PermissionID == permissionId;
                var query = dbcontext.Set<SYS_PERMISSION_MENU_RELATION>().Where(exp);
                list = query.ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("获取权限列表异常,异常信息:{0}", ex.ToString()));
            }
            return list;
        }


        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int permissionId, out string msg)
        {
            bool success = false;

            using (var dbcontext = new DbEntities())
            {
                dbcontext.Database.Connection.Open();
                using (var tran = dbcontext.Database.BeginTransaction())
                {
                    try
                    {
                        SYS_PERMISSION model = dbcontext.Set<SYS_PERMISSION>().Find(permissionId);
                        dbcontext.Set<SYS_PERMISSION>().Remove(model);
                        dbcontext.SaveChanges();


                        Expression<Func<SYS_PERMISSION_MENU_RELATION, bool>> exp = a => a.PermissionID == permissionId;
                        var query = dbcontext.Set<SYS_PERMISSION_MENU_RELATION>().Where(exp);
                        dbcontext.Set<SYS_PERMISSION_MENU_RELATION>().RemoveRange(query);

                        dbcontext.SaveChanges();

                        tran.Commit();

                        msg = "删除成功";
                      
                        success = true;
                    }
                    catch (Exception ex)
                    {

                        tran.Rollback();
                        success = false;
                        msg = string.Format("删除权限,事务异常，异常信息：{0}", ex.ToString());
                        Logger.Error("删除权限,事务异常");
                    }
                }
            }

            return success;
        }

        /// <summary>
        /// 获取权限代码
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string GetAccess(PermissionMenuModel model)
        {
            string code = "";
            string query = "";
            string add = "";
            string delete = "";
            string edit = "";
            if (model.query.Trim().Equals("1"))
            {
                query = "1";
            }
            else
            {
                query = "0";
            }

            if (model.add.Trim().Equals("1"))
            {
                add = "1";
            }
            else
            {
                add = "0";
            }

            if (model.edit.Trim().Equals("1"))
            {
                edit = "1";
            }
            else
            {
                edit = "0";
            }

            if (model.delete.Trim().Equals("1"))
            {
                delete = "1";
            }
            else
            {
                delete = "0";
            }

            code = query + add + edit + delete;

            //if (model.query.Trim().Equals("1") && model.add.Trim().Equals("1")
            //    && model.delete.Trim().Equals("1") && model.edit.Trim().Equals("1"))
            //{
            //    code = "1111";
            //}

            //if (model.query.Trim().Equals("1") && model.add.Trim().Equals("0")
            //    && model.delete.Trim().Equals("0") && model.edit.Trim().Equals("0"))
            //{
            //    code = "1000";
            //}

            //if (model.query.Trim().Equals("1") && model.add.Trim().Equals("1")
            //    && model.delete.Trim().Equals("0") && model.edit.Trim().Equals("0"))
            //{
            //    code = "1100";
            //}

            //if (model.query.Trim().Equals("1") && model.add.Trim().Equals("1")
            //    && model.delete.Trim().Equals("0") && model.edit.Trim().Equals("1"))
            //{
            //    code = "1110";
            //}
            return code;
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
        public List<SYS_PERMISSION> PageQuery(int pageIndex, int pageSize, Expression<Func<SYS_PERMISSION, bool>> whLamdba, out int recordCount, out int pageCount)
        {
            List<SYS_PERMISSION> list = null;
            try
            {
                if (pageIndex == 0)
                {
                    pageIndex = 1;
                }
                Expression<Func<SYS_PERMISSION, DateTime?>> temp = a => a.CreateTime;
                list = idal.PageQuery(pageIndex, pageSize, out recordCount, out pageCount, whLamdba, temp);
            }
            catch (Exception ex)
            {
                recordCount = 0;
                pageCount = 0;
                Logger.Error(string.Format("分页获取权限列表，异常信息：{0}", ex.ToString()));
            }
            return list;
        }

        /// <summary>
        /// 获取所有权限列表
        /// </summary>
        /// <returns></returns>
        public List<SYS_PERMISSION> GetAll()
        {
            List<SYS_PERMISSION> list = null;
            try
            {
                list = idal.FindAll.ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("分页获取所有权限，异常信息：{0}", ex.ToString()));
            }
            return list;
        }
    }
}
