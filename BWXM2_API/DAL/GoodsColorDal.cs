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
    public class GoodsColorDal
    {
        private static readonly string connectionstring = System.Configuration.ConfigurationManager.AppSettings[""];
        /// <summary>
        /// 商品颜色
        /// </summary>
        /// <returns></returns>
        public List<GoodsColor> GoodsColorShow()
        {
            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                return con.Query<GoodsColor>("select c.Name from GoodsColor as c join Goods as g on c.Gid=g.Id").ToList();
            }
        }
    }
}
