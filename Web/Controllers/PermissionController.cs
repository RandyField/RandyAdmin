using BLL;
using Common.Helper;
using EFModel;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class PermissionController : BaseController
    {

        SYS_PERMISSION_BLL bll = SYS_PERMISSION_BLL.getInstance();

        /// <summary>
        /// 加载页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewData["FirstMenu"] = "平台管理";
            ViewData["SecondMenu"] = "权限管理";
            return View();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowAdd()
        {
            ViewData["FirstMenu"] = "平台管理";
            ViewData["SecondMenu"] = "权限管理";
            return View("Add");
        }

        /// <summary>
        /// 新增权限
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(List<PermissionMenuModel> list)
        {
            string msg = "";
            jsonResult result = new jsonResult();
            bool success = bll.Add(list, out msg);
            result.success = success;
            result.msg = msg;
            return Json(result);
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowEdit(string permissionId)
        {
            ViewData["FirstMenu"] = "平台管理";
            ViewData["SecondMenu"] = "权限管理";
            List<SYS_PERMISSION_MENU_RELATION> list = bll.GetPermission(Convert.ToInt32(permissionId));
            SYS_PERMISSION model = bll.GetById(permissionId);
            return View("Edit", list);
        }

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(string permissionId)
        {
            string msg = "";
            jsonResult result = new jsonResult();

            bool success = bll.Delete(Convert.ToInt32(permissionId), out msg);
            result.success = success;
            result.msg = msg;
            return Json(result);
        }

        public string Search(jqDtParam<SYS_PERMISSION> param, string permissionName)
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


             
                //查询条件
                Expression<Func<SYS_PERMISSION, bool>> whLamdba = a => a.PermissionName.Contains(permissionName);

                //分页查询
                List<SYS_PERMISSION> list = bll.PageQuery(pageIndex, param.iDisplayLength, whLamdba, out iTotalRecords, out pageCount);
                param.iTotalRecords = iTotalRecords;
                param.iTotalDisplayRecords = iTotalRecords;
                param.aaData = list;

                //展示列 避免数据的冗余
                //string[] sortColums = { "ID",  "DepartName", "ChargeMan", "ChargeMan", "ChargeManPhone", "Remark" ,"DepartCode"};
                //string json = ConvertToJson.GetJson(param, sortColums);

                //不要展示列亦可，查出的数据全部转json
                string json = ConvertToJson.GetJson(param);
                return json;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
