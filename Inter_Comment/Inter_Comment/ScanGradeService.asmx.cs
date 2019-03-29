using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.Sql;
using System.Data.SqlClient;
using BLL;
using System.Data;

namespace Inter_Comment
{
    /// <summary>
    /// ScanGradeService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class ScanGradeService : System.Web.Services.WebService
    {
        ScanGradeBLL bll = new ScanGradeBLL();
        
        /// <summary>
        /// 将指定的成绩迁移到Temp表中
        /// </summary>
        /// <param name="id">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        [WebMethod]
        public bool MoveGradeToTemp(int id, string time)
        {
            return bll.MoveGradeToTemp(id, time);
        }



        /// <summary>
        /// 将第一项名次迁移到Temp表中
        /// </summary>
        /// <param name="id">项目组ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        [WebMethod]
        public bool MoveFirstOrderToTemp(int id, string time)
        {
            return bll.MoveFirstOrderToTemp(id, time);
        }



        /// <summary>
        /// 将第二项名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        [WebMethod]
        public bool MoveSecondOrderToTemp(int id, string time)
        {
            return bll.MoveSecondOrderToTemp(id, time);
        }



        /// <summary>
        /// 将第三项名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        [WebMethod]
        public bool MoveThirdOrderToTemp(int id, string time)
        {
            return bll.MoveThirdOrderToTemp(id, time);
        }



        /// <summary>
        /// 将第四项名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        [WebMethod]
        public bool MoveForthOrderToTemp(int id, string time)
        {
            return bll.MoveForthOrderToTemp(id, time);
        }



        /// <summary>
        /// 将第五项名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        [WebMethod]
        public bool MoveFifthOrderToTemp(int id, string time)
        {
            return bll.MoveFifthOrderToTemp(id, time);
        }



        /// <summary>
        /// 将第总名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        [WebMethod]
        public bool MoveSumOrderToTemp(int id, string time)
        {
            return bll.MoveSumOrderToTemp(id, time);
        }



        /// <summary>
        /// 获取排行榜
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string GetGradeFromTemp()
        {
            SqlDataReader sr= bll.GetGradeFromTemp();
            string str = "";
            while (sr.Read()) { 
            str+="<tr>";
            str += "<td>" + sr[0].ToString() + "</td>";
                    str+="<td>"+sr[1].ToString()+"</td>";
                    str+="<td>"+sr[2].ToString()+"</td>";
                    str+="<td>"+sr[3].ToString()+"</td>";
                    str+="<td>"+sr[4].ToString()+"</td>";
                    str+="<td>"+sr[5].ToString()+"</td>";
                    str+="<td>"+sr[6].ToString()+"</td>";
                    str+="<td>"+sr[7].ToString()+"</td>";
                    str+="<td>"+sr[8].ToString()+"</td>";
                    str+="<td>"+sr[9].ToString()+"</td>";
                    str+="<td>"+sr[10].ToString()+"</td>";
                    str+="<td>"+sr[11].ToString()+"</td>";
                    str+="<td>"+sr[12].ToString()+"</td>";
                str+="</tr>";
            }
            return str;
        }



        /// <summary>
        /// 清空Temp表
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool ClearTemp()
        {
            return bll.ClearTemp();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public string getid(int id)
        {
            return id.ToString();
        }

        /// <summary>
        /// 将排行榜导出到Excel中
        /// </summary>
        /// <param name="title"></param>
        /// <param name="firstitem"></param>
        /// <param name="seconditem"></param>
        /// <param name="thirditem"></param>
        /// <param name="forthitem"></param>
        /// <param name="fifthitem"></param>
        /// <returns></returns>
        [WebMethod]
        public bool createexcel(int id)
        {
            ScanInfoBLL scanbll = new ScanInfoBLL();
            SqlDataReader sr = scanbll.GetItemsById(id);
            string title = "";
            string firstitem = "";
            string seconditem = "";
            string thirditem = "";
            string forthitem = "";
            string fifthitem = "";
            while (sr.Read())
            {
                title = sr[1].ToString();
                firstitem = sr[2].ToString();
                seconditem = sr[9].ToString();
                thirditem = sr[16].ToString();
                forthitem = sr[23].ToString();
                fifthitem = sr[30].ToString();
                break;
            }
            sr.Close();
            DataTable dt = bll.GetTable();
            DateTime date = DateTime.Now;
            string Title = title + date.ToShortDateString() + "打印";
            string path = Server.MapPath("./file//排行榜.xlsx");
            return bll.createlist(dt, Title, firstitem,seconditem,thirditem,forthitem,fifthitem,path);
            
            
        }


        
    }
}
