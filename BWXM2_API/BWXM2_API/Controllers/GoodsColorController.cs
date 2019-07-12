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
    public class GoodsColorController : ApiController
    {
        GoodsColorBll bll = new GoodsColorBll();
        /// <summary>
        /// 商品颜色
        /// </summary>
        /// <returns></returns>
        public List<GoodsColor> Get()
        {
            return bll.GoodsColorShow();
        }
    }
}
