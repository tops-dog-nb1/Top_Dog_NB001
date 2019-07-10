using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Factory
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public abstract class Furniture
    {
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <returns></returns>
        public abstract int Insert(Goods gs);
        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="Id"></param>
        public abstract int Remove(int Id);
        /// <summary>
        /// 反填
        /// </summary>
        /// <returns></returns>
        public abstract Goods TheFill(int Id);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public abstract int Update(Goods gs);
        /// <summary>
        /// 显示商品
        /// </summary>
        /// <returns></returns>
        public abstract List<Goods> Shows();
    }
}
