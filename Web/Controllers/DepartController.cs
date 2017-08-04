using BLL;
using Common.Helper;
using EFModel;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using Web.Attribute;
using Web.Models;

namespace Web.Controllers
{
    public class DepartController : jQDatatableController
    {
        //
        // GET: /Depart/
        SYS_DEPARTMENT_BLL bll = SYS_DEPARTMENT_BLL.getInstance();

        [AuthorityFilter]
        public ActionResult Index()
        {
            ViewData["FirstMenu"] = "系统管理";
            ViewData["SecondMenu"] = "部门管理";
            return View();
        }

        public string Search(jqDtParam<SYS_DEPARTMENT> param, string departName)
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

                //分页查询
                List<SYS_DEPARTMENT> list = bll.PageQuery(pageIndex, param.iDisplayLength, out iTotalRecords, out pageCount);
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
                throw;
            }
        }
    }
}
