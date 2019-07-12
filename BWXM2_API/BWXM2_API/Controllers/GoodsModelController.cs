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
    public class GoodsModelController : ApiController
    {
        GoodsModelBll bll = new GoodsModelBll();
        /// <summary>
        /// 商品类型
        /// </summary>
        /// <returns></returns>
        public List<GoodsModel> Get()
        {
            return bll.GoodsModelShows();
        }
    }
}
