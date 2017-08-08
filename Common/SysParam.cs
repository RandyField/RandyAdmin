using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class SysParam
    {
        #region Field
        private static Dictionary<string, string> _sessionDictionary;// 保存所有用户session对象
        #endregion

        #region Property
        /// <summary>
        /// 密钥
        /// </summary>
        public static string SecretKey
        {
            get
            {
                return "Randy";
            }
        }

        /// <summary>
        /// 保存所有用户session对象
        /// string：帐号  string：sessionID
        /// </summary>
        public static Dictionary<string, string> SessionDictionary
        {
            get
            {
                if (_sessionDictionary == null)
                {
                    _sessionDictionary = new Dictionary<string, string>();
                }
                return _sessionDictionary;
            }
            set { _sessionDictionary = value; }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取键对应值
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="defaultValue">作为未获取到数据的备用值</param>
        /// <returns>与键对应的值</returns>
        public static string GetValue(string key, string defaultValue="")
        {
            return defaultValue;
        }
        #endregion
    }
}
