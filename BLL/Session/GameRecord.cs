using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL.Session
{
    public class GameRecord
    {
        public static Zhp_GameRecord info
        {
            get { return HttpContext.Current.Session["arecord"] as Zhp_GameRecord; }
            set { HttpContext.Current.Session.Add("arecord", value); }
        }


        /// <summary>
        /// 设置游戏数据Session
        /// </summary>
        /// <param name="user">用户信息</param>
        public static void SetSession(Zhp_GameRecord record)
        {
            if (record == null)
            {
                info = null;
                return;
            }
            info = record;
        }

             
    }
}
