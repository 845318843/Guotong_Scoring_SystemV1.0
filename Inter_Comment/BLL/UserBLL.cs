using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class UserBLL
    {
        UserDAL dal = new UserDAL();

        /// <summary>
        /// 普通用户登录  登录之后更新最后一次登录时间
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>登录状态</returns>
        public bool Login(string username, string pwd)
        {
            return dal.Login(username, pwd);
        }



        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="username">用户名称</param>
        /// <param name="pwd">用户密码</param>
        /// <returns>返回是否添加成功</returns>
        public bool AddUser(string username, string pwd)
        {
            return dal.AddUser(username, pwd);
        }


        /// <summary>
        /// 用户是否能给别人评分
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public bool IsCanComment(string username)
        {
            return dal.IsCanComment(username);
        }


        /// <summary>
        /// 设置某个用户可参与评分
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        public bool SetCanJoin(int UserID)
        {
            return dal.SetCanJoin(UserID);
        }



        /// <summary>
        /// 设置某个用户不可参与评分
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        public bool SetNotJoin(int UserID)
        {
            return dal.SetNotJoin(UserID);
        }



        /// <summary>
        /// 设置某个用户可登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        public bool SetCanComment(int UserID)
        {
            return dal.SetCanComment(UserID);
        }



        /// <summary>
        /// 设置某个用户不可登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        public bool SetNotComment(int UserID)
        {
            return dal.SetNotComment(UserID);
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
        /// 获取所有员工
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetAllStaff()
        {
            return dal.GetAllStaff();
        }



        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns>是否存在</returns>
        public bool IsExist(string username)
        {
            return dal.IsExist(username);
        }



        /// <summary>
        /// 设置某个用户不可登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>是否设置成功</returns>
        public bool SetNotSubmiy(string username)
        {
            return dal.SetNotSubmiy(username);
        }


        /// <summary>
        /// 获取是否可以登录
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public SqlDataReader GetIsCanComment(string username)
        {
            return dal.GetIsCanComment(username);
        }




        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool DeleteStaffById(int ID)
        {
            return dal.DeleteStaffById(ID);
        }


        /// <summary>
        /// 获取所有员工
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetAllStaff_Delete()
        {
            return dal.GetAllStaff_Delete();
        }
    }
}
