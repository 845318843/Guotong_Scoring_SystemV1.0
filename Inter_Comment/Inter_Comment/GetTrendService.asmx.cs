using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using BLL;
using System.Web.Services;

namespace Inter_Comment
{
    /// <summary>
    /// GetTrendService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class GetTrendService : System.Web.Services.WebService
    {
        GetTrendBLL gettrendbll = new GetTrendBLL();

        /// <summary>
        /// 根据项目组Id 被评分人 年份 哪一项 获取平均分数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <param name="items"></param>
        /// <returns>返回 平均分数 月份</returns>
        [WebMethod]
        public string GetFirstItemsScoreByIdAndTime(int id, string passive, string year)
        {
            SqlDataReader sr= gettrendbll.GetFirstItemsScoreByIdAndTime(id, passive, year);
            string str = "{\"chengji\":[";
            while (sr.Read()) {
                str += "{\"fenshu\":" + sr[0].ToString() + ",\"shijian\":'" + sr[1].ToString() + "'},";
            }
            str = str.TrimEnd(',');
            str += "]}";
            return str;
        }


        /// <summary>
        /// 根据项目组Id 被评分人 年份 哪一项 获取平均分数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <param name="items"></param>
        /// <returns>返回 平均分数 月份</returns>
        [WebMethod]
        public string GetSecondItemsScoreByIdAndTime(int id, string passive, string year)
        {
            SqlDataReader sr = gettrendbll.GetSecondItemsScoreByIdAndTime(id, passive, year);
            string str = "{\"chengji\":[";
            while (sr.Read())
            {
                str += "{\"fenshu\":" + sr[0].ToString() + ",\"shijian\":'" + sr[1].ToString() + "'},";
            }
            str = str.TrimEnd(',');
            str += "]}";
            return str;
        }


        /// <summary>
        /// 根据项目组Id 被评分人 年份 哪一项 获取平均分数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <param name="items"></param>
        /// <returns>返回 平均分数 月份</returns>
        [WebMethod]
        public string GetThirdItemsScoreByIdAndTime(int id, string passive, string year)
        {
            SqlDataReader sr = gettrendbll.GetThirdItemsScoreByIdAndTime(id, passive, year);
            string str = "{\"chengji\":[";
            while (sr.Read())
            {
                str += "{\"fenshu\":" + sr[0].ToString() + ",\"shijian\":'" + sr[1].ToString() + "'},";
            }
            str = str.TrimEnd(',');
            str += "]}";
            return str;
        }


        /// <summary>
        /// 根据项目组Id 被评分人 年份 哪一项 获取平均分数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <param name="items"></param>
        /// <returns>返回 平均分数 月份</returns>
        [WebMethod]
        public string GetForthItemsScoreByIdAndTime(int id, string passive, string year)
        {
            SqlDataReader sr = gettrendbll.GetForthItemsScoreByIdAndTime(id, passive, year);
            string str = "{\"chengji\":[";
            while (sr.Read())
            {
                str += "{\"fenshu\":" + sr[0].ToString() + ",\"shijian\":'" + sr[1].ToString() + "'},";
            }
            str = str.TrimEnd(',');
            str += "]}";
            return str;
        }


        /// <summary>
        /// 根据项目组Id 被评分人 年份 哪一项 获取平均分数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <param name="items"></param>
        /// <returns>返回 平均分数 月份</returns>
        [WebMethod]
        public string GetFifthItemsScoreByIdAndTime(int id, string passive, string year)
        {
            SqlDataReader sr = gettrendbll.GetFifthItemsScoreByIdAndTime(id, passive, year);
            string str = "{\"chengji\":[";
            while (sr.Read())
            {
                str += "{\"fenshu\":" + sr[0].ToString() + ",\"shijian\":'" + sr[1].ToString() + "'},";
            }
            str = str.TrimEnd(',');
            str += "]}";
            return str;
        }


        /// <summary>
        /// 根据项目组id 被评分人 年份 获取总份数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <returns>返回 总分数 月份</returns>
        [WebMethod]
        public string GetSumScoreByMonth(int id, string passive, string year)
        {
            SqlDataReader sr= gettrendbll.GetSumScoreByMonth(id, passive, year);
            string str = "{\"chengji\":[";
            while (sr.Read())
            {
                str += "{\"fenshu\":"+sr[0].ToString()+",\"shijian\":'"+sr[1].ToString()+"'},";
            }
            str = str.TrimEnd(',');
            str += "]}";
            return str;
        }



        /// <summary>
        /// 根据项目编号获取五个项目关键字
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public string GetKeyWordByThemeId(int id)
        {
            SqlDataReader sr= gettrendbll.GetKeyWordByThemeId(id);
            string str = "{";
            while (sr.Read()) {
                str += "\"First_KeyWord\":'" + sr[0].ToString() + "',";
                str += "\"Second_KeyWord\":'" + sr[1].ToString() + "',";
                str += "\"Third_KeyWord\":'" + sr[2].ToString() + "',";
                str += "\"Forth_KeyWord\":'" + sr[3].ToString() + "',";
                str += "\"Fifth_KeyWord\":'" + sr[4].ToString() + "'";
                break;
            }
             str+="}";
             return str;
        }


        /// <summary>
        /// 根据项目组ID获取有哪些年份记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public string GetYearsListByThemeId()
        {
            SqlDataReader sr = gettrendbll.GetYearsListByThemeId();
            string str = "";
            while (sr.Read()) {
                str += "<option value=\"" + sr[0].ToString() + "\">" + sr[0].ToString() + "</option>";
            }
            return str;
        }
    }
}
