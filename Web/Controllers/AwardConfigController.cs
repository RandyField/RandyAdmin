using BLL;
using Common.Helper;
using EFModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class AwardConfigController : Controller
    {
        Zhp_AwardsLimited_BLL bll = Zhp_AwardsLimited_BLL.getInstance();

        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewData["FirstMenu"] = "业务管理";
            ViewData["SecondMenu"] = "智汇屏游戏";
            ViewData["ThirdMenu"] = "游戏奖品发放配置";
            return View();
        }

        ///// <summary>
        ///// 获取可用游戏列表
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //public ActionResult GetGameList()
        //{
        //    DataTable dt = bll.GetGameList();
        //    SelectHelper model = new SelectHelper();
        //    model.text = "请选择游戏";
        //    model.value = "";

        //    List<SelectHelper> list = new List<SelectHelper>();
        //    list.Add(model);

        //    foreach (DataRow item in dt.Rows)
        //    {
        //        list.Add(new SelectHelper()
        //        {
        //            text = item["Gamename"].ToString().Trim(),
        //            value = item["Gameid"].ToString().Trim()
        //        });
        //    }

        //    return Json(list, JsonRequestBehavior.AllowGet);
        //}

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="param"></param>
        /// <param name="permissionName"></param>
        /// <returns></returns>
        public string Search(JqueryDataTableParams param, string GameName,string GameCode,string AwardName,string AwardCode)
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

                DataTable dt = bll.PageQuery(GameName,GameCode,AwardName,AwardCode, pageIndex, param.iDisplayLength, out iTotalRecords, out pageCount);

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
            ViewData["FirstMenu"] = "业务管理";
            ViewData["SecondMenu"] = "智汇屏游戏";
            ViewData["ThirdMenu"] = "游戏奖品发放配置";
            return View("Add");
        }

        /// <summary>
        /// 新增权限
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(Zhp_AwardsLimited model)
        {           
            string msg = "";
            jsonResult result = new jsonResult();
            bool success = false;
            success = bll.Add(model, out msg);
            result.success = success;
            result.msg = msg;
            return Json(result);
        }

        /// <summary>
        /// 编辑视图
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowEdit(string id)
        {
            ViewData["FirstMenu"] = "业务管理";
            ViewData["SecondMenu"] = "智汇屏游戏";
            ViewData["ThirdMenu"] = "游戏奖品发放配置";
            Zhp_AwardsLimited model = bll.GetById(id);
            return View("Edit", model);
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(Zhp_AwardsLimited model)
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
