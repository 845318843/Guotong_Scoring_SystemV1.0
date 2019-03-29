using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL
{
    public class GetJoinerDAL
    {
        SqlDb db = new SqlDb();


        /// <summary>
        /// 获取所有参与评分的人
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetAllJoiner() {
            string strsql = "select Staff_Name from Staff where Is_Join=1";
            SqlParameter []paras={};
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }


        /// <summary>
        /// 获取在某次评分中已经评分的员工姓名
        /// </summary>
        /// <param name="id">项目ID</param>
        /// <returns></returns>
        public SqlDataReader GetHaveCommentJoinerByItemId(int id,string time) {
            string strsql = "select Staff_Name from Staff where Staff_Name in (select Actor from F_Record where ItemsID=@id and datename(year,Comment_Time)+'-'+datename(month,Comment_Time)=@time group by Actor)";
            SqlParameter[] paras = { new SqlParameter("@id", id),new SqlParameter("time",time) };
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }


        /// <summary>
        /// 获取在某次评分中没有评分的员工姓名
        /// </summary>
        /// <param name="id">项目ID</param>
        /// <returns></returns>
        public SqlDataReader GetNotCommentJoinerByItemId(int id,string time) {
            string strsql = "select Staff_Name from Staff where Staff_Name not in (select Actor from F_Record where ItemsID=@id and datename(year,Comment_Time)+'-'+datename(month,Comment_Time)=@time group by Actor)";
            SqlParameter[] paras = { new SqlParameter("@id", id),new SqlParameter("time",time) };
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }
    }
}
