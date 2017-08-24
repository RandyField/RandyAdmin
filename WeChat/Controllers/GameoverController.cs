using BLL;
using BLL.CommonHelper;
using BLL.Session;
using Common.Helper;
using EFModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace WeChat.Controllers
{
    public class GameoverController : BaseController
    {
        public readonly string _wxurl = ConfigurationManager.AppSettings["wxurl"];
        public readonly string _queryurl = ConfigurationManager.AppSettings["queryurl"];
        Zhp_GameRecord_BLL bll = Zhp_GameRecord_BLL.getInstance();

        /// <summary>
        /// 查询分数
        /// </summary>
        /// <returns></returns>
        public ActionResult Query(string code)
        {
            try
            {
                //获取用户微信信息
                Zhp_WxUserInfo wxmodel = GetWxUserInfo(code);

                Zhp_GameRecord model = null;
                List<Zhp_GameRecord> list = null;
                string rank = "";
                if (wxmodel.openid != null)
                {
                    //获取该同学最好的成绩
                    model = bll.GetByOpenid(wxmodel.openid);
                    if (model != null)
                    {
                        //获取前五名成绩
                        list = bll.GetByRecordtype(model.RecordType);

                        //获取该同学最好成绩的名次
                        rank = bll.GetSocreRank(model.ID.ToString(), model.RecordType);
                    }
                    else
                    {
                        return View("NoData");
                    }
                }
                ViewData["rank"] = rank;
                Logger.Error(string.Format("rank:{0}", rank));
                ViewData["nickname"] = wxmodel.nickname;
                Logger.Error(string.Format("nickname:{0}", wxmodel.nickname));
                ViewData["score"] = model.PlayerScore;
                Logger.Error(string.Format("nickname:{0}", model.PlayerScore));
                ViewData["headimg"] = wxmodel.headimgurl;
                Logger.Error(string.Format("nickname:{0}", wxmodel.headimgurl));
                ViewData["type"] = Helper.GetParaName("001", model.RecordType);
                Logger.Error(string.Format("type:{0}", ViewData["type"].ToString()));

                return View(list);
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("查询分数,异常信息:{0}", ex.ToString()));
                Logger.Error("Error");
                return View("Error");
            }
        }

        /// <summary>
        /// 查询分数入口
        /// </summary>
        /// <returns></returns>
        public ActionResult MyGameScore()
        {
            ActionResult empty = new EmptyResult();
            try
            {
                string url = _queryurl;
                ResponseWXRedirect(url);
                return empty;
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("查询分数入口异常,异常信息:{0}", ex.ToString()));
                return View("Error");
            }

        }

        /// <summary>
        /// 游戏结束，扫码进入
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Index(Zhp_GameRecord model)
        {
            //1.对完成游戏后扫码次数的计数
            //Zhp_GameCount countmodel = new Zhp_GameCount();
            //countmodel.Gameid = model.Gameid;
            //countmodel.Count_Type_Code = "004";
            //Zhp_GameCount_BLL.getInstance().Count(countmodel);

            ActionResult empty = new EmptyResult();

            if (model.PlayerScore == null)
            {
                //return View("Query");
                return View("Error");
                //return View("YourScore"); 
            }


            //1.对完成游戏后扫码次数的计数
            Zhp_GameCount countmodel = new Zhp_GameCount();
            countmodel.Gameid = model.Gameid;
            countmodel.Count_Type_Code = "004";
            countmodel.RESERVED_1 = model.ComputerName;
            Zhp_GameCount_BLL.getInstance().Count(countmodel);


            //2.跳转进入微信授权页面，获取用户微信信息
            string url = _wxurl;
            string urlparm = string.Format("?Gameid={0}&PlayerScore={1}&ComputerName={2}&RecordType={3}&QRCode={4}&UploadTime={5}", model.Gameid, model.PlayerScore,
                model.ComputerName, model.RecordType, model.QRCode, model.UploadTime);
            url = _wxurl + urlparm;

            //Logger.Error(string.Format("微信跳转url：{0}", url));
            ResponseWXRedirect(url);
            return empty;
        }

        /// <summary>
        /// 微信跳转action
        /// </summary>
        /// <returns></returns>
        public ActionResult PostData(Zhp_GameRecord model, string code)
        {
            ActionResult empty = new EmptyResult();

            string msg = "";

            //二维码判断
            if (model.QRCode != null)
            {
                Zhp_GameRecord m = null;
                int state = bll.FindByQRCode(model.QRCode, out m);

                if (state == 1)
                {
                    ViewData["recordid"] = m.ID;
                    ViewData["gameid"] = m.Gameid;
                    return View("Index");
                }

                if (state == 2)
                {
                    return View("Upload");
                }
            }
            else
            {
                return View("Upload");
            }

            //获取用户微信信息
            Zhp_WxUserInfo wxmodel = GetWxUserInfo(code);

            //保存数据-success
            if (Zhp_GameRecord_BLL.getInstance().SavaGameData(model, wxmodel, out msg))
            {
                ViewData["recordid"] = model.ID;
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

        public ActionResult HasUpload()
        {
            return View("Upload");
        }

        public ActionResult GetScore(string rank,string score)
        {
            ViewData["Rank"] = rank;
            ViewData["Score"] = score;
            return View("YourScore");
        }

        /// <summary>
        /// 保存电话号码
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveData(int recordid, int gameid, string phone)
        {
            string rank = "";
            Zhp_GameRecord updatemodel = null;
            Expression<Func<Zhp_GameRecord, bool>> exp = a => a.ID == recordid;
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("PlayerPhone", phone);
            jsonResult result = new jsonResult();
            if (Zhp_GameRecord_BLL.getInstance().Update(exp, dic, out updatemodel))
            {
                //获取该同学最好成绩的名次
                rank = bll.GetSocreRank(recordid.ToString(), updatemodel.RecordType);
            }
            else
            {
                Common.Helper.Logger.Info(string.Format("用户游戏数据提交手机号码，保存失败，记录id:【{0}】,手机号码：【{1}】", recordid, phone));
            }
            //ViewData["Rank"] = rank;
            //ViewData["Score"] = updatemodel.PlayerScore;
            var score = new
            {
                success=true,
                rank = rank,
                score = updatemodel.PlayerScore
            };
            return Json(score);
        }
    }
}
