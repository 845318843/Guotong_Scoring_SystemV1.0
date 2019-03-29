using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data.Sql;

namespace BLL
{
    public class GetTrendBLL
    {
        GetTrendDAL dal = new GetTrendDAL();

        /// <summary>
        /// 根据项目组Id 被评分人 年份 哪一项 获取平均分数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <param name="items"></param>
        /// <returns>返回 平均分数 月份</returns>
        public SqlDataReader GetFirstItemsScoreByIdAndTime(int id, string passive, string year)
        {
            return dal.GetFifthItemsScoreByIdAndTime(id, passive, year);
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
            return dal.GetSecondItemsScoreByIdAndTime(id, passive, year);
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
            return dal.GetThirdItemsScoreByIdAndTime(id, passive, year);
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
            return dal.GetForthItemsScoreByIdAndTime(id, passive, year);
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
            return dal.GetFifthItemsScoreByIdAndTime(id, passive, year);
        }


        /// <summary>
        /// 根据项目组id 被评分人 年份 获取总份数 按月分组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="passive"></param>
        /// <param name="year"></param>
        /// <returns>返回 总分数 月份</returns>
        public SqlDataReader GetSumScoreByMonth(int id, string passive, string year)
        {
            return dal.GetSumScoreByMonth(id, passive, year);
        }



        /// <summary>
        /// 根据项目编号获取五个项目关键字
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetKeyWordByThemeId(int id)
        {
            return dal.GetKeyWordByThemeId(id);
        }


        /// <summary>
        /// 根据项目组ID获取有哪些年份记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetYearsListByThemeId()
        {
            return dal.GetYearsListByThemeId();
        }
    }
}
