using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Staff
    {
        private int staffID;
        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        private string staff_Name;
        public string Staff_Name
        {
            get { return staff_Name; }
            set { staff_Name = value; }
        }

        private string staff_Pwd;
        public string Staff_Pwd
        {
            get { return staff_Pwd; }
            set { staff_Pwd = value; }
        }

        private bool is_Join;
        public bool Is_Join
        {
            get { return is_Join; }
            set { is_Join = value; }
        }

        private bool is_CanComment;
        public bool Is_CanComment
        {
            get { return is_CanComment; }
            set { is_CanComment = value; }
        }

        private DateTime last_LoginTime;
        public DateTime Last_LoginTime
        {
            get { return last_LoginTime; }
            set { last_LoginTime = value; }
        }
    }
}
