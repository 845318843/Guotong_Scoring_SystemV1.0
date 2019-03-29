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
    /// CommentService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class CommentService : System.Web.Services.WebService
    {
        GetItemsBLL getitembll = new GetItemsBLL();
        GetJoinerBLL getjoinerbll = new GetJoinerBLL();
        CommentBLL commentbll = new CommentBLL();
        UserBLL userbll = new UserBLL();

        /// <summary>
        /// 获取参评项目列表
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [WebMethod]
        public string getitems(int ID)
        {
            string str = "";
            SqlDataReader sr;
            sr = getitembll.getItems(ID);
            str += "<tr>";
            while (sr.Read())
            {

                str += "<th style=\"width:200px; height:100%;text-align:center\">姓名</th><th style=\"width:200px; height:100%;text-align:center\">" + sr[2].ToString() + "</th>";
                str += "<th style=\"width:200px; height:100%;text-align:center\">" + sr[9].ToString() + "</th><th style=\"width:200px; height:100%;text-align:center\">" + sr[16].ToString() + "</th>";
                str += "<th style=\"width:200px; height:100%;text-align:center\">" + sr[23].ToString() + "</th><th style=\"width:200px; height:100%;text-align:center\">" + sr[30].ToString() + "</th>";

            }
            str += "</r>";

            //str+="<tr>";
            //        str+="<td>批量操作</td><td><select id=\"chengxin\" onchange=\"select_chengxin()\">";
            //        str+="<option value=\"\">请选择</option><option value=\"0\">全部置0</option><option value=\"20\">全部置20</option><option value=\"\">设置固定值</option></select></td>";
            ////jinqian select_jinqian guize weizhi nengli
            //        str+="<td><select id=\"jinqian\" onchange=\"select_jinqian()\">";
            //        str+="<option value=\"\">请选择</option><option value=\"0\">全部置0</option><option value=\"20\">全部置20</option><option value=\"\">设置固定值</option></select></td>";
            //str+="<td><select id=\"guize\" onchange=\"select_guize()\">";
            //        str+="<option value=\"\">请选择</option><option value=\"0\">全部置0</option><option value=\"20\">全部置20</option><option value=\"\">设置固定值</option></select></td>";
            //str+="<td><select id=\"weizhi\" onchange=\"select_weizhi()\">";
            //        str+="<option value=\"\">请选择</option><option value=\"0\">全部置0</option><option value=\"20\">全部置20</option><option value=\"\">设置固定值</option></select></td>";
            //str+="<td><select id=\"nengli\" onchange=\"select_nengli()\">";
            //        str+="<option value=\"\">请选择</option><option value=\"0\">全部置0</option><option value=\"20\">全部置20</option><option value=\"\">设置固定值</option></select></td>";

            //        str += "</tr>";
            return str;
        }


        /// <summary>
        /// 获取标题
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [WebMethod]
        public string getthemebyid(int ID)
        {
            string str = "";
            SqlDataReader sr;
            sr = getitembll.getItems(ID);

            while (sr.Read())
            {

                str = sr[1].ToString();
                break;

            }
            return str;
        }



        /// <summary>
        /// 获取所有参与评分的人
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string getjoiner()
        {
            SqlDataReader sr = getjoinerbll.GetAllJoiner();
            string str = "";
            while (sr.Read())
            {
                str += "<tr><td>" + sr[0].ToString() + "</td>";
                str += "<td><input type=\"text\" style=\"width: 15%; text-align:center;\"/><input type=\"text\" style=\"width: 15%; text-align:center;\"/>";
                str += "<input type=\"text\" style=\"width: 15%; text-align:center;\"/><input type=\"text\" style=\"width: 15%; text-align:center;\"/>";
                str += "<input type=\"text\" style=\"width: 15%; text-align:center;\"/></td>";

                str += "<td><input type=\"text\" style=\"width: 15%; text-align:center;\"/><input type=\"text\" style=\"width: 15%; text-align:center;\"/>";
                str += "<input type=\"text\" style=\"width: 15%; text-align:center;\"/><input type=\"text\" style=\"width: 15%; text-align:center;\"/>";
                str += "<input type=\"text\" style=\"width: 15%; text-align:center;\"/></td>";

                str += "<td><input type=\"text\" style=\"width: 15%; text-align:center;\"/><input type=\"text\" style=\"width: 15%; text-align:center;\"/>";
                str += "<input type=\"text\" style=\"width: 15%; text-align:center;\"/><input type=\"text\" style=\"width: 15%; text-align:center;\"/>";
                str += "<input type=\"text\" style=\"width: 15%; text-align:center;\"/></td>";

                str += "<td><input type=\"text\" style=\"width: 15%; text-align:center;\"/><input type=\"text\" style=\"width: 15%; text-align:center;\"/>";
                str += "<input type=\"text\" style=\"width: 15%; text-align:center;\"/><input type=\"text\" style=\"width: 15%; text-align:center;\"/>";
                str += "<input type=\"text\" style=\"width: 15%; text-align:center;\"/></td>";

                str += "<td><input type=\"text\" style=\"width: 15%; text-align:center;\"/><input type=\"text\" style=\"width: 15%; text-align:center;\"/>";
                str += "<input type=\"text\" style=\"width: 15%; text-align:center;\"/><input type=\"text\" style=\"width: 15%; text-align:center;\"/>";
                str += "<input type=\"text\" style=\"width: 15%; text-align:center;\"/></td>";
                str += "</tr>";

            }
            return str;
        }

        /// <summary>
        /// 添加评分记录
        /// </summary>
        /// <param name="actor"></param>
        /// <param name="passive"></param>
        /// <param name="itemsid"></param>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <param name="forth"></param>
        /// <param name="fifth"></param>
        /// <returns></returns>
        [WebMethod]
        public bool addrecord(string actor, string passive, int itemsid, int first_item, int first_sub1, int first_sub2, int first_sub3, int first_sub4, int first_sub5,
            int second_item, int second_sub1, int second_sub2, int second_sub3, int second_sub4, int second_sub5,
            int third_item, int third_sub1, int third_sub2, int third_sub3, int third_sub4, int third_sub5,
            int forth_item, int forth_sub1, int forth_sub2, int forth_sub3, int forth_sub4, int forth_sub5,
            int fifth_item, int fifth_sub1, int fifth_sub2, int fifth_sub3, int fifth_sub4, int fifth_sub5)
        {
            return commentbll.FComment(actor, passive, itemsid, first_item, first_sub1, first_sub2, first_sub3, first_sub4, first_sub5, second_item, second_sub1, second_sub2, second_sub3, second_sub4, second_sub5, third_item, third_sub1, third_sub2, third_sub3, third_sub4, third_sub5, forth_item, forth_sub1, forth_sub2, forth_sub3, forth_sub4, forth_sub5, fifth_item, fifth_sub1, fifth_sub2, fifth_sub3, fifth_sub4, fifth_sub5);

        }


        /// <summary>
        /// 获取选择项目组的最大值
        /// </summary>
        /// <param name="ID">选择项目组ID</param>
        /// <returns></returns>
        [WebMethod]
        public string GetMaxValues(int ID)
        {
            SqlDataReader sr = commentbll.GetMaxValues(ID);
            string str = "";
            str += "{";
            while (sr.Read())
            {
                str += "\"first\":" + Convert.ToInt32(sr[1].ToString()) + ",\"second\":" + Convert.ToInt32(sr[2].ToString()) + ",\"third\":" + Convert.ToInt32(sr[3].ToString()) + ",\"forth\":" + Convert.ToInt32(sr[4].ToString()) + ",\"fifth\":" + Convert.ToInt32(sr[5].ToString()) + "}";
                break;
            }
            sr.Close();
            return str;
        }


        /// <summary>
        /// 获取项目组ID
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string GetItemsID()
        {
            SqlDataReader sr = commentbll.GetMaxItemId();
            int item = 0;
            while (sr.Read())
            {
                item = Convert.ToInt32(sr[0].ToString());
                break;
            }
            sr.Close();
            return item.ToString();
        }


        /// <summary>
        /// 设置某个用户不可登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        [WebMethod]
        public bool SetNotSubmiy(string username)
        {
            return userbll.SetNotSubmiy(username);
        }



        /// <summary>
        /// 获取是否可以登录
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [WebMethod]
        public bool GetIsCanComment(string username)
        {
            SqlDataReader sr = userbll.GetIsCanComment(username);
            bool iscan = false;
            while (sr.Read())
            {
                iscan = Convert.ToBoolean(sr[0].ToString());
                break;
            }
            return iscan;


        }



    }
}
