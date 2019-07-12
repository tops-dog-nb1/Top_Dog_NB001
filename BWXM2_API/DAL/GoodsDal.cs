using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Model;

namespace DAL
{
    public class GoodsDal
    {
        private static readonly string connectionstring = System.Configuration.ConfigurationManager.AppSettings[""];
        /// <summary>
        /// 商品添加
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public int GoodsInsert(Goods gs)
        {
            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                return con.Execute("insert into Goods(Name,Price,Photos,Intro) values(@Name,@Price,@Photos,@Intro)", gs);
            }
        }
        /// <summary>
        /// 商品删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GoodsDelete(int Id)
        {
            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                return con.Execute("delete from Goods where Id=@Id", Id);
            }
        }
        /// <summary>
        /// 反填商品
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Goods GoodsShow(int Id)
        {
            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                return con.Query<Goods>("select *from Goods").FirstOrDefault();
            }
        }
        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public int GoodsUpdate(Goods gs)
        {
            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                return con.Execute("update Goods set Name=@Name,Price=@Price,Photos=@Photos,Intro=@Intro where Id=@Id", gs);
            }
        }
        /// <summary>
        /// 查询所有商品
        /// </summary>
        /// <returns></returns>
        public List<Goods> GetGoods()
        {
            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                return con.Query<Goods>("select *from Goods").ToList();
            }
        }
    }
}
