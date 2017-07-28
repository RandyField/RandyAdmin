using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    //    {
    //    "sEcho": 3,
    //    "iTotalRecords": 57,
    //    "iTotalDisplayRecords": 57,
    //    "aaData": [
    //        [
    //            "用户ID",
    //            "账号",
    //            "姓名",
    //            "电子邮箱",
    //            "电话"
    //        ],
    //        [
    //            "用户ID",
    //            "账号",
    //            "姓名",
    //            "电子邮箱",
    //            "电话"
    //        ],
    //        ...
    //    ] 
    //}

    //    {
    //"sEcho": 页面发来的参数，原样返回,
    //"iTotalRecords": 过滤前总记录数,
    //"iTotalDisplayRecords": 过滤后总记录数，我没有使用过滤，不太清楚和iTotalRecords的区别,
    //"aaData": 包含数据的2维数组
    //}
    public class JqueryDataTable
    {

        public long iTotalRecords { get; set; }
        public long iTotalDisplayRecords { get; set; }
        public string sEcho { get; set; }
        public string[][] aaData { get; set; }

        public JqueryDataTable(long totalRecords, long totalDisplayRecords, string echo, string[][] data)
        {
            this.iTotalRecords = totalRecords;
            this.iTotalDisplayRecords = iTotalDisplayRecords;
            this.sEcho = echo;
            this.aaData = data;
        }
    }

    //public class DataTableReturnObject
    //{
    //    private long iTotalRecords;
    //    private long iTotalDisplayRecords;
    //    private String sEcho;
    //    private String[][] aaData;

    //    public DataTableReturnObject(long totalRecords, long totalDisplayRecords, String echo, String[][] d)
    //    {
    //        //略
    //    }
    //}
}
