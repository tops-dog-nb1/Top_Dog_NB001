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
    public class WareHouseDal
    {
        private static readonly string connectionstring = System.Configuration.ConfigurationManager.AppSettings[""];
        /// <summary>
        /// 仓库显示
        /// </summary>
        /// <returns></returns>
        public List<WareHouse> WareHouseShow()
        {
            using (IDbConnection con = new SqlConnection(connectionstring))
            {
                return con.Query<WareHouse>("select w.Name from WareHouse as w join Goods as g on w.Gid=g.Id").ToList();
            }
        }
    }
}
