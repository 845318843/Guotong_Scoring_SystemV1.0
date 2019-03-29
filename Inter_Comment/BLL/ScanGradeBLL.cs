using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class ScanGradeBLL
    {
        ScanGradeDAL dal = new ScanGradeDAL();


        /// <summary>
        /// 将指定的成绩迁移到Temp表中
        /// </summary>
        /// <param name="id">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public bool MoveGradeToTemp(int id, string time)
        {
            return dal.MoveGradeToTemp(id, time);
        }



        /// <summary>
        /// 将第一项名次迁移到Temp表中
        /// </summary>
        /// <param name="id">项目组ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public bool MoveFirstOrderToTemp(int id, string time)
        {
            return dal.MoveFirstOrderToTemp(id, time);
        }



        /// <summary>
        /// 将第二项名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool MoveSecondOrderToTemp(int id, string time)
        {
            return dal.MoveSecondOrderToTemp(id, time);
        }



        /// <summary>
        /// 将第三项名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool MoveThirdOrderToTemp(int id, string time)
        {
            return dal.MoveThirdOrderToTemp(id, time);
        }



        /// <summary>
        /// 将第四项名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool MoveForthOrderToTemp(int id, string time)
        {
            return dal.MoveForthOrderToTemp(id, time);
        }



        /// <summary>
        /// 将第五项名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool MoveFifthOrderToTemp(int id, string time)
        {
            return dal.MoveFifthOrderToTemp(id, time);
        }



        /// <summary>
        /// 将第总名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool MoveSumOrderToTemp(int id, string time)
        {
            return dal.MoveSumOrderToTemp(id, time);
        }



        /// <summary>
        /// 获取排行榜
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetGradeFromTemp()
        {
            return dal.GetGradeFromTemp();
        }



        /// <summary>
        /// 清空Temp表
        /// </summary>
        /// <returns></returns>
        public bool ClearTemp()
        {
            return dal.ClearTemp();
        }


        /// <summary>
        /// 将成绩保存到表中
        /// </summary>
        /// <returns></returns>
        public DataTable GetTable()
        {
            return dal.GetTable();
        }

        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="dt">要导出的表</param>
        /// <param name="ColumnWidth">列宽</param>
        /// <param name="Title">标题</param>
        /// <returns>是否导出成功</returns>
        public bool createlist(DataTable dt, string Title,string firstitem,string seconditem,string thirditem,string forthitem,string fifthitem, string path)
        {
            
            return dal.createlist(dt,Title,firstitem,seconditem,thirditem,forthitem,fifthitem,path);
        } 
    }
}
