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
    /// Set2Service 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
     [System.Web.Script.Services.ScriptService]
    public class Set2Service : System.Web.Services.WebService
    {
        SetBLL setbll = new SetBLL();




        /// <summary>
        /// 获取项目组的最大编号 最后加一
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public int GetMaxID()
        {
            return setbll.GetMaxID();
        }


        /// <summary>
        /// 添加项目组
        /// </summary>
        /// <param name="id">项目ID</param>
        /// <param name="theme">项目标题</param>
        /// <param name="first">项目一</param>
        /// <param name="second">项目二</param>
        /// <param name="third">三</param>
        /// <param name="forth">四</param>
        /// <param name="fifth">五</param>
        /// <returns>是否插入成功</returns>
        [WebMethod]
        public bool addItem(int id, string theme, string firstitem, string firstkeyword, string firstsub1, string firstsub2, string firstsub3, string firstsub4, string firstsub5, string seconditem, string secondkeyword, string secondsub1, string secondsub2, string secondsub3, string secondsub4, string secondsub5,
            string thirditem, string thirdkeyword, string thirdsub1, string thirdsub2, string thirdsub3, string thirdsub4, string thirdsub5,
                string forthitem, string forthkeyword, string forthsub1, string forthsub2, string forthsub3, string forthsub4, string forthsub5,
            string fifthitem, string fifthkeyword, string fifthsub1, string fifthsub2, string fifthsub3, string fifthsub4, string fifthsub5
            ) { 
        return setbll.addItem( id,  theme,  firstitem,  firstkeyword,  firstsub1,  firstsub2,  firstsub3,  firstsub4,  firstsub5,  seconditem,  secondkeyword,  secondsub1,  secondsub2,  secondsub3,  secondsub4,  secondsub5, thirditem,  thirdkeyword,  thirdsub1,  thirdsub2,  thirdsub3,  thirdsub4,  thirdsub5, forthitem,  forthkeyword,  forthsub1,  forthsub2,  forthsub3,  forthsub4,  forthsub5, fifthitem,  fifthkeyword,  fifthsub1,  fifthsub2,  fifthsub3,  fifthsub4,  fifthsub5);
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
        [WebMethod]
        public bool addValues(int id, int firstvalue, int firstsub1, int firstsub2, int firstsub3, int firstsub4, int firstsub5,
            int secondvalue, int secondsub1, int secondsub2, int secondsub3, int secondsub4, int secondsub5,
            int thirdvalue, int thirdsub1, int thirdsub2, int thirdsub3, int thirdsub4, int thirdsub5,
            int forthvalue, int forthsub1, int forthsub2, int forthsub3, int forthsub4, int forthsub5,
            int fifthvalue, int fifthsub1, int fifthsub2, int fifthsub3, int fifthsub4, int fifthsub5)
        {
            return setbll.addValues(id, firstvalue, firstsub1, firstsub2, firstsub3, firstsub4, firstsub5, secondvalue, secondsub1, secondsub2, secondsub3, secondsub4, secondsub5, thirdvalue, thirdsub1, thirdsub2, thirdsub3, thirdsub4, thirdsub5, forthvalue, forthsub1, forthsub2, forthsub3, forthsub4, forthsub5, fifthvalue, fifthsub1, fifthsub2, fifthsub3, fifthsub4, fifthsub5);
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
        [WebMethod]
        public bool AlterItem(int id, string theme, string firstitem, string firstkeyword, string firstsub1, string firstsub2, string firstsub3, string firstsub4, string firstsub5, string seconditem, string secondkeyword, string secondsub1, string secondsub2, string secondsub3, string secondsub4, string secondsub5,
            string thirditem, string thirdkeyword, string thirdsub1, string thirdsub2, string thirdsub3, string thirdsub4, string thirdsub5,
                string forthitem, string forthkeyword, string forthsub1, string forthsub2, string forthsub3, string forthsub4, string forthsub5,
            string fifthitem, string fifthkeyword, string fifthsub1, string fifthsub2, string fifthsub3, string fifthsub4, string fifthsub5)
        {
            return setbll.AlterItem(id, theme, firstitem, firstkeyword, firstsub1, firstsub2, firstsub3, firstsub4, firstsub5, seconditem, secondkeyword, secondsub1, secondsub2, secondsub3, secondsub4, secondsub5, thirditem, thirdkeyword, thirdsub1, thirdsub2, thirdsub3, thirdsub4, thirdsub5, forthitem, forthkeyword, forthsub1, forthsub2, forthsub3, forthsub4, forthsub5, fifthitem, fifthkeyword, fifthsub1, fifthsub2, fifthsub3, fifthsub4, fifthsub5);
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
        [WebMethod]
        public bool AlterValue(int id, int firstvalue, int firstsub1, int firstsub2, int firstsub3, int firstsub4, int firstsub5,
            int secondvalue, int secondsub1, int secondsub2, int secondsub3, int secondsub4, int secondsub5,
            int thirdvalue, int thirdsub1, int thirdsub2, int thirdsub3, int thirdsub4, int thirdsub5,
            int forthvalue, int forthsub1, int forthsub2, int forthsub3, int forthsub4, int forthsub5,
            int fifthvalue, int fifthsub1, int fifthsub2, int fifthsub3, int fifthsub4, int fifthsub5)
        {
            return setbll.AlterValue(id, firstvalue, firstsub1, firstsub2, firstsub3, firstsub4, firstsub5, secondvalue, secondsub1, secondsub2, secondsub3, secondsub4, secondsub5, thirdvalue, thirdsub1, thirdsub2, thirdsub3, thirdsub4, thirdsub5, forthvalue, forthsub1, forthsub2, forthsub3, forthsub4, forthsub5, fifthvalue, fifthsub1, fifthsub2, fifthsub3, fifthsub4, fifthsub5);
        }


        /// <summary>
        /// 设置启动项目
        /// </summary>
        /// <param name="id">启动项ID</param>
        /// <returns></returns>
        [WebMethod]
        public bool SetStartItem(int id)
        {
            return setbll.SetStartItem(id);
        }




        /// <summary>
        /// 根据项目组Id获取项目内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public string GetInfoById(int id)
        {
            string str = "";
            SqlDataReader sr = setbll.GetInfoById(id);
            while (sr.Read()) {
                str += "{\"theme\":'" + sr[1].ToString() + "',\"first\":'" + sr[2].ToString() + "',\"second\":'" + sr[3].ToString() + "',\"third\":'" + sr[4].ToString() + "',\"forth\":'" + sr[5].ToString() + "',\"fifth\":'" + sr[6].ToString() + "'}";
                break;
            }
            return str;
        }



        /// <summary>
        /// 根据项目组Id获取项目内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public string GetScoreById(int id)
        {
            string str = "";
            SqlDataReader sr = setbll.GetScoreById(id);
            while (sr.Read()) {
                str += "{\"first\":" + sr[0].ToString() + ",\"second\":" + sr[1].ToString() + ",\"third\":" + sr[2].ToString() + ",\"forth\":" + sr[3].ToString() + ",\"fifth\":" + sr[4].ToString() + "}";
                break;
            }
            return str;
        }




        /// <summary>
        /// 根据项目组ID获取详细标题
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public string GetMoreInfoById(int id)
        {
            string str = "";
            SqlDataReader sr = setbll.GetMoreInfoById(id);
            while (sr.Read()) {
                str += "{\"Theme\":'" + sr[1].ToString() + "',\"First_Item\":'" + sr[2].ToString() + "',\"First_KeyWord\":'" + sr[3].ToString() + "',\"First_Sub1\":'" + sr[4].ToString() + "',\"First_Sub2\":'" + sr[5].ToString() + "',\"First_Sub3\":'" + sr[6].ToString() + "',\"First_Sub4\":'" + sr[7].ToString() + "',\"First_Sub5\":'" + sr[8].ToString() + "',";
                str += "\"Second_Item\":'" + sr[9].ToString() + "',\"Second_KeyWord\":'" + sr[10].ToString() + "',\"Second_Sub1\":'" + sr[11].ToString() + "',\"Second_Sub2\":'" + sr[12].ToString() + "',\"Second_Sub3\":'" + sr[13].ToString() + "',\"Second_Sub4\":'" + sr[14].ToString() + "',\"Second_Sub5\":'" + sr[15].ToString() + "',";
                str += "\"Third_Item\":'" + sr[16].ToString() + "',\"Third_KeyWord\":'" + sr[17].ToString() + "',\"Third_Sub1\":'" + sr[18].ToString() + "',\"Third_Sub2\":'" + sr[19].ToString() + "',\"Third_Sub3\":'" + sr[20].ToString() + "',\"Third_Sub4\":'" + sr[21].ToString() + "',\"Third_Sub5\":'" + sr[22].ToString() + "',";
                str += "\"Forth_Item\":'" + sr[23].ToString() + "',\"Forth_KeyWord\":'" + sr[24].ToString() + "',\"Forth_Sub1\":'" + sr[25].ToString() + "',\"Forth_Sub2\":'" + sr[26].ToString() + "',\"Forth_Sub3\":'" + sr[27].ToString() + "',\"Forth_Sub4\":'" + sr[28].ToString() + "',\"Forth_Sub5\":'" + sr[29].ToString() + "',";
                str += "\"Fifth_Item\":'" + sr[30].ToString() + "',\"Fifth_KeyWord\":'" + sr[31].ToString() + "',\"Fifth_Sub1\":'" + sr[32].ToString() + "',\"Fifth_Sub2\":'" + sr[33].ToString() + "',\"Fifth_Sub3\":'" + sr[34].ToString() + "',\"Fifth_Sub4\":'" + sr[35].ToString() + "',\"Fifth_Sub5\":'" + sr[36].ToString() + "'}";
                break;
            }
            return str;
        }


        /// <summary>
        /// 根据项目组ID获取详细分数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public string GetMoreScoreById(int id)
        {
            string str = "";
            SqlDataReader sr = setbll.GetMoreScoreById(id);
            while (sr.Read())
            {
                str += "{\"First_Value\":" + sr[1].ToString() + ",\"First_Sub1\":" + sr[2].ToString() + ",\"First_Sub2\":" + sr[3].ToString() + ",\"First_Sub3\":" + sr[4].ToString() + ",\"First_Sub4\":" + sr[5].ToString() + ",\"First_Sub5\":"+sr[6].ToString()+",";
                str += "\"Second_Value\":" + sr[7].ToString() + ",\"Second_Sub1\":" + sr[8].ToString() + ",\"Second_Sub2\":" + sr[9].ToString() + ",\"Second_Sub3\":" + sr[10].ToString() + ",\"Second_Sub4\":" + sr[11].ToString() + ",\"Second_Sub5\":" + sr[12].ToString() + ",";
                str += "\"Third_Value\":" + sr[13].ToString() + ",\"Third_Sub1\":" + sr[14].ToString() + ",\"Third_Sub2\":" + sr[15].ToString() + ",\"Third_Sub3\":" + sr[16].ToString() + ",\"Third_Sub4\":" + sr[17].ToString() + ",\"Third_Sub5\":" + sr[18].ToString() + ",";
                str += "\"Forth_Value\":" + sr[19].ToString() + ",\"Forth_Sub1\":" + sr[20].ToString() + ",\"Forth_Sub2\":" + sr[21].ToString() + ",\"Forth_Sub3\":" + sr[22].ToString() + ",\"Forth_Sub4\":" + sr[23].ToString() + ",\"Forth_Sub5\":" + sr[24].ToString() + ",";
                str += "\"Fifth_Value\":" + sr[25].ToString() + ",\"Fifth_Sub1\":" + sr[26].ToString() + ",\"Fifth_Sub2\":" + sr[27].ToString() + ",\"Fifth_Sub3\":" + sr[28].ToString() + ",\"Fifth_Sub4\":" + sr[29].ToString() + ",\"Fifth_Sub5\":" + sr[30].ToString() + "}";
                break;
            }
            return str;
        }
    }
}
