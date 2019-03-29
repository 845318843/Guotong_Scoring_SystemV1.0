using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class GetJoinerBLL
    {
        GetJoinerDAL getjoinerdal = new GetJoinerDAL();
        /// <summary>
        /// 获取所有参与评分的人
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetAllJoiner()
        {
            return getjoinerdal.GetAllJoiner();
        }



        /// <summary>
        /// 获取在某次评分中已经评分的员工姓名
        /// </summary>
        /// <param name="id">项目ID</param>
        /// <returns></returns>
        public SqlDataReader GetHaveCommentJoinerByItemId(int id,string time)
        {
            return getjoinerdal.GetHaveCommentJoinerByItemId(id,time);
        }


        /// <summary>
        /// 获取在某次评分中没有评分的员工姓名
        /// </summary>
        /// <param name="id">项目ID</param>
        /// <returns></returns>
        public SqlDataReader GetNotCommentJoinerByItemId(int id,string time)
        {
            return getjoinerdal.GetNotCommentJoinerByItemId(id,time);
        }
    }
}
