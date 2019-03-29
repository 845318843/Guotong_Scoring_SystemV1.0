using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ScanInfoDAL
    {


        SqlDb db = new SqlDb();




        /// <summary>
        /// 获取所有评分的标题
        /// </summary>
        /// <returns></returns>
        public SqlDataReader getlist() {
            string strsql = "select ID,Theme from Five_Items where IsEnable=1";
            SqlParameter[] paras = { };
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }




        /// <summary>
        /// 根据项目组id和评分人姓名获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public SqlDataReader GetRecordByIdAndActorName(int id, string username,string time) {
            string strsql = "select *,First_Item+Second_Item+Third_Item+Forth_Item+Fifth_Item from F_Record where ItemsID=@id and Actor=@actor and datename(year,Comment_Time)+'-'+datename(month,Comment_Time)=@time";
            SqlParameter []paras={new SqlParameter("@id",id),new SqlParameter("actor",username),
                                 new SqlParameter("@time",time)};
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }




        /// <summary>
        /// 根据项目组id和被评分人姓名获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public SqlDataReader GetRecordByIdAndPassiveName(int id, string username,string time)
        {
            string strsql = "select * from F_Record where ItemsID=@id and Passive=@actor and datename(year,Comment_Time)+'-'+datename(month,Comment_Time)=@time";
            SqlParameter[] paras = { new SqlParameter("@id", id), new SqlParameter("actor", username),
                                   new SqlParameter("time",time)};
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }


        /// <summary>
        /// 根据项目组ID获取项目组各项名称
        /// </summary>
        /// <param name="id">项目组ID</param>
        /// <returns></returns>
        public SqlDataReader GetItemsById(int id) {
            string strsql = "select * from Five_Items where ID=@ID";
            SqlParameter[] paras = { new SqlParameter("ID", id) };
            return db.GetDataReader_ZUO(strsql, paras);
        }




        /// <summary>
        /// 获取成绩单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetGrade(int id) {
            string strsql = "select Passive,convert(decimal(5,2),avg(First_Item)) as a,convert(decimal(5,2),avg(Second_Item)) as b,convert(decimal(5,2),AVG(Third_Item)) as c,convert(decimal(5,2),AVG(Forth_Item)) as d,convert(decimal(5,2),AVG(Fifth_Item)) as e,convert(decimal(5,2),avg(First_Item))+convert(decimal(5,2),avg(Second_Item))+convert(decimal(5,2),AVG(Third_Item))+convert(decimal(5,2),AVG(Forth_Item))+convert(decimal(5,2),AVG(Fifth_Item)) as sumscore from F_Record where ItemsID=@ID group by Passive order by sumscore desc";
            SqlParameter[] paras = { new SqlParameter("ID", id) };
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }
    }
}
