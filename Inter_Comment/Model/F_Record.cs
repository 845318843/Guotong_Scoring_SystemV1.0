using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class F_Record
    {
        private string actor;
        public string Actor
        {
            get { return actor; }
            set { actor = value; }
        }

        private string passive;
        public string Passive
        {
            get { return passive; }
            set { passive = value; }
        }

        private int itemsID;
        public int ItemsID
        {
            get { return itemsID; }
            set { itemsID = value; }
        }

        private int first_Item;
        public int First_Item
        {
            get { return first_Item; }
            set { first_Item = value; }
        }

        private int second_Item;
        public int Second_Item
        {
            get { return second_Item; }
            set { second_Item = value; }
        }

        private int third_Item;
        public int Third_Item
        {
            get { return third_Item; }
            set { third_Item = value; }
        }

        private int forth_Item;
        public int Forth_Item
        {
            get { return forth_Item; }
            set { forth_Item = value; }
        }

        private int fifth_Item;
        public int Fifth_Item
        {
            get { return fifth_Item; }
            set { fifth_Item = value; }
        }

        private DateTime comment_Time;
        public DateTime Comment_Time
        {
            get { return comment_Time; }
            set { comment_Time = value; }
        }
    }
}
