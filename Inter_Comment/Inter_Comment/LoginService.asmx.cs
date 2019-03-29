using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BLL;

namespace Inter_Comment
{
    /// <summary>
    /// LoginService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class LoginService : System.Web.Services.WebService
    {
        UserBLL userbll = new UserBLL();
        AdminBLL adminbll = new AdminBLL();

        /// <summary>
        /// 普通用户登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns>返回登录信息</returns>
        [WebMethod]
        public string UserLogin(string username, string pwd) {
            if (userbll.Login(username, pwd))
            {
                return "登录成功";
            }
            else {
                return "登录失败";
            }
        }


        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="account"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [WebMethod]
        public string AdminLogin(string account, string pwd) {
            return adminbll.Login(account, pwd);
        }


        [WebMethod]
        public bool Is_CanComment(string username) {
            return userbll.IsCanComment(username);
        }


    }
}
