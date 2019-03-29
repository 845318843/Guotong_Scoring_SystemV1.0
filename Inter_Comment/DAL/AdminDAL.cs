using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminDAL
    {
        SqlDb db = new SqlDb();

        /// <summary>
        /// 管理员登录 获取权限 更新最近一次登录时间
        /// </summary>
        /// <param name="username">管理员账号</param>
        /// <param name="pwd">管理员密码</param>
        /// <returns>权限</returns>
        public string Login(string username, string pwd)
        {
            string strsql = "select role from Administrator where Account=@username and Pwd=@pwd";
            SqlParameter[] paras = { new SqlParameter("@username", username), new SqlParameter("pwd", pwd) };
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            string role = "";
            while (sr.Read()) {
                role = sr[0].ToString();
                break;
            }
            if (role == "") {
                string time = DateTime.Now.ToString();
                string strsql2 = "update Adminstrator set Last_LoginTime=@time where Account=@account";
                SqlParameter[] paras2 = { new SqlParameter("time", time),new SqlParameter("account", username) };
                db.executeSql(strsql2, paras2);
            }
            sr.Close();
            return role;
        }


        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="username">管理员姓名</param>
        /// <param name="pwd">管理员密码</param>
        /// <param name="role">管理员权限</param>
        /// <returns>是否添加成功</returns>
        public bool AddAdmin(string username, string pwd,string role)
        {
            string strsql = "insert into Administrator (Account,Pwd,Role) values(@account,@pwd,@role)";
            SqlParameter[] paras = { new SqlParameter("@account", username), new SqlParameter("pwd", pwd), new SqlParameter("role", role) };
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns>是否修改成功</returns>
        public bool ModifyPwd(string username, string pwd)
        {
            string strsql = "update Administrator set Pwd=@pwd where Account=@username";
            SqlParameter[] paras = { new SqlParameter("@username", username), new SqlParameter("pwd", pwd) };
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 判断管理员是否存在
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns>是否存在</returns>
        public bool IsExist(string username)
        {
            string strsql = "select * from Administrator where Account=@username";
            SqlParameter[] paras = { new SqlParameter("username", username) };
            DataTable dt = db.FillDt(strsql, paras);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }



        /// <summary>
        /// 删除管理员
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool DeleteAdminById(int ID)
        {
            string strsql = "delete  from Administrator where AdminID=@ID";
            SqlParameter[] paras = { new SqlParameter("ID", ID) };
            return db.executeSql(strsql, paras);
        }


        /// <summary>
        /// 获取所有管理员
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetAllAdmin_Delete()
        {
            string strsql = "select * from Administrator";
            SqlParameter[] paras = { };
            return db.GetDataReader_ZUO(strsql, paras);
        }
       
    }
}
