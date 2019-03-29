using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Aspose.Cells;
using System.Data;

namespace DAL
{
    public class ScanGradeDAL
    {
        SqlDb db = new SqlDb();


        /// <summary>
        /// 将指定的成绩迁移到Temp表中
        /// </summary>
        /// <param name="id">项目ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public bool MoveGradeToTemp(int id, string time)
        {
            string strsql = @"declare mycursor
cursor for select Passive,CONVERT(decimal(5,2),AVG(convert(decimal(5,2),First_Item))),CONVERT(decimal(5,2),AVG(convert(decimal(5,2),Second_Item))),CONVERT(decimal(5,2),AVG(convert(decimal(5,2),Third_Item))),CONVERT(decimal(5,2),AVG(convert(decimal(5,2),Forth_Item))),CONVERT(decimal(5,2),AVG(convert(decimal(5,2),Fifth_Item))),(convert(decimal(5,2),avg(convert(decimal(5,2),First_Item)))+convert(decimal(5,2),avg(convert(decimal(5,2),Second_Item)))+convert(decimal(5,2),avg(convert(decimal(5,2),Third_Item)))+convert(decimal(5,2),avg(convert(decimal(5,2),Forth_Item)))+convert(decimal(5,2),AVG(convert(decimal(5,2),Fifth_Item)))) 
from F_Record where ItemsID=@id and (datename(year,Comment_Time)+'-'+datename(month,Comment_Time))=@time
group by Passive;
declare @myname nvarchar(50)
declare @First_Item float
declare @Second_Item float
declare @Third_Item float
declare @Forth_Item float
declare @Fifth_Item float
declare @Sum float
begin
open mycursor
fetch next from mycursor into @myname,@First_Item,@Second_Item,@Third_Item,@Forth_Item,@Fifth_Item,@Sum
while(@@FETCH_STATUS=0)
begin
insert into Temp (Passive,First_Item,Second_Item,Third_Item,Forth_Item,Fifth_Item,Sum_Score) values
(@myname,@First_Item,@Second_Item,@Third_Item,@Forth_Item,@Fifth_Item,@Sum);
fetch next from mycursor into @myname,@First_Item,@Second_Item,@Third_Item,@Forth_Item,@Fifth_Item,@Sum
end
end
close mycursor
deallocate mycursor";
            SqlParameter[] paras = { new SqlParameter("id", id), new SqlParameter("time", time) };
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 将第一项名次迁移到Temp表中
        /// </summary>
        /// <param name="id">项目组ID</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public bool MoveFirstOrderToTemp(int id, string time) {
            string strsql = @"declare mycursor1
cursor for
select Passive,Dense_RANK() over(order by convert(decimal(5,2),avg(convert(decimal(5,2),First_Item))) desc) as num from F_Record where ItemsID=@id and datename(year,Comment_Time)+'-'+datename(month,Comment_Time)=@time group by Passive;
declare @mingci int
declare @myname nvarchar(50)
begin
open mycursor1
fetch next from mycursor1 into @myname,@mingci
while(@@Fetch_Status=0)
begin
update Temp set First_Order=@mingci where Passive=@myname
fetch next from mycursor1 into @myname,@mingci
end
end
close mycursor1
deallocate mycursor1";
            SqlParameter[] paras = { new SqlParameter("@id", id), new SqlParameter("time", time) };
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 将第二项名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool MoveSecondOrderToTemp(int id, string time) {
            string strsql = @"declare mycursor1
cursor for
select Passive,Dense_RANK() over(order by convert(decimal(5,2),avg(convert(decimal(5,2),Second_Item))) desc) as num from F_Record where ItemsID=@id and datename(year,Comment_Time)+'-'+datename(month,Comment_Time)=@time group by Passive;
declare @mingci int
declare @myname nvarchar(50)
begin
open mycursor1
fetch next from mycursor1 into @myname,@mingci
while(@@Fetch_Status=0)
begin
update Temp set Second_Order=@mingci where Passive=@myname
fetch next from mycursor1 into @myname,@mingci
end
end
close mycursor1
deallocate mycursor1";
            SqlParameter[] paras = { new SqlParameter("@id", id), new SqlParameter("time", time) };
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 将第三项名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool MoveThirdOrderToTemp(int id, string time) {
            string strsql = @"declare mycursor1
cursor for
select Passive,Dense_RANK() over(order by convert(decimal(5,2),avg(convert(decimal(5,2),Third_Item))) desc) as num from F_Record where ItemsID=@id and datename(year,Comment_Time)+'-'+datename(month,Comment_Time)=@time group by Passive;
declare @mingci int
declare @myname nvarchar(50)
begin
open mycursor1
fetch next from mycursor1 into @myname,@mingci
while(@@Fetch_Status=0)
begin
update Temp set Third_Order=@mingci where Passive=@myname
fetch next from mycursor1 into @myname,@mingci
end
end
close mycursor1
deallocate mycursor1";
            SqlParameter[] paras = { new SqlParameter("@id", id), new SqlParameter("time", time) };
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 将第四项名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool MoveForthOrderToTemp(int id, string time) {
            string strsql = @"declare mycursor1
cursor for
select Passive,Dense_RANK() over(order by convert(decimal(5,2),avg(convert(decimal(5,2),Forth_Item))) desc) as num from F_Record where ItemsID=@id and datename(year,Comment_Time)+'-'+datename(month,Comment_Time)=@time group by Passive;
declare @mingci int
declare @myname nvarchar(50)
begin
open mycursor1
fetch next from mycursor1 into @myname,@mingci
while(@@Fetch_Status=0)
begin
update Temp set Forth_Order=@mingci where Passive=@myname
fetch next from mycursor1 into @myname,@mingci
end
end
close mycursor1
deallocate mycursor1";
            SqlParameter[] paras = { new SqlParameter("@id", id), new SqlParameter("time", time) };
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 将第五项名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool MoveFifthOrderToTemp(int id, string time) {
            string strsql = @"declare mycursor1
cursor for
select Passive,Dense_RANK() over(order by convert(decimal(5,2),avg(convert(decimal(5,2),Fifth_Item))) desc) as num from F_Record where ItemsID=@id and datename(year,Comment_Time)+'-'+datename(month,Comment_Time)=@time group by Passive;
declare @mingci int
declare @myname nvarchar(50)
begin
open mycursor1
fetch next from mycursor1 into @myname,@mingci
while(@@Fetch_Status=0)
begin
update Temp set Fifth_Order=@mingci where Passive=@myname
fetch next from mycursor1 into @myname,@mingci
end
end
close mycursor1
deallocate mycursor1";
            SqlParameter[] paras = { new SqlParameter("@id", id), new SqlParameter("time", time) };
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 将第总名次迁移到Temp表中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool MoveSumOrderToTemp(int id, string time) {
            string strsql = @"declare mycursor1
cursor for
select Passive,Dense_RANK() over(order by (convert(decimal(5,2),avg(convert(decimal(5,2),First_Item)))+convert(decimal(5,2),avg(convert(decimal(5,2),Second_Item)))+convert(decimal(5,2),avg(convert(decimal(5,2),Third_Item)))+convert(decimal(5,2),avg(convert(decimal(5,2),Forth_Item)))+convert(decimal(5,2),AVG(convert(decimal(5,2),Fifth_Item)))) desc) as num from F_Record where ItemsID=@id and datename(year,Comment_Time)+'-'+datename(month,Comment_Time)=@time group by Passive;
declare @mingci int
declare @myname nvarchar(50)
begin
open mycursor1
fetch next from mycursor1 into @myname,@mingci
while(@@Fetch_Status=0)
begin
update Temp set Sum_Order=@mingci where Passive=@myname
fetch next from mycursor1 into @myname,@mingci
end
end
close mycursor1
deallocate mycursor1";
            SqlParameter[] paras = { new SqlParameter("@id", id), new SqlParameter("time", time) };
            return db.executeSql(strsql, paras);
        }



        /// <summary>
        /// 获取排行榜
        /// </summary>
        /// <returns></returns>
        public SqlDataReader GetGradeFromTemp() {
            string strsql = "select * from Temp order by Sum_Order";
            SqlParameter[] paras = { };
            return db.GetDataReader_ZUO(strsql, paras);
        }



        /// <summary>
        /// 清空Temp表
        /// </summary>
        /// <returns></returns>
        public bool ClearTemp() {
            string strsql = "delete from Temp";
            return db.ExecSql(strsql);
        }


        /// <summary>
        /// 将成绩保存到表中
        /// </summary>
        /// <returns></returns>
        public DataTable GetTable() {
            string strsql = "select * from Temp order by Sum_Order";
            SqlParameter[] paras = { };
            DataTable dt = db.FillDt(strsql, paras);
            return dt;
        }


        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="dt">要导出的表</param>
        /// <param name="ColumnWidth">列宽</param>
        /// <param name="Title">标题</param>
        /// <returns>是否导出成功</returns>
        public bool createlist(DataTable dt,string Title, string firstitem,string seconditem,string thirditem,string forthitem,string fifthitem,string path)
        {
            //一个工作文件有许多个表，就如打开一个.xls问价，里面会自带三个表sheet1,sheet2,sheet3
            //工作文件就是workbook，工作表是sheet是worksheet
            Workbook wb = new Workbook();//工作文件，即.xls文件
            Worksheet ws = wb.Worksheets[0];//工作表，所有工作表均是workbook的内容
            Cells cell = ws.Cells;
            //定义并获取导出的数据源
            string[,] _report = new string[dt.Rows.Count, dt.Columns.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    _report[i, j] = dt.Rows[i][j].ToString();
                }
            }
            //合并第一行单元格  Ranger【范围】
            Range range = cell.CreateRange(0, 0, 1, dt.Columns.Count - 1);//参数分别为开始行，开始列，总行数，总列数
            range.Merge();//合并  还有另一种用法，表一Table1，表二Table2，合并两个表可以用Table1.Merge(Table2)
            cell["A1"].PutValue(Title);
            Range range1 = cell.CreateRange(1, 0, 1, 13);
            //range1.WrapText = true;
            //设置行高
            cell.SetRowHeight(0, 20);
            
            //设定列宽
            double Width1 = 10f;
            double Width2 = 30f;
            //设置字体样式
            Style style = wb.Styles[wb.Styles.Add()];
            style.HorizontalAlignment = TextAlignmentType.Center;
            style.Font.Name = "宋体";
            style.Font.IsBold = true;
            style.Font.Size = 12;

            //设置样式
            Style style2 = wb.Styles[wb.Styles.Add()];
            style2.HorizontalAlignment = TextAlignmentType.Center;
            style2.Font.Size = 10;

            //给单元格关联样式
            cell["A1"].SetStyle(style);//运用样式一

            //设置excel列名
            //for (int i = 0; i < dt.Columns.Count; i++)
            //{
            //cell[1, i].PutValue(dt.Columns[i].ToString());
            //cell[1, i].SetStyle(style2);//运用样式二
            cell[1, 0].PutValue("姓名");
            cell[1, 0].SetStyle(style2);
            cell.SetColumnWidth(0, Width1);
            cell[1, 1].PutValue(firstitem);
            cell[1, 1].SetStyle(style2);
            cell.SetColumnWidth(1, Width2);
            
            cell[1, 2].PutValue("单项名次");
            cell[1, 2].SetStyle(style2);
            cell.SetColumnWidth(2, Width1);
            cell[1, 3].PutValue(seconditem);
            cell[1, 3].SetStyle(style2);
            cell.SetColumnWidth(3, Width2);
            cell[1, 4].PutValue("单项名次");
            cell[1, 4].SetStyle(style2);
            cell.SetColumnWidth(4, Width1);
            cell[1, 5].PutValue(thirditem);
            cell[1, 5].SetStyle(style2);
            cell.SetColumnWidth(5, Width2);
            cell[1, 6].PutValue("单项名次");
            cell[1, 6].SetStyle(style2);
            cell.SetColumnWidth(6, Width1);
            cell[1, 7].PutValue(forthitem);
            cell[1, 7].SetStyle(style2);
            cell.SetColumnWidth(7, Width2);
            cell[1, 8].PutValue("单项名次");
            cell[1, 8].SetStyle(style2);
            cell.SetColumnWidth(8, Width1);
            cell[1, 9].PutValue(fifthitem);
            cell[1, 9].SetStyle(style2);
            cell.SetColumnWidth(9, Width2);
            cell[1, 10].PutValue("单项名次");
            cell[1, 10].SetStyle(style2);
            cell.SetColumnWidth(10, Width1);
            cell[1, 11].PutValue("总分");
            cell[1, 11].SetStyle(style2);
            cell.SetColumnWidth(11, Width1);
            cell[1, 12].PutValue("总名次");
            cell[1, 12].SetStyle(style2);
            cell.SetColumnWidth(12, Width1);
            //}
            
            //设置单元格内容
            int posstart = 2;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    cell[i + posstart, j].PutValue(_report[i, j].ToString());
                    cell[i + posstart, j].SetStyle(style2);
                }
            }

            ////设置列宽
            //for (int i = 0; i < dt.Columns.Count - 1; i++)
            //{
            //    cell.SetColumnWidth(i, Convert.ToDouble(ColumnWidth.ToString()));
            //}

            //保存
            wb.Save(path);
            return true;
        } 
    }
}
