using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BWXM2_MVC.Models
{
    /// <summary>
    /// 商品表
    /// </summary>
    public class Goods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Photos { get; set; }
        public string Intro { get; set; }
    }
}