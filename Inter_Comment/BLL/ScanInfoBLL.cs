using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class ScanInfoBLL
    {

        ScanInfoDAL scaninfodal = new ScanInfoDAL();
        /// <summary>
        /// 获取所有评分的标题
        /// </summary>
        /// <returns></returns>
        public SqlDataReader getlist()
        {
            return scaninfodal.getlist();

        }


        /// <summary>
        /// 根据项目组id和评分人姓名获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public SqlDataReader GetRecordByIdAndActorName(int id, string username,string time)
        {
            return scaninfodal.GetRecordByIdAndActorName(id, username,time);
        }



        /// <summary>
        /// 根据项目组id和被评分人姓名获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public SqlDataReader GetRecordByIdAndPassiveName(int id, string username,string time)
        {
            return scaninfodal.GetRecordByIdAndPassiveName(id, username,time);
        }

        /// <summary>
        /// 根据项目组ID获取项目组各项名称
        /// </summary>
        /// <param name="id">项目组ID</param>
        /// <returns></returns>
        public SqlDataReader GetItemsById(int id)
        {
            return scaninfodal.GetItemsById(id);
        }



        /// <summary>
        /// 获取成绩单
        /// </summary>
        /// <param name="id">项目组id</param>
        /// <returns></returns>
        public SqlDataReader GetGrade(int id)
        {
            return scaninfodal.GetGrade(id);
        }

    }
}
