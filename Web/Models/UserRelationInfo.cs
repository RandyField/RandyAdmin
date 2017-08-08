using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class UserRelationInfo
    {
        public List<SYS_ROLE> rolelist { get; set; }
        public List<SYS_DEPARTMENT> departlist { get; set; }
    }
}