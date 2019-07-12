using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;

namespace BWXM2_API.Controllers
{
    public class WareHouseController : ApiController
    {
        WareHouseBll bll = new WareHouseBll();
        /// <summary>
        /// 仓库显示
        /// </summary>
        /// <returns></returns>
        public List<WareHouse> Get()
        {
            return bll.WareHouseShow();
        }
    }
}
