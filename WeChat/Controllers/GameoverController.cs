using BLL;
using BLL.Session;
using EFModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace WeChat.Controllers
{
    public class GameoverController : BaseController
    {
        /// <summary>
        /// 游戏结束，扫码进入
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Index(Zhp_GameRecord model)
        {
            ActionResult empty = new EmptyResult();

            //1.二维码是否已使用
            //if (!string.IsNullOrWhiteSpace(guid))
            //{
            //    if (!IsInDate(activityId, guid, 5))
            //    {
            //        return View("OutOfDate");
            //    }
            //}
            ////未传guid
            //else
            //{
            //    return View("OutOfDate");
            //}

            //2.对完成游戏后扫码次数的计数
            Zhp_GameCount countmodel = new Zhp_GameCount();
            countmodel.Gameid = model.Gameid;
            countmodel.Count_Type_Code = "004";
            Zhp_GameCount_BLL.getInstance().Count(countmodel);

            //3.把数据存入session
            GameRecord.SetSession(model);

            //4.跳转进入微信授权页面，获取用户微信信息
            string url = "";
            ResponseWXRedirect(url);
            return empty;
        }

        /// <summary>
        /// 微信跳转action
        /// </summary>
        /// <returns></returns>
        public ActionResult PostData(string code)
        {
            ActionResult empty = new EmptyResult();

            string msg = "";

            //把数据从session取出来
            Zhp_GameRecord model = GameRecord.info;

            //获取用户微信信息
            Zhp_WxUserInfo wxmodel = GetWxUserInfo(code);

            //保存数据-success
            if (Zhp_GameRecord_BLL.getInstance().SavaGameData(model, wxmodel, out msg))
            {
                ViewData["record"] = model.ID;
                ViewData["gameid"] = model.Gameid;
                return View("Index");
            }
            //保存数据-fail
            else
            {
                Common.Helper.Logger.Info("用户游戏数据，保存失败，用户数据:【" + JsonConvert.SerializeObject(model) + "】");
                ViewData["record"] = "0";
                return View("Index");
            }
        }

        /// <summary>
        /// 保存电话号码
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveData(int id,int gameid, string phone)
        {
            string msg = "";
            Expression<Func<Zhp_GameRecord, bool>> exp = a => a.ID == id;
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("PlayerPhone", phone);
            if (Zhp_GameRecord_BLL.getInstance().Update(exp, dic, out msg))
            {
                //提交手机号码计数 
                Zhp_GameCount countmodel = new Zhp_GameCount();
                countmodel.Gameid = gameid;
                countmodel.Count_Type_Code = "005";
                Zhp_GameCount_BLL.getInstance().Count(countmodel);

                //视图恭喜提交成功
                return View("Celebrate");
            }
            else
            {
                Common.Helper.Logger.Info(string .Format("用户游戏数据提交手机号码，保存失败，记录id:【{0}】",id));
                //视图恭喜提交成功
                return View("Celebrate");
            }
        }

    }
}
