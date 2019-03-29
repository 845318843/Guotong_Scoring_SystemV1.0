using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SetDAL
    {
        SqlDb db = new SqlDb();

        /// <summary>
        /// 获取项目组的最大编号 最后加一
        /// </summary>
        /// <returns></returns>
        public int GetMaxID()
        {
            string strsql = "select max(ID) from Five_Items";
            SqlParameter[] paras = { };
            SqlDataReader sr = db.GetDataReader_ZUO(strsql, paras);
            int maxid = 0;
            while (sr.Read())
            {
                maxid = Convert.ToInt32(sr[0].ToString());
                break;
            }
            return maxid + 1;
        }


        /// <summary>
        /// 添加项目组
        /// </summary>
        /// <param name="id">项目组Id</param>
        /// <param name="theme">主题</param>
        /// <param name="firstitem">第一大项内容</param>
        /// <param name="firstkeyword">第一大项关键字</param>
        /// <param name="firstsub1">第一大项第一小项内容</param>
        /// <param name="firstsub2"></param>
        /// <param name="firstsub3"></param>
        /// <param name="firstsub4"></param>
        /// <param name="firstsub5"></param>
        /// <param name="seconditem"></param>
        /// <param name="secondkeyword"></param>
        /// <param name="secondsub1"></param>
        /// <param name="secondsub2"></param>
        /// <param name="secondsub3"></param>
        /// <param name="secondsub4"></param>
        /// <param name="secondsub5"></param>
        /// <param name="thirditem"></param>
        /// <param name="thirdkeyword"></param>
        /// <param name="thirdsub1"></param>
        /// <param name="thirdsub2"></param>
        /// <param name="thirdsub3"></param>
        /// <param name="thirdsub4"></param>
        /// <param name="thirdsub5"></param>
        /// <param name="forthitem"></param>
        /// <param name="forthkeyword"></param>
        /// <param name="forthsub1"></param>
        /// <param name="forthsub2"></param>
        /// <param name="forthsub3"></param>
        /// <param name="forthsub4"></param>
        /// <param name="forthsub5"></param>
        /// <param name="fifthitem"></param>
        /// <param name="fifthkeyword"></param>
        /// <param name="fifthsub1"></param>
        /// <param name="fifthsub2"></param>
        /// <param name="fifthsub3"></param>
        /// <param name="fifthsub4"></param>
        /// <param name="fifthsub5"></param>
        /// <returns></returns>
        public bool addItem(int id, string theme, string firstitem, string firstkeyword, string firstsub1, string firstsub2, string firstsub3, string firstsub4, string firstsub5, string seconditem, string secondkeyword, string secondsub1, string secondsub2, string secondsub3, string secondsub4, string secondsub5,
            string thirditem, string thirdkeyword, string thirdsub1, string thirdsub2, string thirdsub3, string thirdsub4, string thirdsub5,
                string forthitem, string forthkeyword, string forthsub1, string forthsub2, string forthsub3, string forthsub4, string forthsub5,
            string fifthitem, string fifthkeyword, string fifthsub1, string fifthsub2, string fifthsub3, string fifthsub4, string fifthsub5
            )
        {
            string strsql = "insert into Five_Items (ID,Theme,First_Item,First_KeyWord,First_Sub1,First_Sub2,First_Sub3,First_Sub4,First_Sub5,  Second_Item,Second_KeyWord,Second_Sub1,Second_Sub2,Second_Sub3,Second_Sub4,Second_Sub5,   Third_Item,Third_KeyWord,Third_Sub1,Third_Sub2,Third_Sub3,Third_Sub4,Third_Sub5,  Forth_Item,Forth_KeyWord,Forth_Sub1,Forth_Sub2,Forth_Sub3,Forth_Sub4,Forth_Sub5,  Fifth_Item,Fifth_KeyWord,Fifth_Sub1,Fifth_Sub2,Fifth_Sub3,Fifth_Sub4,Fifth_Sub5) values(@id,@theme,@firstitem,@firstkeyword,@firstsub1,@firstsub2,@firstsub3,@firstsub4,@firstsub5,  @seconditem,@secondkeyword,@secondsub1,@secondsub2,@secondsub3,@secondsub4,@secondsub5,   @thirditem,@thirdkeyword,@thirdsub1,@thirdsub2,@thirdsub3,@thirdsub4,@thirdsub5,  @forthitem,@forthkeyword,@forthsub1,@forthsub2,@forthsub3,@forthsub4,@forthsub5,  @fifthitem,@fifthkeyword,@fifthsub1,@fifthsub2,@fifthsub3,@fifthsub4,@fifthsub5)";
            SqlParameter[] paras ={new SqlParameter("id",id),new SqlParameter("theme",theme),
                                 new SqlParameter("firstitem",firstitem),new SqlParameter("firstkeyword",firstkeyword),
                                 new SqlParameter("firstsub1",firstsub1),new SqlParameter("firstsub2",firstsub2),
                                 new SqlParameter("firstsub3",firstsub3),new SqlParameter("firstsub4",firstsub4),
                                  new SqlParameter("firstsub5",firstsub5),new SqlParameter("seconditem",seconditem),new SqlParameter("secondkeyword",secondkeyword),
                                 new SqlParameter("secondsub1",secondsub1),new SqlParameter("secondsub2",secondsub2),
                                 new SqlParameter("secondsub3",secondsub3),new SqlParameter("secondsub4",secondsub4),
                                  new SqlParameter("secondsub5",secondsub5),new SqlParameter("thirditem",thirditem),new SqlParameter("thirdkeyword",thirdkeyword),
                                 new SqlParameter("thirdsub1",thirdsub1),new SqlParameter("thirdsub2",thirdsub2),
                                 new SqlParameter("thirdsub3",thirdsub3),new SqlParameter("thirdsub4",thirdsub4),
                                  new SqlParameter("thirdsub5",thirdsub5),new SqlParameter("forthitem",forthitem),new SqlParameter("forthkeyword",forthkeyword),
                                 new SqlParameter("forthsub1",forthsub1),new SqlParameter("forthsub2",forthsub2),
                                 new SqlParameter("forthsub3",forthsub3),new SqlParameter("forthsub4",forthsub4),
                                  new SqlParameter("forthsub5",forthsub5),new SqlParameter("fifthitem",fifthitem),new SqlParameter("fifthkeyword",fifthkeyword),
                                 new SqlParameter("fifthsub1",fifthsub1),new SqlParameter("fifthsub2",fifthsub2),
                                 new SqlParameter("fifthsub3",fifthsub3),new SqlParameter("fifthsub4",fifthsub4),
                                  new SqlParameter("fifthsub5",fifthsub5)};
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 添加最大分值
        /// </summary>
        /// <param name="id">相应id</param>
        /// <param name="firstvalue">第一大项总分</param>
        /// <param name="firstsub1">第一大项第一小项总分</param>
        /// <param name="firstsub2"></param>
        /// <param name="firstsub3"></param>
        /// <param name="firstsub4"></param>
        /// <param name="firstsub5"></param>
        /// <param name="secondvalue"></param>
        /// <param name="secondsub1"></param>
        /// <param name="secondsub2"></param>
        /// <param name="secondsub3"></param>
        /// <param name="secondsub4"></param>
        /// <param name="secondsub5"></param>
        /// <param name="thirdvalue"></param>
        /// <param name="thirdsub1"></param>
        /// <param name="thirdsub2"></param>
        /// <param name="thirdsub3"></param>
        /// <param name="thirdsub4"></param>
        /// <param name="thirdsub5"></param>
        /// <param name="forthvalue"></param>
        /// <param name="forthsub1"></param>
        /// <param name="forthsub2"></param>
        /// <param name="forthsub3"></param>
        /// <param name="forthsub4"></param>
        /// <param name="forthsub5"></param>
        /// <param name="fifthvalue"></param>
        /// <param name="fifthsub1"></param>
        /// <param name="fifthsub2"></param>
        /// <param name="fifthsub3"></param>
        /// <param name="fifthsub4"></param>
        /// <param name="fifthsub5"></param>
        /// <returns></returns>
        public bool addValues(int id, int firstvalue, int firstsub1, int firstsub2, int firstsub3, int firstsub4, int firstsub5,
            int secondvalue, int secondsub1, int secondsub2, int secondsub3, int secondsub4, int secondsub5,
            int thirdvalue, int thirdsub1, int thirdsub2, int thirdsub3, int thirdsub4, int thirdsub5,
            int forthvalue, int forthsub1, int forthsub2, int forthsub3, int forthsub4, int forthsub5,
            int fifthvalue, int fifthsub1, int fifthsub2, int fifthsub3, int fifthsub4, int fifthsub5)
        {
            string strsql = "insert into F_MValue (ID,First_Value,First_Sub1,First_Sub2,First_Sub3,First_Sub4,First_Sub5,  Second_Value,Second_Sub1,Second_Sub2,Second_Sub3,Second_Sub4,Second_Sub5,  Third_Value,Third_Sub1,Third_Sub2,Third_Sub3,Third_Sub4,Third_Sub5,  Forth_Value,Forth_Sub1,Forth_Sub2,Forth_Sub3,Forth_Sub4,Forth_Sub5,  Fifth_Value,Fifth_Sub1,Fifth_Sub2,Fifth_Sub3,Fifth_Sub4,Fifth_Sub5) values(@id,@firstvalue,@firstsub1,@firstsub2,@firstsub3,@firstsub4,@firstsub5,  @secondvalue,@secondsub1,@secondsub2,@secondsub3,@secondsub4,@secondsub5,  @thirdvalue,@thirdsub1,@thirdsub2,@thirdsub3,@thirdsub4,@thirdsub5,  @forthvalue,@forthsub1,@forthsub2,@forthsub3,@forthsub4,@forthsub5,  @fifthvalue,@fifthsub1,@fifthsub2,@fifthsub3,@fifthsub4,@fifthsub5)";
            SqlParameter[] paras ={new SqlParameter("id",id),new SqlParameter("firstvalue",firstvalue),
                                 new SqlParameter("firstsub1",firstsub1),new SqlParameter("firstsub2",firstsub2),
                                 new SqlParameter("firstsub3",firstsub3),new SqlParameter("firstsub4",firstsub4),
                                 new SqlParameter("firstsub5",firstsub5),new SqlParameter("secondvalue",secondvalue),
                                 new SqlParameter("secondsub1",secondsub1),new SqlParameter("secondsub2",secondsub2),
                                 new SqlParameter("secondsub3",secondsub3),new SqlParameter("secondsub4",secondsub4),
                                 new SqlParameter("secondsub5",secondsub5),new SqlParameter("thirdvalue",thirdvalue),
                                 new SqlParameter("thirdsub1",thirdsub1),new SqlParameter("thirdsub2",thirdsub2),
                                 new SqlParameter("thirdsub3",thirdsub3),new SqlParameter("thirdsub4",thirdsub4),
                                 new SqlParameter("thirdsub5",thirdsub5),new SqlParameter("forthvalue",forthvalue),
                                 new SqlParameter("forthsub1",forthsub1),new SqlParameter("forthsub2",forthsub2),
                                 new SqlParameter("forthsub3",forthsub3),new SqlParameter("forthsub4",forthsub4),
                                 new SqlParameter("forthsub5",forthsub5),new SqlParameter("fifthvalue",fifthvalue),
                                 new SqlParameter("fifthsub1",fifthsub1),new SqlParameter("fifthsub2",fifthsub2),
                                 new SqlParameter("fifthsub3",fifthsub3),new SqlParameter("fifthsub4",fifthsub4),
                                 new SqlParameter("fifthsub5",fifthsub5),};
            return db.executeSql(strsql, paras);
        }




        /// <summary>
        /// 修改项目组
        /// </summary>
        /// <param name="id">项目组ID</param>
        /// <param name="theme">项目组标题</param>
        /// <param name="firstitem">第一大项内容</param>
        /// <param name="firstkeyword">第一大项关键字</param>
        /// <param name="firstsub1">第一大项第一小项内容</param>
        /// <param name="firstsub2"></param>
        /// <param name="firstsub3"></param>
        /// <param name="firstsub4"></param>
        /// <param name="firstsub5"></param>
        /// <param name="seconditem"></param>
        /// <param name="secondkeyword"></param>
        /// <param name="secondsub1"></param>
        /// <param name="secondsub2"></param>
        /// <param name="secondsub3"></param>
        /// <param name="secondsub4"></param>
        /// <param name="secondsub5"></param>
        /// <param name="thirditem"></param>
        /// <param name="thirdkeyword"></param>
        /// <param name="thirdsub1"></param>
        /// <param name="thirdsub2"></param>
        /// <param name="thirdsub3"></param>
        /// <param name="thirdsub4"></param>
        /// <param name="thirdsub5"></param>
        /// <param name="forthitem"></param>
        /// <param name="forthkeyword"></param>
        /// <param name="forthsub1"></param>
        /// <param name="forthsub2"></param>
        /// <param name="forthsub3"></param>
        /// <param name="forthsub4"></param>
        /// <param name="forthsub5"></param>
        /// <param name="fifthitem"></param>
        /// <param name="fifthkeyword"></param>
        /// <param name="fifthsub1"></param>
        /// <param name="fifthsub2"></param>
        /// <param name="fifthsub3"></param>
        /// <param name="fifthsub4"></param>
        /// <param name="fifthsub5"></param>
        /// <returns></returns>
        public bool AlterItem(int id, string theme, string firstitem, string firstkeyword, string firstsub1, string firstsub2, string firstsub3, string firstsub4, string firstsub5, string seconditem, string secondkeyword, string secondsub1, string secondsub2, string secondsub3, string secondsub4, string secondsub5,
            string thirditem, string thirdkeyword, string thirdsub1, string thirdsub2, string thirdsub3, string thirdsub4, string thirdsub5,
                string forthitem, string forthkeyword, string forthsub1, string forthsub2, string forthsub3, string forthsub4, string forthsub5,
            string fifthitem, string fifthkeyword, string fifthsub1, string fifthsub2, string fifthsub3, string fifthsub4, string fifthsub5)
        {
            string strsql = "update Five_Items set Theme=@theme,First_Item=@firstitem,First_KeyWord=@firstkeyword,First_Sub1=@firstsub1,First_Sub2=@firstsub2,First_Sub3=@firstsub3,First_Sub4=@firstsub4,First_Sub5=@firstsub5,  Second_Item=@seconditem,Second_KeyWord=@secondkeyword,Second_Sub1=@secondsub1,Second_Sub2=@secondsub2,Second_Sub3=@secondsub3,Second_Sub4=@secondsub4,Second_Sub5=@secondsub5,  Third_Item=@thirditem,Third_KeyWord=@thirdkeyword,Third_Sub1=@thirdsub1,Third_Sub2=@thirdsub2,Third_Sub3=@thirdsub3,Third_Sub4=@thirdsub4,Third_Sub5=@thirdsub5,  Forth_Item=@forthitem,Forth_KeyWord=@forthkeyword,Forth_Sub1=@forthsub1,Forth_Sub2=@forthsub2,Forth_Sub3=@forthsub3,Forth_Sub4=@forthsub4,Forth_Sub5=@forthsub5,  Fifth_Item=@fifthitem,Fifth_KeyWord=@fifthkeyword,Fifth_Sub1=@fifthsub1,Fifth_Sub2=@fifthsub2,Fifth_Sub3=@fifthsub3,Fifth_Sub4=@fifthsub4,Fifth_Sub5=@fifthsub5 where ID=@id";
            SqlParameter[] paras ={new SqlParameter("id",id),new SqlParameter("theme",theme),
                                 new SqlParameter("firstitem",firstitem),new SqlParameter("firstkeyword",firstkeyword),
                                 new SqlParameter("firstsub1",firstsub1),new SqlParameter("firstsub2",firstsub2),
                                 new SqlParameter("firstsub3",firstsub3),new SqlParameter("firstsub4",firstsub4),
                                  new SqlParameter("firstsub5",firstsub5), new SqlParameter("seconditem",seconditem),new SqlParameter("secondkeyword",secondkeyword),
                                 new SqlParameter("secondsub1",secondsub1),new SqlParameter("secondsub2",secondsub2),
                                 new SqlParameter("secondsub3",secondsub3),new SqlParameter("secondsub4",secondsub4),
                                  new SqlParameter("secondsub5",secondsub5), new SqlParameter("thirditem",thirditem),new SqlParameter("thirdkeyword",thirdkeyword),
                                 new SqlParameter("thirdsub1",thirdsub1),new SqlParameter("thirdsub2",thirdsub2),
                                 new SqlParameter("thirdsub3",thirdsub3),new SqlParameter("thirdsub4",thirdsub4),
                                  new SqlParameter("thirdsub5",thirdsub5), new SqlParameter("forthitem",forthitem),new SqlParameter("forthkeyword",forthkeyword),
                                 new SqlParameter("forthsub1",forthsub1),new SqlParameter("forthsub2",forthsub2),
                                 new SqlParameter("forthsub3",forthsub3),new SqlParameter("forthsub4",forthsub4),
                                  new SqlParameter("forthsub5",forthsub5), new SqlParameter("fifthitem",fifthitem),new SqlParameter("fifthkeyword",fifthkeyword),
                                 new SqlParameter("fifthsub1",fifthsub1),new SqlParameter("fifthsub2",fifthsub2),
                                 new SqlParameter("fifthsub3",fifthsub3),new SqlParameter("fifthsub4",fifthsub4),
                                  new SqlParameter("fifthsub5",fifthsub5)};
            return db.executeSql(strsql, paras);
        }


        /// <summary>
        /// 修改项目组分值
        /// </summary>
        /// <param name="id">项目组ID</param>
        /// <param name="firstvalue">第一项分值</param>
        /// <param name="firstsub1">第一大项第一小项分值</param>
        /// <param name="firstsub2"></param>
        /// <param name="firstsub3"></param>
        /// <param name="firstsub4"></param>
        /// <param name="firstsub5"></param>
        /// <param name="secondvalue"></param>
        /// <param name="secondsub1"></param>
        /// <param name="secondsub2"></param>
        /// <param name="secondsub3"></param>
        /// <param name="secondsub4"></param>
        /// <param name="secondsub5"></param>
        /// <param name="thirdvalue"></param>
        /// <param name="thirdsub1"></param>
        /// <param name="thirdsub2"></param>
        /// <param name="thirdsub3"></param>
        /// <param name="thirdsub4"></param>
        /// <param name="thirdsub5"></param>
        /// <param name="forthvalue"></param>
        /// <param name="forthsub1"></param>
        /// <param name="forthsub2"></param>
        /// <param name="forthsub3"></param>
        /// <param name="forthsub4"></param>
        /// <param name="forthsub5"></param>
        /// <param name="fifthvalue"></param>
        /// <param name="fifthsub1"></param>
        /// <param name="fifthsub2"></param>
        /// <param name="fifthsub3"></param>
        /// <param name="fifthsub4"></param>
        /// <param name="fifthsub5"></param>
        /// <returns></returns>
        public bool AlterValue(int id, int firstvalue, int firstsub1, int firstsub2, int firstsub3, int firstsub4, int firstsub5,
            int secondvalue, int secondsub1, int secondsub2, int secondsub3, int secondsub4, int secondsub5,
            int thirdvalue, int thirdsub1, int thirdsub2, int thirdsub3, int thirdsub4, int thirdsub5,
            int forthvalue, int forthsub1, int forthsub2, int forthsub3, int forthsub4, int forthsub5,
            int fifthvalue, int fifthsub1, int fifthsub2, int fifthsub3, int fifthsub4, int fifthsub5)
        {
            string strsql = "update F_MValue set First_Value=@firstvalue,First_Sub1=@firstsub1,First_Sub2=@firstsub2,First_Sub3=@firstsub3,First_Sub4=@firstsub4,First_Sub5=@firstsub5,  Second_Value=@secondvalue,Second_Sub1=@secondsub1,Second_Sub2=@secondsub2,Second_Sub3=@secondsub3,Second_Sub4=@secondsub4,Second_Sub5=@secondsub5,  Third_Value=@thirdvalue,Third_Sub1=@thirdsub1,Third_Sub2=@thirdsub2,Third_Sub3=@thirdsub3,Third_Sub4=@thirdsub4,Third_Sub5=@thirdsub5,  Forth_Value=@forthvalue,Forth_Sub1=@forthsub1,Forth_Sub2=@forthsub2,Forth_Sub3=@forthsub3,Forth_Sub4=@forthsub4,Forth_Sub5=@forthsub5,  Fifth_Value=@fifthvalue,Fifth_Sub1=@fifthsub1,Fifth_Sub2=@fifthsub2,Fifth_Sub3=@fifthsub3,Fifth_Sub4=@fifthsub4,Fifth_Sub5=@fifthsub5 where ID=@id";
            SqlParameter[] paras ={new SqlParameter("id",id),new SqlParameter("firstvalue",firstvalue),
                                 new SqlParameter("firstsub1",firstsub1),new SqlParameter("firstsub2",firstsub2),
                                 new SqlParameter("firstsub3",firstsub3),new SqlParameter("firstsub4",firstsub4),
                                  new SqlParameter("firstsub5",firstsub5),new SqlParameter("secondvalue",secondvalue),
                                 new SqlParameter("secondsub1",secondsub1),new SqlParameter("secondsub2",secondsub2),
                                 new SqlParameter("secondsub3",secondsub3),new SqlParameter("secondsub4",secondsub4),
                                  new SqlParameter("secondsub5",secondsub5),new SqlParameter("thirdvalue",thirdvalue),
                                 new SqlParameter("thirdsub1",thirdsub1),new SqlParameter("thirdsub2",thirdsub2),
                                 new SqlParameter("thirdsub3",thirdsub3),new SqlParameter("thirdsub4",thirdsub4),
                                  new SqlParameter("thirdsub5",thirdsub5),new SqlParameter("forthvalue",forthvalue),
                                 new SqlParameter("forthsub1",forthsub1),new SqlParameter("forthsub2",forthsub2),
                                 new SqlParameter("forthsub3",forthsub3),new SqlParameter("forthsub4",forthsub4),
                                  new SqlParameter("forthsub5",forthsub5),new SqlParameter("fifthvalue",fifthvalue),
                                 new SqlParameter("fifthsub1",fifthsub1),new SqlParameter("fifthsub2",fifthsub2),
                                 new SqlParameter("fifthsub3",fifthsub3),new SqlParameter("fifthsub4",fifthsub4),
                                  new SqlParameter("fifthsub5",fifthsub5),};
            return db.executeSql(strsql, paras);
        }


        /// <summary>
        /// 设置启动项目
        /// </summary>
        /// <param name="id">启动项ID</param>
        /// <returns></returns>
        public bool SetStartItem(int id)
        {
            string strsql = "update Start set StartNum=@id where ID=1";
            SqlParameter[] paras = { new SqlParameter("id", id) };
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 根据项目组Id获取项目内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetInfoById(int id)
        {
            string strsql = "select ID,Theme,First_Item,Second_Item,Third_Item,Forth_Item,Fifth_Item from Five_Items where ID=@id";
            SqlParameter[] paras = { new SqlParameter("id", id) };
            SqlDataReader sr;
            sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }



        /// <summary>
        /// 根据项目组Id获取项目内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetScoreById(int id)
        {
            string strsql = "select First_Value,Second_Value,Third_Value,Forth_Value,Fifth_Value from F_MValue where ID=@id";
            SqlParameter[] paras = { new SqlParameter("id", id) };
            SqlDataReader sr;
            sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }



        /// <summary>
        /// 根据项目组ID获取详细标题
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetMoreInfoById(int id) {
            string strsql = "select * from Five_Items where ID=@id";
            SqlParameter[] para = { new SqlParameter("@id", id) };
            SqlDataReader sr;
            sr = db.GetDataReader_ZUO(strsql, para);
            return sr;
        }


        /// <summary>
        /// 根据项目组ID获取详细分数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetMoreScoreById(int id) {
            string strsql = "select * from F_MValue where ID=@id";
            SqlParameter[] paras = { new SqlParameter("@id", id) };
            SqlDataReader sr;
            sr = db.GetDataReader_ZUO(strsql, paras);
            return sr;
        }
    }
}
