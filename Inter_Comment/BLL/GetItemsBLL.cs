using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class GetItemsBLL
    {
        GetItemsDAL dal = new GetItemsDAL();

        /// <summary>
        /// 获取评分项目
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public SqlDataReader getItems(int ID)
        {
            return dal.getItems(ID);
        }
    }
}
