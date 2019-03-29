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
    /// DeleteService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class DeleteService : System.Web.Services.WebService
    {

        UserBLL userbll = new UserBLL();
        AdminBLL adminbll = new AdminBLL();



        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteStaffById(int ID)
        {
            return userbll.DeleteStaffById(ID);
        }


        /// <summary>
        /// 获取所有员工
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string GetAllStaff_Delete()
        {
            SqlDataReader sr = userbll.GetAllStaff();
            string str = "";
            while (sr.Read()) {
                //<td><input type="checkbox" style="height:100%;width:100%; text-align:center;"></td>
                str += "<tr>" + "<td>" + sr[0].ToString() + "</td>";
                str += "<td>" + sr[1].ToString() + "</td>";   
                    str += "<td>普通用户</td>";
                    str += "<td><input type=\"checkbox\" style=\"height:100%;width:100%; text-align:center;\"></td>";        
            }
            return str;
        }



        /// <summary>
        /// 删除管理员
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteAdminById(int ID)
        {
            return adminbll.DeleteAdminById(ID);
        }


        /// <summary>
        /// 获取所有管理员
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string GetAllAdmin_Delete()
        {
            SqlDataReader sr = adminbll.GetAllAdmin_Delete();
            string str = "";
            while (sr.Read()) {
                //<td><input type="checkbox" style="height:100%;width:100%; text-align:center;"></td>
                str += "<tr>" + "<td>" + sr[0].ToString() + "</td>";
                str += "<td>" + sr[1].ToString() + "</td>";
                    str += "<td>系统管理员</td>";
                    str += "<td><input type=\"checkbox\" style=\"height:100%;width:100%; text-align:center;\"></td>";
            }

            return str;
        }
    }
}
