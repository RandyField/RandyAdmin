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
        /// 获取系统参数 对应名称-从缓存中读取
        /// </summary>
        /// <param name="typecode"></param>
        /// <param name="valuecode"></param>
        /// <returns></returns>
        public static string GetParamName(string typecode, string valuecode, string lang = "ch")
        {
            string name = "";
            try
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
                    name= model.PRM_Val_NAME_CH;
                }
                else
                {
                    name= model.PRM_Val_NAME_EN;
                }

            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("获取参数名称异常,异常信息:{0},typecode={1},valuecode={2}", ex.ToString(), typecode, valuecode));
            }
            return name;
        }

        /// <summary>
        /// 实时查询
        /// </summary>
        /// <param name="typecode"></param>
        /// <param name="valuecode"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        public static string GetParaName(string typecode, string valuecode, string lang = "ch")
        {
            string name = "";
            try
            {
                List<SYS_PARAM> list = SYS_PARAM_BLL.getInstance().GetAll();
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
                    name = model.PRM_Val_NAME_CH;
                }
                else
                {
                    name = model.PRM_Val_NAME_EN;
                }

            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("获取参数名称异常,异常信息:{0},typecode={1},valuecode={2}", ex.ToString(), typecode, valuecode));
            }
            return name;
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
