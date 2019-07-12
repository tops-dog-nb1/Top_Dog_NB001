using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class GoodsBll
    {
        GoodsDal dal = new GoodsDal();
        /// <summary>
        /// 商品添加
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public int GoodsInsert(Goods gs)
        {
            return dal.GoodsInsert(gs);
        }
        /// <summary>
        /// 商品删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GoodsDelete(int Id)
        {
            return dal.GoodsDelete(Id);
        }
        /// <summary>
        /// 反填商品
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Goods GoodsShow(int Id)
        {
            return dal.GoodsShow(Id);
        }
        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public int GoodsUpdate(Goods gs)
        {
            return dal.GoodsUpdate(gs);
        }
        /// <summary>
        /// 查询所有商品
        /// </summary>
        /// <returns></returns>
        public List<Goods> GetGoods()
        {
            return dal.GetGoods();
        }
    }
}
