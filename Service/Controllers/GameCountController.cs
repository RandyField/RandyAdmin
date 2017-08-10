using BLL;
using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Service.Controllers
{
    public class GameCountController : ApiController
    {
        [HttpPost]
        public void Index(Zhp_GameCount model)
        {
            Zhp_GameCount_BLL.getInstance().Count(model);
        }
    }
}
