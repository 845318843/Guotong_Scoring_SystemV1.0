using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BLL;

namespace Inter_Comment
{
    /// <summary>
    /// ModifyService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class ModifyService : System.Web.Services.WebService
    {
        UserBLL userbll = new UserBLL();
        AdminBLL adminbll = new AdminBLL();

        /// <summary>
        /// 修改普通用户密码
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [WebMethod]
        public string ModifyUserPwd(string username, string pwd) {
            if (userbll.ModifyPwd(username, pwd))
            {
                return "密码修改成功";
            }
            else {
                return "密码修改失败";
            }
        }


        /// <summary>
        /// 修改管理员密码
        /// </summary>
        /// <param name="account"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [WebMethod]
        public string ModifyAdminPwd(string account, string pwd) {
            if (adminbll.ModifyPwd(account, pwd))
            {
                return "密码修改成功";
            }
            else {
                return "密码修改失败";
            }
        }
    }
}
