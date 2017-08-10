using Common.Helper;
using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CommonHelper
{
    public static class Helper
    {
        /// <summary>
        /// 获取系统参数 对应名称
        /// </summary>
        /// <param name="typecode"></param>
        /// <param name="valuecode"></param>
        /// <returns></returns>
        public static string GetParamName(string typecode, string valuecode, string lang = "ch")
        {
            List<SYS_PARAM> list = (List<SYS_PARAM>)CacheHelper.GetCache("Paramlist");
            SYS_PARAM model = null;
            try
            {
                model = list.Where(p => p.TYPE_CODE == typecode).Where(p => p.PRM_Val_CODE == valuecode).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("SYS_PARAM_BLL 根据条件获取实体异常,异常信息:{0}", ex.ToString()));
            }
            if (lang == "ch")
            {
                return model.PRM_Val_NAME_CH;
            }
            else
            {
                return model.PRM_Val_NAME_EN;
            }
        }

        /// <summary>
        /// 获取参数 对应列表
        /// </summary>
        /// <param name="typecode"></param>
        /// <returns></returns>
        public static List<SYS_PARAM> GetParamName(string typecode)
        {
            List<SYS_PARAM> list = (List<SYS_PARAM>)CacheHelper.GetCache("Paramlist");           
            try
            {
                list = list.Where(p => p.TYPE_CODE == typecode).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("SYS_PARAM_BLL 根据条件获取实体异常,异常信息:{0}", ex.ToString()));
            }
            return list; 
        }
    }
}
