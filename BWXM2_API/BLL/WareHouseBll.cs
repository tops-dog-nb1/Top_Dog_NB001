using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class WareHouseBll
    {
        WareHouseDal dal = new WareHouseDal();
        /// <summary>
        /// 仓库显示
        /// </summary>
        /// <returns></returns>
        public List<WareHouse> WareHouseShow()
        {
            return dal.WareHouseShow();
        }
    }
}
