using Common.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ToolController : Controller
    {
        //
        // GET: /Tool/

        public ActionResult FileRenameIndex()
        {
            ViewData["FirstMenu"] = "平台管理";
            ViewData["SecondMenu"] = "小工具";
            return View();
        }

        /// <summary>
        /// 重命名文件名
        /// </summary>
        /// <param name="ParentDir"></param>
        /// <param name="stringFront"></param>
        /// <param name="stringBack"></param>
        public ActionResult RenameFile(string ParentDir, string stringFront, string stringBack)
        {
            try
            {
                //获取文件列表 .cs
                string[] files = Directory.GetFiles(ParentDir, "*.cs", SearchOption.TopDirectoryOnly);

                foreach (string file in files)
                {
                    string filename = Path.GetFileNameWithoutExtension(file);
                    string pathname = Path.GetDirectoryName(file);

                    if (!string.IsNullOrWhiteSpace(stringFront))
                    {
                        filename = stringFront + filename;
                    }
                    if (!string.IsNullOrWhiteSpace(stringBack))
                    {
                        filename = filename + stringBack;
                    }
                    filename = filename + ".cs";
                    FileInfo fi = new FileInfo(file);
                    fi.MoveTo(Path.Combine(pathname, filename));

                    //if (filename.StartsWith(stringFront, true, null))
                    //{
                       
                    //}
                }
                string[] dirs = Directory.GetDirectories(ParentDir);
                foreach (string dir in dirs)
                {
                    RenameFile(dir, stringFront, stringBack);
                }
                jsonResult result = new jsonResult();             
                result.success = true;
                result.msg = "修改成功";
                return Json(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
