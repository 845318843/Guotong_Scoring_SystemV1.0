using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using BLL;

namespace Inter_Comment
{
    /// <summary>
    /// SetService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class SetService : System.Web.Services.WebService
    {
        UserBLL userbll = new UserBLL();

        /// <summary>
        /// 获取所有员工
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        [WebMethod]
        public string load()
        {
            SqlDataReader sr;
            sr = userbll.GetAllStaff();
            string str = "";
            while (sr.Read())
            {
                //<td><input type="checkbox" style="height:100%;width:100%; text-align:center;"></td>
                str += "<tr>" + "<td>" + sr[0].ToString() + "</td>";
                str += "<td>" + sr[1].ToString() + "</td>";
                if (Convert.ToBoolean(sr[2].ToString()) == false)
                {
                    str += "<td><input type=\"checkbox\" style=\"height:100%;width:100%; text-align:center;\"></td>";
                }
                else {
                    str += "<td><input type=\"checkbox\" style=\"height:100%;width:100%; text-align:center;\" checked=\"checked\"></td>";
                }

                if (Convert.ToBoolean(sr[3].ToString()) == false)
                {
                    str += "<td><input type=\"checkbox\" style=\"height:100%;width:100%; text-align:center;\"></td>";
                }
                else
                {
                    str += "<td><input type=\"checkbox\" style=\"height:100%;width:100%; text-align:center;\" checked=\"checked\"></td>";
                }

                str += "</tr>";

            }
            str+="<tr>";
            str += "<td>批量操作</td><td>批量操作</td><td><label style=\"height:100%; line-height:20px;\"><input type=\"checkbox\" id=\"select_all1\" name=\"ttt\" onchange=\"check1()\" />全选</label></td><td><label style=\"height:100%; line-height:20px;\"><input type=\"checkbox\" id=\"select_all2\" name=\"ttt\" onchange=\"check2()\" />全选</label></td>";
                str+="</tr>";
            return str;
        }


        /// <summary>
        /// 设置某个用户可参与评分
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        [WebMethod]
        public bool SetCanJoin(int UserID)
        {
            return userbll.SetCanJoin(UserID);
        }



        /// <summary>
        /// 设置某个用户不可参与评分
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        [WebMethod]
        public bool SetNotJoin(int UserID)
        {
            return userbll.SetNotJoin(UserID);
        }


        /// <summary>
        /// 设置某个用户可登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        [WebMethod]
        public bool SetCanComment(int UserID)
        {
            return userbll.SetCanComment(UserID);
        }



        /// <summary>
        /// 设置某个用户不可登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        [WebMethod]
        public bool SetNotComment(int UserID)
        {
            return userbll.SetNotComment(UserID);
        }


        [WebMethod]
        public bool ddd(int UserID) {
            return true;
        }
    }
}
