using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GetItemsDAL
    {
        SqlDb db = new SqlDb();


        /// <summary>
        /// 获取评分项目
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public SqlDataReader getItems(int ID) {
            SqlDataReader sr;
            string strsql = "select * from Five_Items where ID=@ID";
            SqlParameter[] paras = { new SqlParameter("ID", ID) };
            sr=db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }
    }
}
