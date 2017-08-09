using BLL;
using Common.Helper;
using EFModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class UserInfoController : Controller
    {
        SYS_USERINFO_BLL bll = SYS_USERINFO_BLL.getInstance();

        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewData["FirstMenu"] = "系统管理";
            ViewData["SecondMenu"] = "用户管理";
            return View();
        }

        /// <summary>
        ///  分页查询
        /// </summary>
        /// <param name="param"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Search(JqueryDataTableParams param, SYS_USERINFO model)
        {
            try
            {
                //总记录数
                int iTotalRecords = 0;

                //总页数
                int pageCount = 0;

                //为操作次数加1，必须这样做 
                param.sEcho = param.sEcho + 1;

                //pageIndex
                int pageIndex = param.iDisplayStart / param.iDisplayLength + 1;

                DataTable dt = bll.PageQuery(model, pageIndex, param.iDisplayLength, out iTotalRecords, out pageCount);

                param.aaData = dt;
                param.iTotalRecords = iTotalRecords;
                string json = ConvertToJson.GetJson(param);
                return json;

                #region 调用ef分页

                //Expression<Func<Zhp_GameRecord, bool>> whLamdba = a=>1 == 1;
                //#region 查询条件组装
                ////Expression<Func<Zhp_GameRecord, bool>> whLamdba = a => a.ComputerName.Contains(model.ComputerName);
                ////Expression<Func<Zhp_GameRecord, bool>> temp = a => a.ID==model.ID;
                ////whLamdba=CompileLinqSearch.AndAlso(whLamdba, temp);
                //#endregion
                //Expression<Func<Zhp_GameRecord, DateTime?>> orderbyLamdba = a => a.UploadTime;

                ////分页查询
                //List<Zhp_GameRecord> list = bll.PageQuery(pageIndex, param.iDisplayLength, whLamdba, orderbyLamdba, out iTotalRecords, out pageCount);
                //param.iTotalRecords = iTotalRecords;
                //param.iTotalDisplayRecords = iTotalRecords;
                //param.aaData = list;

                //展示列 避免数据的冗余
                //string[] sortColums = { "ID",  "DepartName", "ChargeMan", "ChargeMan", "ChargeManPhone", "Remark" ,"DepartCode"};
                //string json = ConvertToJson.GetJson(param, sortColums);

                //不要展示列亦可，查出的数据全部转json

                #endregion


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 新增视图
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowAdd()
        {
            ViewData["FirstMenu"] = "平台管理";
            ViewData["SecondMenu"] = "用户管理";

            UserRelationInfo model = new UserRelationInfo();
            model.rolelist = SYS_ROLE_BLL.getInstance().GetAll();
            model.departlist = SYS_DEPARTMENT_BLL.getInstance().GetAll();
            return View("Add",model);
        }

        /// <summary>
        /// 新增权限
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(SYS_USERINFO model, string roleid)
        {
            string msg = "";
            jsonResult result = new jsonResult();
            bool success = false;
            result.success = success;
            result.msg = msg;
            result.success = bll.Add(model,roleid, out msg);
            return Json(result);
        }

        /// <summary>
        /// 编辑视图
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowEdit(string id)
        {
            ViewData["FirstMenu"] = "平台管理";
            ViewData["SecondMenu"] = "用户管理";
            SYS_USERINFO model = bll.GetById(id);
            return View("Edit", model);
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(SYS_USERINFO model)
        {
            string msg = "";
            jsonResult result = new jsonResult();
            bool success = bll.Edit(model, out msg);
            result.success = success;
            result.msg = msg;
            return Json(result);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(string id)
        {
            string msg = "";
            jsonResult result = new jsonResult();
            bool success = bll.Remove(id, out msg);
            result.success = success;
            result.msg = msg;
            return Json(result);
        }

    }
}
