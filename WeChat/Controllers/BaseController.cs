using Common;
using EFModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeChat.Controllers
{
    public class BaseController : Controller
    {
        public readonly string _appId = ConfigurationManager.AppSettings["AppId"];
        public readonly string _appsecret = ConfigurationManager.AppSettings["Appsecret"];
        public readonly string _key = ConfigurationManager.AppSettings["encryption"];
       

        /// <summary>
        /// 跳转页面
        /// </summary>
        /// <param name="tburl"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool RedirectPage(Dictionary<string, string> tburl, string key)
        {
            bool flag = false;
            try
            {
                Response.Clear();//这里是关键，清除在返回前已经设置好的标头信息，这样后面的跳转才不会报错
                Response.BufferOutput = true;//设置输出缓冲 
                if (!Response.IsRequestBeingRedirected) //在跳转之前做判断,防止重复
                {
                    Response.Redirect(tburl[key]);
                    flag = true;
                    Response.Close();
                }
            }
            catch (Exception ex)
            {
                Common.Helper.Logger.Info(string.Format("BaseContrller,跳转异常信息：{0},key：{1},url：{2}", ex.ToString(), key, tburl[key]));
            }
            return flag;
        }




        /// <summary>
        /// 重定向至微信授权方式重定向
        /// </summary>
        /// <param name="activityId"></param>
        /// <param name="type"></param>
        public void ResponseWXRedirect(string url)
        {
            Response.Clear();//这里是关键，清除在返回前已经设置好的标头信息，这样后面的跳转才不会报错
            Response.BufferOutput = true;//设置输出缓冲 
            if (!Response.IsRequestBeingRedirected) //在跳转之前做判断,防止重复
            {
                Response.Redirect(string.Format("https://open.weixin.qq.com/connect/oauth2/authorize?appid=wx6953deeefe22a83b&redirect_uri={0}&response_type=code&scope=snsapi_userinfo&state=STATE#wechat_redirect",
                                        System.Web.HttpUtility.UrlEncode(url, System.Text.Encoding.UTF8)), true);
                //Response.Close();
                try { Response.Flush(); }
                catch { }
                finally
                {
                    System.Web.HttpContext.Current.ApplicationInstance.CompleteRequest();
                } 
            }

           
        }

        /// <summary>
        /// 红包-获取微信用户信息
        /// </summary>
        /// <param name="code">微信端code</param>
        /// <returns></returns>
        public Zhp_WxUserInfo GetWxUserInfo(string code)
        {
            Zhp_WxUserInfo model = null;

            try
            {
                HttpHelper httpHelper = new HttpHelper();

                //获取tokenjson
                string tokenJson = httpHelper.HttpGet(String.Format("https://api.weixin.qq.com/sns/oauth2/access_token?appid={0}&secret={1}&code={2}&grant_type=authorization_code", _appId, _appsecret, code), "");
                JObject tokenJsonObj = null;
                if (!string.IsNullOrWhiteSpace(tokenJson))
                {
                    tokenJsonObj = JObject.Parse(tokenJson);
                    if (tokenJsonObj != null)
                    {
                        string userInfoJson = "";
                        //获取用户信息json
                        userInfoJson = httpHelper.HttpGet(string.Format("https://api.weixin.qq.com/sns/userinfo?access_token={0}&openid={1}&lang=zh_CN", tokenJsonObj["access_token"], tokenJsonObj["openid"]), "");
                        //Common.Helper.Logger.Info(string.Format("微信json,{0}", userInfoJson));
                        if (!string.IsNullOrWhiteSpace(userInfoJson))
                        {
                            //json反序列化为实体
                            model = JsonConvert.DeserializeObject<Zhp_WxUserInfo>(userInfoJson);

                            if (model.openid == null)
                            {
                                model = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Common.Helper.Logger.Info(string.Format("BaseContrller,获取用户微信信息异常，异常信息：{0}", ex.ToString()));
            }
            return model;
        }   
    }
}
