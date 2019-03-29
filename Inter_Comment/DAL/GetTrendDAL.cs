using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL
{
    public class GetTrendDAL
    {
        SqlDb db = new SqlDb();


        /// <summary>
        /// 根据项目组Id 被评分人 年份 哪一项 获取平均分数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <param name="items"></param>
        /// <returns>返回 平均分数 月份</returns>
        public SqlDataReader GetFirstItemsScoreByIdAndTime(int id, string passive, string year) {
            string strsql = @"select convert(decimal(5,2),AVG(convert(decimal(5,2),First_Item))) as score,
datename(YEAR,Comment_Time)+'-'+DATENAME(MONTH,Comment_Time) as times 
from F_Record where ItemsID=@id and Passive=@passive and DATENAME(YEAR,Comment_Time)=@year 
group by datename(YEAR,Comment_Time)+'-'+DATENAME(MONTH,Comment_Time)";
            SqlParameter[] paras ={new SqlParameter("id",id),new SqlParameter("passive",passive),
                                 new SqlParameter("year",year)};
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }



        /// <summary>
        /// 根据项目组Id 被评分人 年份 哪一项 获取平均分数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <param name="items"></param>
        /// <returns>返回 平均分数 月份</returns>
        public SqlDataReader GetSecondItemsScoreByIdAndTime(int id, string passive, string year)
        {
            string strsql = @"select convert(decimal(5,2),AVG(convert(decimal(5,2),Second_Item))) as score,
            datename(YEAR,Comment_Time)+'-'+DATENAME(MONTH,Comment_Time) as times 
from F_Record where ItemsID=@id and Passive=@passive and DATENAME(YEAR,Comment_Time)=@year 
group by datename(YEAR,Comment_Time)+'-'+DATENAME(MONTH,Comment_Time)";
            SqlParameter[] paras ={new SqlParameter("id",id),new SqlParameter("passive",passive),
                                 new SqlParameter("year",year)};
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }



        /// <summary>
        /// 根据项目组Id 被评分人 年份 哪一项 获取平均分数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <param name="items"></param>
        /// <returns>返回 平均分数 月份</returns>
        public SqlDataReader GetThirdItemsScoreByIdAndTime(int id, string passive, string year)
        {
            string strsql = @"select convert(decimal(5,2),AVG(convert(decimal(5,2),Third_Item))) as score,
            datename(YEAR,Comment_Time)+'-'+DATENAME(MONTH,Comment_Time) as times 
from F_Record where ItemsID=@id and Passive=@passive and DATENAME(YEAR,Comment_Time)=@year 
group by datename(YEAR,Comment_Time)+'-'+DATENAME(MONTH,Comment_Time)";
            SqlParameter[] paras ={new SqlParameter("id",id),new SqlParameter("passive",passive),
                                 new SqlParameter("year",year)};
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }


        /// <summary>
        /// 根据项目组Id 被评分人 年份 哪一项 获取平均分数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <param name="items"></param>
        /// <returns>返回 平均分数 月份</returns>
        public SqlDataReader GetForthItemsScoreByIdAndTime(int id, string passive, string year)
        {
            string strsql = @"select convert(decimal(5,2),AVG(convert(decimal(5,2),Forth_Item))) as score,
            datename(YEAR,Comment_Time)+'-'+DATENAME(MONTH,Comment_Time) as times 
from F_Record where ItemsID=@id and Passive=@passive and DATENAME(YEAR,Comment_Time)=@year 
group by datename(YEAR,Comment_Time)+'-'+DATENAME(MONTH,Comment_Time)";
            SqlParameter[] paras ={new SqlParameter("id",id),new SqlParameter("passive",passive),
                                 new SqlParameter("year",year)};
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }


        /// <summary>
        /// 根据项目组Id 被评分人 年份 哪一项 获取平均分数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <param name="items"></param>
        /// <returns>返回 平均分数 月份</returns>
        public SqlDataReader GetFifthItemsScoreByIdAndTime(int id, string passive, string year)
        {
            string strsql = @"select convert(decimal(5,2),AVG(convert(decimal(5,2),Fifth_Item))) as score,
            datename(YEAR,Comment_Time)+'-'+DATENAME(MONTH,Comment_Time) as times 
from F_Record where ItemsID=@id and Passive=@passive and DATENAME(YEAR,Comment_Time)=@year 
group by datename(YEAR,Comment_Time)+'-'+DATENAME(MONTH,Comment_Time)";
            SqlParameter[] paras ={new SqlParameter("id",id),new SqlParameter("passive",passive),
                                 new SqlParameter("year",year)};
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }


        /// <summary>
        /// 根据项目组id 被评分人 年份 获取总份数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <returns>返回 总分数 月份</returns>
        public SqlDataReader GetSumScoreByMonth(int id, string passive, string year) {
            string strsql = @"select CONVERT(decimal(5,2),AVG(convert(decimal(5,2),First_Item)))+CONVERT(decimal(5,2),AVG(convert(decimal(5,2),Second_Item)))+CONVERT(decimal(5,2),AVG(convert(decimal(5,2),Third_Item)))+CONVERT(decimal(5,2),AVG(convert(decimal(5,2),Forth_Item)))+CONVERT(decimal(5,2),AVG(convert(decimal(5,2),Fifth_Item))),
DATENAME(YEAR,Comment_Time)+'-'+DATENAME(MONTH,Comment_Time) 
from F_Record where ItemsID=@id and DATENAME(YEAR,Comment_Time)=@year and Passive=@passive 
group by DATENAME(YEAR,Comment_Time)+'-'+DATENAME(MONTH,Comment_Time)";
            SqlParameter[] paras ={new SqlParameter("id",id),new SqlParameter("passive",passive),
                                 new SqlParameter("year",year)};
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }


        /// <summary>
        /// 根据项目编号获取五个项目关键字
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetKeyWordByThemeId(int id) {
            string strsql = "select First_KeyWord,Second_KeyWord,Third_KeyWord,Forth_KeyWord,Fifth_KeyWord from Five_Items where ID=@id";
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }


        /// <summary>
        /// 根据项目组ID获取有哪些年份记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetYearsListByThemeId() {
            string strsql = "select datename(year,Comment_Time) as years from F_Record  group by DATENAME(YEAR,Comment_Time)";
            SqlParameter[] paras = {  };
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }
    }
}
