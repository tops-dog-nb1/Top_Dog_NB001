using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class GoodsColorBll
    {
        GoodsColorDal dal = new GoodsColorDal();
        /// <summary>
        /// 商品颜色
        /// </summary>
        /// <returns></returns>
        public List<GoodsColor> GoodsColorShow()
        {
            return dal.GoodsColorShow();
        }
    }
}
