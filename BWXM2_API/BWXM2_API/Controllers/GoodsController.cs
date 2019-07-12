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
    public class GoodsController : ApiController
    {
        GoodsBll bll = new GoodsBll();
        /// <summary>
        /// 商品添加
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public int Post(Goods gs)
        {
            return bll.GoodsInsert(gs);
        }
        /// <summary>
        /// 商品删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int Delete(int Id)
        {
            return bll.GoodsDelete(Id);
        }
        /// <summary>
        /// 反填商品
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Goods GoodsShow(int Id)
        {
            return bll.GoodsShow(Id);
        }
        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public int Put(Goods gs)
        {
            return bll.GoodsUpdate(gs);
        }
        /// <summary>
        /// 查询所有商品
        /// </summary>
        /// <returns></returns>
        public List<Goods> Get()
        {
            return bll.GetGoods();
        }
    }
}
