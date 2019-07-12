using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWXM2_MVC.Models
{
    /// <summary>
    /// 颜色
    /// </summary>
    public class GoodsColor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Goods { get; set; }
    }
}