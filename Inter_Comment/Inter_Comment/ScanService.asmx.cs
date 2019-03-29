using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BLL;
using System.Data.SqlClient;

namespace Inter_Comment
{
    /// <summary>
    /// ScanService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class ScanService : System.Web.Services.WebService
    {

        ScanInfoBLL scaninfobll = new ScanInfoBLL();

        GetJoinerBLL getjoinerbll = new GetJoinerBLL();

        
        /// <summary>
        /// 获取所有评分的标题
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string getlist()
        {
            SqlDataReader sr = scaninfobll.getlist();
            string str = "";
            while (sr.Read()) {
                str += "<option value=\"" + Convert.ToInt32(sr[0].ToString()) + "\" >" + sr[1].ToString() + "</option>";
            }
            sr.Close();
            return str;

        }


        /// <summary>
        /// 根据项目组id和评分人姓名获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        [WebMethod]
        public string GetRecordByIdAndActorName(int id, string username,string time)
        {
            SqlDataReader sr = scaninfobll.GetRecordByIdAndActorName(id, username,time);
            string str = "";
            try
            {
                while (sr.Read())
                {
                    str += "<tr>";
                    str += "<td style=\"width:160px;text-align:center\">" + sr[0].ToString() + "</td><td style=\"width:160px;text-align:center\">" + sr[1].ToString() + "</td>";
                    str += "<td><span style=\"width: 15%; text-align:center;\">" + sr[4].ToString() + "</span>&nbsp;&nbsp; <span style=\"width: 15%; text-align:center;\">" + sr[5].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[6].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[7].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[8].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;color:#f00;\">" + sr[3].ToString() + "</span></td>";
                    str += "<td><span style=\"width: 15%; text-align:center;\">" + sr[10].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[11].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[12].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[13].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[14].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;color:#f00;\">" + sr[9].ToString() + "</span></td>";
                    str += "<td><span style=\"width: 15%; text-align:center;\">" + sr[16].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[17].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[18].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[19].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[20].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;color:#f00;\">" + sr[15].ToString() + "</span></td>";
                    str += "<td><span style=\"width: 15%; text-align:center;\">" + sr[22].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[23].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[24].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[25].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[26].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;color:#f00;\">" + sr[21].ToString() + "</span></td>";
                    str += "<td><span style=\"width: 15%; text-align:center;\">" + sr[28].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[29].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[30].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[31].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[32].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;color:#f00;\">" + sr[27].ToString() + "</span></td>";
                    str += "<td style=\"color:#f00;\">" + sr[34].ToString() + "</td>";
                    str += "<td>" + sr[33].ToString() + "</td></tr>";
                }
            }
            catch (Exception ex) { }
            return str;
        }



        /// <summary>
        /// 根据项目组id和评分人姓名获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        [WebMethod]
        public string GetRecordByIdAndPassiveName(int id, string username,string time)
        {
            SqlDataReader sr = scaninfobll.GetRecordByIdAndPassiveName(id, username,time);
            string str = "";
            try
            {
                while (sr.Read())
                {
                    str += "<tr>";
                    str += "<td style=\"width:160px;text-align:center\">" + sr[0].ToString() + "</td><td style=\"width:160px;text-align:center\">" + sr[1].ToString() + "</td>";
                    str += "<td><span style=\"width: 15%; text-align:center;\">" + sr[4].ToString() + "</span>&nbsp;&nbsp; <span style=\"width: 15%; text-align:center;\">" + sr[5].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[6].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[7].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[8].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;color:#f00;\">" + sr[3].ToString() + "</span></td>";
                    str += "<td><span style=\"width: 15%; text-align:center;\">" + sr[10].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[11].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[12].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[13].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[14].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;color:#f00;\">" + sr[9].ToString() + "</span></td>";
                    str += "<td><span style=\"width: 15%; text-align:center;\">" + sr[16].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[17].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[18].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[19].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[20].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;color:#f00;\">" + sr[15].ToString() + "</span></td>";
                    str += "<td><span style=\"width: 15%; text-align:center;\">" + sr[22].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[23].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[24].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[25].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[26].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;color:#f00;\">" + sr[21].ToString() + "</span></td>";
                    str += "<td><span style=\"width: 15%; text-align:center;\">" + sr[28].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[29].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[30].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[31].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;\">" + sr[32].ToString() + "</span>&nbsp;&nbsp;<span style=\"width: 15%; text-align:center;color:#f00;\">" + sr[27].ToString() + "</span></td>";
                    str += "<td style=\"color:#f00;\">" + sr[34].ToString() + "</td>";
                    str += "<td>" + sr[33].ToString() + "</td></tr>";
                }
            }
            catch (Exception ex) { }
            return str;
        }


        /// <summary>
        /// 根据项目组ID获取项目组各项名称
        /// </summary>
        /// <param name="id">项目组ID</param>
        /// <returns></returns>
        [WebMethod]
        public string GetItemsById(int id)
        {
            string str = "";
            SqlDataReader sr = scaninfobll.GetItemsById(id);
            str += "<th style=\"width:160px;text-align:center\">评分人</th><th style=\"width:160px;text-align:center\">被评分人</th>";
            while (sr.Read()) {
                str += "<th style=\"width:160px;text-align:center\">" + sr["First_Item"].ToString() + "</th>";
                str += "<th style=\"width:160px;text-align:center\">" + sr["Second_Item"].ToString() + "</th>";
                str += "<th style=\"width:160px;text-align:center\">" + sr["Third_Item"].ToString() + "</th>";
                str += "<th style=\"width:160px;text-align:center\">" + sr["Forth_Item"].ToString() + "</th>";
                str += "<th style=\"width:160px;text-align:center\">" + sr["Fifth_Item"].ToString() + "</th>";
            }
            sr.Close();
            str += "<th style=\"width:20px;text-align:center;\">总分</th>";
            str += "<th style=\"width:160px;text-align:center\">评分时间</th>";
            return str;
        }



        /// <summary>
        /// 获取成绩单
        /// </summary>
        /// <param name="id">项目组id</param>
        /// <returns></returns>
        [WebMethod]
        public string GetGrade(int id)
        {
            SqlDataReader sr = scaninfobll.GetGrade(id);
            string str = "";
            int i = 0;
            double sum = 0.0;
            while (sr.Read())
            {
                if (sum == Convert.ToDouble(sr["sumscore"].ToString()))
                {

                }
                else {
                    i++;
                }
                str += "<tr>";
                str += "<td>" + sr["Passive"].ToString() + "</td>";
                str += "<td>" + sr["a"].ToString() + "</td>";
                str += "<td>" + sr["b"].ToString() + "</td>";
                str += "<td>" + sr["c"].ToString() + "</td>";
                str += "<td>" + sr["d"].ToString() + "</td>";
                str += "<td>" + sr["e"].ToString() + "</td>";
                str += "<td>" + sr["sumscore"].ToString() + "</td>";
                //sum = Convert.ToDouble(sr["sumscore"].ToString());
                //sum = Convert.ToDouble(sr["sumscore"].ToString());
                str += "<td>" + i + "</td>";
                str += "</tr>";
                    sum = Convert.ToDouble(sr["sumscore"].ToString());
            }
            sr.Close();
            return str;
        }




        /// <summary>
        /// 根据项目组ID获取项目组各项名称
        /// </summary>
        /// <param name="id">项目组ID</param>
        /// <returns></returns>
        [WebMethod]
        public string Score_GetItemsById(int id)
        {
            string str = "";
            SqlDataReader sr = scaninfobll.GetItemsById(id);
            
            while (sr.Read())
            {
               str+="<tr>";
                    str+="<th style=\"width:10%;text-align:center\">姓名</th>";
                    str+="<th style=\"width:11%;text-align:center\">"+sr["First_Item"].ToString()+"</th>";
                    str+="<th style=\"width:5%;text-align:center\">单项名次</th>";
                    str+="<th style=\"width:11%;text-align:center\">"+sr["Second_Item"].ToString()+"</th>";
                    str+="<th style=\"width:5%;text-align:center\">单项名次</th>";
                    str+="<th style=\"width:11%;text-align:center\">"+sr["Third_Item"].ToString()+"</th>";
                    str+="<th style=\"width:5%;text-align:center\">单项名次</th>";
                    str+="<th style=\"width:11%;text-align:center\">"+sr["Forth_Item"].ToString()+"</th>";
                    str+="<th style=\"width:5%;text-align:center\">单项名次</th>";
                    str+="<th style=\"width:11%;text-align:center\">"+sr["Fifth_Item"].ToString()+"</th>";
                    str+="<th style=\"width:5%;text-align:center\">单项名次</th>";
                    str+="<th style=\"width:6%;text-align:center\">总分</th>";
                    str+="<th style=\"width:5%;text-align:center\">总名次</th>";
                str+="</tr>";
            }
            sr.Close();
            return str;
        }



        /// <summary>
        /// 获取在某次评分中已经评分的员工姓名
        /// </summary>
        /// <param name="id">项目ID</param>
        /// <returns></returns>
        [WebMethod]
        public string GetHaveCommentJoinerByItemId(int id,string time)
        {
            SqlDataReader sr= getjoinerbll.GetHaveCommentJoinerByItemId(id,time);
            string str = "";
            str += "<tr><th style=\"width:400px;text-align:center\">姓名</th><th style=\"width:400px;text-align:center\">评分状态</th></tr>";
            while (sr.Read()) {
                str += "<tr><td>" + sr[0].ToString() + "</td>";
                str += "<td>已评分</td></tr>";
            }
            return str;
        }


        /// <summary>
        /// 获取在某次评分中没有评分的员工姓名
        /// </summary>
        /// <param name="id">项目ID</param>
        /// <returns></returns>
        [WebMethod]
        public string GetNotCommentJoinerByItemId(int id,string time)
        {
            SqlDataReader sr= getjoinerbll.GetNotCommentJoinerByItemId(id,time);
            string str = "";
            while (sr.Read())
            {
                str += "<tr><td>" + sr[0].ToString() + "</td>";
                str += "<td>尚未评分</td></tr>";
            }
            return str;
        }


    }
}
