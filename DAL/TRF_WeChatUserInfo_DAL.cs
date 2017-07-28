using EFModel;
using Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    //public class TRF_WeChatUserInfo_DAL : BaseDAL<TRF_WeChatUserInfo>, I_TRF_WeChatUserInfo_DAL
    //{
        ///// <summary>
        ///// 联表分页
        ///// </summary>
        ///// <param name="pageIndex"></param>
        ///// <param name="pageSize"></param>
        ///// <param name="recordTotal"></param>
        ///// <param name="pageCount"></param>
        ///// <param name="whLamdba"></param>
        ///// <returns></returns>
        //public List<LCDSearchModel> SearchPageing(int pageIndex, int pageSize, out int recordTotal, out int pageCount, Expression<Func<LCDSearchModel, bool>> whLamdba)
        //{
        //    try
        //    {
        //        IQueryable<TRF_WeChatUserInfo> TRF_WeChatUserInfo = dbcontext.TRF_WeChatUserInfo;
        //        IQueryable<TRP_AwardReceive> SOCKETLIB_CONFIG = dbcontext.TRP_AwardReceive;
        //        var list = TRF_WeChatUserInfo.Join(SOCKETLIB_CONFIG, a => a.openid, b => b.OpenId, (a, b) => new LCDSearchModel
        //        {
        //            //id = a.recordid,
        //            //cityName = b.cityname,
        //            //lineName = b.linename,
        //            //stationName = b.stationname,
        //            //position = b.position,
        //            //pcName = b.computername,
        //            //brokenTime = a.producetime,
        //            //errorCode = a.errornum,
        //            //screenType = b.projectname
        //        }).Where(whLamdba);

        //        //list = list.Where(p => p.screenType.Trim() == "LCD拼接屏");
        //        recordTotal = list.Count();
        //        var result = list.OrderByDescending(t => t.brokenTime).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

        //        result.ForEach(p => p.brokenTimeStr = Convert.ToDateTime(p.brokenTime).ToString("yyyy-MM-dd HH:mm:ss"));
        //        //result.ForEach(p => p.errorInfo = ParseErrorCode.GetErrorInfo(p.errorCode));

        //        pageCount = Convert.ToInt32(Math.Ceiling((double)recordTotal / (double)pageSize));
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    //}
}
