using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        SqlDb db = new SqlDb();


        /// <summary>
        /// 普通用户登录  登录之后更新最后一次登录时间
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>登录状态</returns>
        public bool Login(string username, string pwd)
        {
            string strsql = "select * from Staff where Staff_Name=@name and Staff_Pwd=@pwd";
            SqlParameter []paras={new SqlParameter("name",username),new SqlParameter("pwd",pwd)};
            DataTable dt = db.FillDt(strsql, paras);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else {
                string time = DateTime.Now.ToString();
                string strsql2 = "update Staff set Last_LoginTime=@time where Staff_Name=@username";
                SqlParameter[] paras2 = { new SqlParameter("time", time), new SqlParameter("username", username) };
                db.executeSql(strsql2, paras2);
                return true;
            }
        }


        /// <summary>
        /// 用户是否能给别人评分
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public bool IsCanComment(string username) {
            bool can = false;
            string strsql = "select Is_CanComment from Staff where Staff_Name =@username";
            SqlParameter[] paras = { new SqlParameter("username", username) };
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            try
            {
                while (sr.Read())
                {
                    if (Convert.ToBoolean(sr[0].ToString()))
                    {
                        can = true;
                        break;
                    }
                }
            }
            catch (Exception ex) { 
            
            }
            sr.Close();
            return can;
        }



        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="username">用户名称</param>
        /// <param name="pwd">用户密码</param>
        /// <returns>返回是否添加成功</returns>
        public bool AddUser(string username, string pwd)
        {
            string strsql = "insert into Staff (Staff_Name,Staff_Pwd) values(@username,@pwd)";
            SqlParameter[] paras = { new SqlParameter("username", username), new SqlParameter("pwd", pwd) };
            return db.executeSql(strsql, paras);
        }


        /// <summary>
        /// 设置某个用户可参与评分
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        public bool SetCanJoin(int UserID)
        {
            string strsql = "update Staff set Is_Join=1 where StaffID=@ID";
            SqlParameter[] paras = { new SqlParameter("ID", UserID) };
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 设置某个用户不可参与评分
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        public bool SetNotJoin(int UserID)
        {
            string strsql = "update Staff set Is_Join=0 where StaffID=@ID";
            SqlParameter[] paras = { new SqlParameter("ID", UserID) };
            return db.executeSql(strsql, paras);
        }




        /// <summary>
        /// 设置某个用户可登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        public bool SetCanComment(int UserID)
        {
            string strsql = "update Staff set Is_CanComment=1 where StaffID=@ID";
            SqlParameter[] paras = { new SqlParameter("ID", UserID) };
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 设置某个用户不可登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        public bool SetNotComment(int UserID)
        {
            string strsql = "update Staff set Is_CanComment=0 where StaffID=@ID";
            SqlParameter[] paras = { new SqlParameter("ID", UserID) };
            return db.executeSql(strsql, paras);
        }


        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns>是否修改成功</returns>
        public bool ModifyPwd(string username, string pwd) {
            string strsql = "update Staff set Staff_Pwd=@pwd where Staff_Name=@username";
            SqlParameter[] paras = { new SqlParameter("@username", username), new SqlParameter("pwd", pwd) };
            return db.executeSql(strsql, paras);
        }


        /// <summary>
        /// 获取所有员工
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetAllStaff() {
            string strsql = "select StaffID,Staff_Name,Is_Join,Is_CanComment from Staff";
            SqlParameter []paras={};
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }



        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns>是否存在</returns>
        public bool IsExist(string username) {
            string strsql = "select * from Staff where Staff_Name=@username";
            SqlParameter []paras={new SqlParameter("username",username)};
            DataTable dt = db.FillDt(strsql, paras);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else {
                return true;
            }
            
        }



        /// <summary>
        /// 设置某个用户不可登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        public bool SetNotSubmiy(string username)
        {
            string strsql = "update Staff set Is_CanComment=0 where Staff_Name=@username";
            SqlParameter[] paras = { new SqlParameter("username", username) };
            return db.executeSql(strsql, paras);
        }


        /// <summary>
        /// 获取是否可以登录
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public SqlDataReader GetIsCanComment(string username) {
            string strsql = "select Is_CanComment from Staff where Staff_Name=@username";
            SqlParameter[] paras = { new SqlParameter("@username", username) };
            return db.GetDataReader_ZUO(strsql, paras);
        }


        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool DeleteStaffById(int ID) {
            string strsql = "delete  from Staff where StaffID=@ID";
            SqlParameter[] paras = { new SqlParameter("ID", ID) };
            return db.executeSql(strsql, paras);
        }


        /// <summary>
        /// 获取所有员工
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetAllStaff_Delete() {
            string strsql = "select * from Staff";
            SqlParameter[] paras = { };
            return db.GetDataReader_ZUO(strsql, paras);
        }
    }
}
