using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using BLL;

namespace Inter_Comment
{
    /// <summary>
    /// AddService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class AddService : System.Web.Services.WebService
    {
        UserBLL userbll = new UserBLL();
        AdminBLL adminbll = new AdminBLL();

        /// <summary>
        /// 判断普通用户是否存在
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [WebMethod]
        public bool UserIsExist(string username) {
            return userbll.IsExist(username);
        }


        /// <summary>
        /// 判断管理员是否存在
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [WebMethod]
        public bool AdminIsExist(string username) {
            return adminbll.IsExist(username);
        }



        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="username">用户名称</param>
        /// <param name="pwd">用户密码</param>
        /// <returns>返回是否添加成功</returns>
        [WebMethod]
        public bool AddUser(string username, string pwd)
        {
            return userbll.AddUser(username, pwd);
        }



        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="username">管理员姓名</param>
        /// <param name="pwd">管理员密码</param>
        /// <param name="role">管理员权限</param>
        /// <returns>是否添加成功</returns>
        [WebMethod]
        public bool AddAdmin(string username, string pwd, string role)
        {
            return adminbll.AddAdmin(username, pwd, role);
        }
        
    }
}
