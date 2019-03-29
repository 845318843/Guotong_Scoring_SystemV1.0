using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CommentDAL
    {
        SqlDb db = new SqlDb();
        /// <summary>
        /// 添加评分记录
        /// </summary>
        /// <param name="actor">评分人</param>
        /// <param name="passive">被评分人</param>
        /// <param name="itemsid">项目ID</param>
        /// <param name="first_item">项目一总分</param>
        /// <param name="first_sub1">第一大项第一小项分数</param>
        /// <param name="first_sub2"></param>
        /// <param name="first_sub3"></param>
        /// <param name="first_sub4"></param>
        /// <param name="first_sub5"></param>
        /// <param name="second_item"></param>
        /// <param name="second_sub1"></param>
        /// <param name="second_sub2"></param>
        /// <param name="second_sub3"></param>
        /// <param name="second_sub4"></param>
        /// <param name="second_sub5"></param>
        /// <param name="third_item"></param>
        /// <param name="third_sub1"></param>
        /// <param name="third_sub2"></param>
        /// <param name="third_sub3"></param>
        /// <param name="third_sub4"></param>
        /// <param name="third_sub5"></param>
        /// <param name="forth_item"></param>
        /// <param name="forth_sub1"></param>
        /// <param name="forth_sub2"></param>
        /// <param name="forth_sub3"></param>
        /// <param name="forth_sub4"></param>
        /// <param name="forth_sub5"></param>
        /// <param name="fifth_item"></param>
        /// <param name="fifth_sub1"></param>
        /// <param name="fifth_sub2"></param>
        /// <param name="fifth_sub3"></param>
        /// <param name="fifth_sub4"></param>
        /// <param name="fifth_sub5"></param>
        /// <returns></returns>
        public bool FComment(string actor, string passive, int itemsid, int first_item, int first_sub1, int first_sub2, int first_sub3, int first_sub4, int first_sub5,
            int second_item, int second_sub1, int second_sub2, int second_sub3, int second_sub4, int second_sub5,
            int third_item, int third_sub1, int third_sub2, int third_sub3, int third_sub4, int third_sub5,
            int forth_item, int forth_sub1, int forth_sub2, int forth_sub3, int forth_sub4, int forth_sub5,
            int fifth_item, int fifth_sub1, int fifth_sub2, int fifth_sub3, int fifth_sub4, int fifth_sub5)
        {
            string times = DateTime.Now.ToString();
            string strsql = "insert into F_Record (Actor,Passive,ItemsID,First_Item,First_Sub1,First_Sub2,First_Sub3,First_Sub4,First_Sub5,  Second_Item,Second_Sub1,Second_Sub2,Second_Sub3,Second_Sub4,Second_Sub5,  Third_Item,Third_Sub1,Third_Sub2,Third_Sub3,Third_Sub4,Third_Sub5,  Forth_Item,Forth_Sub1,Forth_Sub2,Forth_Sub3,Forth_Sub4,Forth_Sub5,  Fifth_Item,Fifth_Sub1,Fifth_Sub2,Fifth_Sub3,Fifth_Sub4,Fifth_Sub5,Comment_Time) values(@actor,@passive,@itemsid,@first_item,@first_sub1,@first_sub2,@first_sub3,@first_sub4,@first_sub5,  @second_item,@second_sub1,@second_sub2,@second_sub3,@second_sub4,@second_sub5,  @third_item,@third_sub1,@third_sub2,@third_sub3,@third_sub4,@third_sub5,  @forth_item,@forth_sub1,@forth_sub2,@forth_sub3,@forth_sub4,@forth_sub5,  @fifth_item,@fifth_sub1,@fifth_sub2,@fifth_sub3,@fifth_sub4,@fifth_sub5,@time)";
            SqlParameter [] paras ={new SqlParameter("actor",actor),new SqlParameter("passive",passive),
                                 new SqlParameter("itemsid",itemsid),new SqlParameter("first_item",first_item),
                                 new SqlParameter("first_sub1",first_sub1),new SqlParameter("first_sub2",first_sub2),
                                 new SqlParameter("first_sub3",first_sub3),new SqlParameter("first_sub4",first_sub4),
                                 new SqlParameter("first_sub5",first_sub5),new SqlParameter("second_item",second_item),
                                 new SqlParameter("second_sub1",second_sub1),new SqlParameter("second_sub2",second_sub2),
                                 new SqlParameter("second_sub3",second_sub3),new SqlParameter("second_sub4",second_sub4),
                                 new SqlParameter("second_sub5",second_sub5),new SqlParameter("third_item",third_item),
                                 new SqlParameter("third_sub1",third_sub1),new SqlParameter("third_sub2",third_sub2),
                                 new SqlParameter("third_sub3",third_sub3),new SqlParameter("third_sub4",third_sub4),
                                 new SqlParameter("third_sub5",third_sub5),new SqlParameter("forth_item",forth_item),
                                 new SqlParameter("forth_sub1",forth_sub1),new SqlParameter("forth_sub2",forth_sub2),
                                 new SqlParameter("forth_sub3",forth_sub3),new SqlParameter("forth_sub4",forth_sub4),
                                 new SqlParameter("forth_sub5",forth_sub5),new SqlParameter("fifth_item",fifth_item),
                                 new SqlParameter("fifth_sub1",fifth_sub1),new SqlParameter("fifth_sub2",fifth_sub2),
                                 new SqlParameter("fifth_sub3",fifth_sub3),new SqlParameter("fifth_sub4",fifth_sub4),
                                 new SqlParameter("fifth_sub5",fifth_sub5),new SqlParameter("time",times)};
            return db.executeSql(strsql, paras);
        }


        /// <summary>
        /// 获取选择项目组的最大值
        /// </summary>
        /// <param name="ID">选择项目组ID</param>
        /// <returns></returns>
        public SqlDataReader GetMaxValues(int ID) {
            string strsql = "select * from F_MValue where ID=@ID";
            SqlParameter []paras={new SqlParameter("ID",ID)};
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }


        /// <summary>
        /// 获取最大值项目组的编号
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetMaxItemId() {
            string strsql = "select StartNum from Start where ID=1";
            SqlParameter[] paras = { };
            return db.GetDataReader_ZUO(strsql, paras);
            
        }
    }
}
