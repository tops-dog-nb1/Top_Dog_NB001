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
    public class GoodsModelDal
    {
        private static readonly string connectionstring = System.Configuration.ConfigurationManager.AppSettings[""];
        /// <summary>
        /// 商品类型
        /// </summary>
        /// <returns></returns>
        public List<GoodsModel> GoodsModelShows()
        {
            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                return con.Query<GoodsModel>("select m.Name from GoodsModel as m join Goods as g on m.Gid=g.Id").ToList();
            }
        }
    }
}
