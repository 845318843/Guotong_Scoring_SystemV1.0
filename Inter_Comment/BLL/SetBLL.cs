using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SetBLL
    {
        SetDAL dal = new SetDAL();

        /// <summary>
        /// 获取项目组的最大编号 最后加一
        /// </summary>
        /// <returns></returns>
        public int GetMaxID() {
            return dal.GetMaxID();
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
            
            return dal.addItem( id,  theme,  firstitem,  firstkeyword,  firstsub1,  firstsub2,  firstsub3,  firstsub4,  firstsub5,  seconditem,  secondkeyword,  secondsub1,  secondsub2,  secondsub3,  secondsub4,  secondsub5, thirditem,  thirdkeyword,  thirdsub1,  thirdsub2,  thirdsub3,  thirdsub4,  thirdsub5, forthitem,  forthkeyword,  forthsub1,  forthsub2,  forthsub3,  forthsub4,  forthsub5, fifthitem,  fifthkeyword,  fifthsub1,  fifthsub2,  fifthsub3,  fifthsub4,  fifthsub5);
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
        public bool addValues(int id, int firstvalue, int firstsub1, int firstsub2, int firstsub3, int firstsub4, int firstsub5, int secondvalue, int secondsub1, int secondsub2, int secondsub3, int secondsub4, int secondsub5, int thirdvalue, int thirdsub1, int thirdsub2, int thirdsub3, int thirdsub4, int thirdsub5, int forthvalue, int forthsub1, int forthsub2, int forthsub3, int forthsub4, int forthsub5, int fifthvalue, int fifthsub1, int fifthsub2, int fifthsub3, int fifthsub4, int fifthsub5)
        {
            return dal.addValues( id,  firstvalue,  firstsub1,  firstsub2,  firstsub3,  firstsub4,  firstsub5,  secondvalue,  secondsub1,  secondsub2,  secondsub3,  secondsub4,  secondsub5,  thirdvalue,  thirdsub1,  thirdsub2,  thirdsub3,  thirdsub4,  thirdsub5,  forthvalue,  forthsub1,  forthsub2,  forthsub3,  forthsub4,  forthsub5,  fifthvalue,  fifthsub1,  fifthsub2,  fifthsub3,  fifthsub4,  fifthsub5);
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
            return dal.AlterItem(id, theme, firstitem, firstkeyword, firstsub1, firstsub2, firstsub3, firstsub4, firstsub5, seconditem, secondkeyword, secondsub1, secondsub2, secondsub3, secondsub4, secondsub5, thirditem, thirdkeyword, thirdsub1, thirdsub2, thirdsub3, thirdsub4, thirdsub5, forthitem, forthkeyword, forthsub1, forthsub2, forthsub3, forthsub4, forthsub5, fifthitem, fifthkeyword, fifthsub1, fifthsub2, fifthsub3, fifthsub4, fifthsub5);
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
            return dal.AlterValue( id,  firstvalue,  firstsub1,  firstsub2,  firstsub3,  firstsub4,  firstsub5, secondvalue,  secondsub1,  secondsub2,  secondsub3,  secondsub4,  secondsub5, thirdvalue,  thirdsub1,  thirdsub2,  thirdsub3,  thirdsub4,  thirdsub5, forthvalue,  forthsub1,  forthsub2,  forthsub3,  forthsub4,  forthsub5, fifthvalue,  fifthsub1,  fifthsub2,  fifthsub3,  fifthsub4,  fifthsub5);
        }


        /// <summary>
        /// 设置启动项目
        /// </summary>
        /// <param name="id">启动项ID</param>
        /// <returns></returns>
        public bool SetStartItem(int id){
            return dal.SetStartItem(id);
        }



        /// <summary>
        /// 根据项目组Id获取项目内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetInfoById(int id)
        {
            return dal.GetInfoById(id);
        }



        /// <summary>
        /// 根据项目组Id获取项目内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetScoreById(int id)
        {
            return dal.GetScoreById(id);
        }



        /// <summary>
        /// 根据项目组ID获取详细标题
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetMoreInfoById(int id)
        {
            return dal.GetMoreInfoById(id);
        }


        /// <summary>
        /// 根据项目组ID获取详细分数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader GetMoreScoreById(int id)
        {
            return dal.GetMoreScoreById(id);
        }
    }
}
