using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CommonHelper
{
    public static class PermissionHelper
    {
        public static string IsCheckd(string code, string type)
        {
            string style = "";
            if (string.IsNullOrWhiteSpace(code))
            {
                return style;
            }

            if (type == "query")
            {
                if (code[0] == '1')
                {
                    style = "checked";
                }
            }
            if (type == "add")
            {
                if (code[1] == '1')
                {
                    style = "checked";
                }
            }
            if (type == "edit")
            {
                if (code[2] == '1')
                {
                    style = "checked";
                }
            }
            if (type == "delete")
            {
                if (code[3] == '1')
                {
                    style = "checked";
                }
            }

            style = string.Format("checked='{0}'", style);
            return style;
        }
    }
}
