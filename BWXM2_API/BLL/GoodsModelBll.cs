using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class GoodsModelBll
    {
        GoodsModelDal dal = new GoodsModelDal();
        /// <summary>
        /// 商品类型
        /// </summary>
        /// <returns></returns>
        public List<GoodsModel> GoodsModelShows()
        {
            return dal.GoodsModelShows();
        }
    }
}
