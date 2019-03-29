using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class AdminBLL
    {
        AdminDAL dal = new AdminDAL();
        /// <summary>
        /// 管理员登录 获取权限 更新最近一次登录时间
        /// </summary>
        /// <param name="username">管理员账号</param>
        /// <param name="pwd">管理员密码</param>
        /// <returns>权限</returns>
        public string Login(string username, string pwd)
        {
            return dal.Login(username, pwd);
        }


        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="username">管理员姓名</param>
        /// <param name="pwd">管理员密码</param>
        /// <param name="role">管理员权限</param>
        /// <returns>是否添加成功</returns>
        public bool AddAdmin(string username, string pwd, string role)
        {
            return dal.AddAdmin(username, pwd, role);
        }



        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns>是否修改成功</returns>
        public bool ModifyPwd(string username, string pwd)
        {
            return dal.ModifyPwd(username, pwd);
        }



        /// <summary>
        /// 判断管理员是否存在
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns>是否存在</returns>
        public bool IsExist(string username)
        {
            return dal.IsExist(username);

        }



        /// <summary>
        /// 删除管理员
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool DeleteAdminById(int ID)
        {
            return dal.DeleteAdminById(ID);
        }


        /// <summary>
        /// 获取所有管理员
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetAllAdmin_Delete()
        {
            return dal.GetAllAdmin_Delete();
        }
        
    }
}
